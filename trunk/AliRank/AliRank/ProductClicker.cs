﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace AliRank
{
    

    class ProductClicker
    {
        public event RankClickEndEvent OnRankClickEndEvent;
        public event RankClickingEvent OnRankClickingEvent;
        public event RankInquiryEndEvent OnInquiryEndEvent;
        private WebBrowser browser;
        ManualResetEvent eventX = new ManualResetEvent(false);

        private string SEARCH_URL1 = @"http://www.alibaba.com/trade/search?SearchText={0}&IndexArea=product_en&fsb=y";
        private string SEARCH_URL2 = @"http://www.alibaba.com/products/F0/{0}/{1}.html";
        private string PURL_PREFIX = @"http://www.alibaba.com/product-gs/";

        private string SEND_MESSAGE = @"http://message.alibaba.com/msgsend/contact.htm";
        private string INQUIRY_SUCCESS = "http://cn.message.alibaba.com/msgsend/memberInquirySuccess.htm";
        int currentPage = 1;
        int maxQueryPage = 10;
        private ShowcaseRankInfo item;
        private AliAccounts aliAccount;
        private InquiryMessages inquiryMessage;
        private bool canInquiry;
        private string clickKey = string.Empty;
        private string currentRequestUrl;
        public ProductClicker(WebBrowser b) 
        {
            browser = b;
        }


        public virtual void ClickedEvent(ShowcaseRankInfo kw, string msg)
        {
            if (OnRankClickEndEvent != null)
            {
                RankEventArgs e = new RankEventArgs(kw, msg);
                OnRankClickEndEvent(this, e);
            }
        }
        public virtual void ClickingEvent(ShowcaseRankInfo kw, string msg)
        {
            if (OnRankClickingEvent != null)
            {
                RankEventArgs e = new RankEventArgs(kw, msg);
                OnRankClickingEvent(this, e);
            }
        }

        public virtual void InquiryEndEvent(InquiryInfos kw, string msg)
        {
            if (OnInquiryEndEvent != null)
            {
                InquiryEventArgs e = new InquiryEventArgs(kw, msg);
                OnInquiryEndEvent(this, e);
            }
        }

        public void DoClick(ShowcaseRankInfo kw, int maxQueryPageNumber, AliAccounts account, bool canInquiry, InquiryMessages msg)
        {
            this.item = kw;
            this.aliAccount = account;
            this.inquiryMessage = msg;
            this.canInquiry = canInquiry;
            this.maxQueryPage = maxQueryPageNumber;
            this.clickKey = item.RankKeyword;
            currentRequestUrl = string.Format(SEARCH_URL1, clickKey.Replace(" ", "+"));
            ClickingEvent(item, "Clicking " + currentRequestUrl);
            browser.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(browser_DocumentCompleted);
            browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(browser_DocumentCompleted);
            browser.Navigate(currentRequestUrl);
            eventX.WaitOne(Timeout.Infinite, true);
            Console.WriteLine("线程池结束！");
        }

        void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser browser = (WebBrowser)sender;
            if (browser.ReadyState != System.Windows.Forms.WebBrowserReadyState.Complete)
                return;
            if (e.Url.ToString() != browser.Url.ToString())
                return;
            if (browser.Url.ToString() == currentRequestUrl)
            {
                HtmlElement productLink = browser.Document.GetElementById("lsubject_" + this.item.ProductId);
                if (productLink != null)
                {
                    productLink.SetAttribute("target", "_self");
                    browser.Document.InvokeScript("onProductClick", new object[] { item.ProductId });
                    //browser.Document.InvokeScript("onProductClick('" + item.ProductId + "');");
                    //browser.Document.InvokeScript("logProductHistory", new object[] { item.ProductId, new string[]{}});
                    productLink.InvokeMember("click");
                }
                else
                {
                    if (currentPage == maxQueryPage)
                    {
                        ClickedEvent(item, "The system does not find the product you need to click.");
                        string productUrl = item.ProductUrl.Substring(item.ProductUrl.LastIndexOf("/"));
                        currentRequestUrl = PURL_PREFIX + item.ProductId + productUrl;
                        ClickingEvent(item, "Enforce clicking " + currentRequestUrl);
                        browser.Document.InvokeScript("onProductClick", new object[] { item.ProductId });
                        //browser.Document.InvokeScript("onProductClick('" + item.ProductId + "');");
                        //browser.Document.InvokeScript("logProductHistory", new object[] { item.ProductId, new string[]{}});
                        browser.Navigate(currentRequestUrl);
                    }
                    else
                    {
                        currentPage++;
                        currentRequestUrl = string.Format(SEARCH_URL2, clickKey.Replace(" ", "_"), currentPage);
                        Random r = new Random();
                        int randomNumber = r.Next(100, 5000);
                        if (currentPage > 0) Thread.Sleep(randomNumber);
                        ClickingEvent(item, "Clicking " + currentRequestUrl);
                        browser.Navigate(currentRequestUrl);
                    }
                }
            }
            if (browser.Url.ToString().StartsWith(PURL_PREFIX + item.ProductId))
            {
                item.Clicked = item.Clicked + 1;
                ClickedEvent(item, "This product has been successfully click.");
                HtmlElement messageLink = browser.Document.GetElementById("position2");
                if (messageLink != null)
                {
                    messageLink.SetAttribute("target", "_self");
                    messageLink.InvokeMember("click");
                }
                if (!this.canInquiry)
                {
                    browser.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(browser_DocumentCompleted);
                    eventX.Set();
                }
            }
            if (browser.Url.ToString().StartsWith(SEND_MESSAGE))
            {


                string postUrl = "http://message.alibaba.com/msgsend/inquiry.htm";
                string html = browser.Document.Body.InnerHtml;
                string token = "_csrf_token_=" + browser.Document.All["_csrf_token_"].GetAttribute("value");
                string action = "action=SendMemberInquiryAction";
                string sh = "_fmm.b._0.sh=false";
                string pageId = "pageId=" + GetDmtrackPageid(html);
                string chkProductIds = "chkProductIds="+ browser.Document.All["chkProductIds"].GetAttribute("value");
                string s = "_fmm.b._0.s=" + browser.Document.GetElementById("subject").GetAttribute("value");
                string msgContent = inquiryMessage.Content + "\r\n." + DateTime.Now.ToLongTimeString();
                string c = "_fmm.b._0.c=<p>" + msgContent.Replace("\r\n", "<br>") + "<p>";
                int randomNumber = new Random().Next(1, 20) * 100;
                string o = "_fmm.a._0.o=" + randomNumber + " Piece/Pieces";
                string attachs = "attachs=";
                string eventSubmitDoSend = "eventSubmitDoSend=Send";
                string postString = token + "&" + action + "&" + sh + "&" + pageId + "&" + chkProductIds + "&" + s + "&"
                    + c + "&" + o + "&" + attachs + "&" + eventSubmitDoSend;
                byte[] postData = Encoding.Default.GetBytes(postString);
                browser.Navigate(postUrl, "_self", postData, "");
                /*
                HtmlElement orderQuantity = browser.Document.GetElementById("orderQuantity");
                if (orderQuantity != null)
                {
                    int randomNumber = new Random().Next(1, 20) * 100;
                    orderQuantity.SetAttribute("value", randomNumber.ToString());
                    browser.Document.GetElementById("orderQuantityTemp").SetAttribute("value", randomNumber.ToString());
                }

                HtmlElement email = browser.Document.GetElementById("email");
                if (email != null)
                {
                    //email.SetAttribute("value", "hunan.yuyi@gmail.com");
                }
                string msgContent = inquiryMessage.Content + "\r\n." + DateTime.Now.ToLongTimeString();
                HtmlElement contentMessage = browser.Document.GetElementById("contentMessage");
                if (contentMessage != null)
                {
                    //browser.Document.InvokeScript("tinyMCE.getInstanceById('contentMessage').setContext(\"please send me quote about the product.\r\n=======InvokeScript=======by luke\");");
                    contentMessage.SetAttribute("value", msgContent);
                }

                HtmlElement sendButton = browser.Document.GetElementById("send");
                if (sendButton != null)
                {
                    sendButton.InvokeMember("click");
                }
                 * */
            }

            if (browser.Url.ToString().StartsWith(INQUIRY_SUCCESS))
            {
                InquiryInfos info = new InquiryInfos();
                info.ProductId = item.ProductId;
                info.AccountId = aliAccount.AccountId;
                info.MsgId = inquiryMessage.MsgId;
                info.InquiryDate = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
                info.Company = item.CompanyUrl;
                info.InquiryIp = aliAccount.LoginIp;
                InquiryEndEvent(info, "This product has been send a Rank Inquiry.");
                browser.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(browser_DocumentCompleted);
                eventX.Set();
            }
        }

        public string GetDmtrackPageid(string html)
        {
            Regex r = new Regex("var dmtrack_pageid='(.*?)';");
            GroupCollection gc = r.Match(html).Groups;
            if (gc != null && gc.Count > 1)
            {
                return gc[1].Value.Trim();
            }
            return "";
        }
       
    }
}