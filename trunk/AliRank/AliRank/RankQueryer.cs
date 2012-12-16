﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;
using System.IO;

namespace AliRank
{
    

    class RankQueryer
    {
        public event RankSearchEndEvent OnRankSearchEndEvent;
        public event RankSearchingEvent OnRankSearchingEvent;

        private string SEARCH_URL = "http://www.alibaba.com/products/F0/{0}/----------------------38/{1}.html";
        private string PERCENT_PATH = "//div[@class='percent-wrap']";
        private string SUBJECT_PATH = "div[@class='attr']/h2/a[@class='qrPTitle']";
        private string AD_PATH = "//div[@class='list-items AD']";
        private string P4P_PATH = "//div[@class='list-items  p4p']";
        private string P4PV2_PATH = "//div[@class='list-items  p4pv2']";
        private ShowcaseRankInfo item;

        public RankQueryer() 
        {
            item = new ShowcaseRankInfo();
        }


        public virtual void FinishedEvent(ShowcaseRankInfo kw, string msg)
        {
            if (OnRankSearchEndEvent != null)
            {
                RankEventArgs e = new RankEventArgs(kw, msg);
                OnRankSearchEndEvent(this, e);
            }
        }
        public virtual void SearchingEvent(ShowcaseRankInfo kw, string msg)
        {
            if (OnRankSearchingEvent != null)
            {
                RankEventArgs e = new RankEventArgs(kw, msg);
                OnRankSearchingEvent(this, e);
            }
        }

        public void Seacher(ShowcaseRankInfo item, int maxQueryPage)
        {
            item.Rank = 0;
            item.KeyAdNum = 0;
            item.KeyP4Num = 0;
            string mainKey = item.RankKeyword.Replace(" ", "_");
            string companyUrl = item.CompanyUrl;
            HtmlDocument document = null;
            for (int i = 0; i < maxQueryPage; i++)
            {
                string url = string.Format(SEARCH_URL, mainKey, (i + 1));
                HtmlWeb clinet = new HtmlWeb();
                SearchingEvent(item, "搜索第[" + i + "]页...");
                document = clinet.Load(url);
                System.Diagnostics.Trace.WriteLine(url + " = " + mainKey);
                if (i == 0)
                {
                    HtmlNodeCollection adNodes = document.DocumentNode.SelectNodes(AD_PATH);
                    HtmlNodeCollection p4pNodes = document.DocumentNode.SelectNodes(P4P_PATH);
                    HtmlNodeCollection p4pv2Nodes = document.DocumentNode.SelectNodes(P4PV2_PATH);
                    
                    if (adNodes != null)
                    {
                        item.KeyAdNum = adNodes.Count;
                    }
                    if (p4pNodes != null)
                    {
                        item.KeyP4Num = p4pNodes.Count;
                    }
                    if (p4pv2Nodes != null)
                    {
                        item.KeyP4Num = item.KeyP4Num + p4pv2Nodes.Count;
                    }
                }
                string comUrlPath = "//div[@class='supplier']/span/a[@href='" + companyUrl.ToLower() + "']";
                HtmlNodeCollection comUrlNode = document.DocumentNode.SelectNodes(comUrlPath);
                if (comUrlNode == null || comUrlNode.Count == 0)
                {
                    continue;
                }
                comUrlPath = "div[@class='supplier']/span/a[@href='" + companyUrl.ToLower() + "']";
                HtmlNodeCollection nodes = document.DocumentNode.SelectNodes(PERCENT_PATH);
                for (int k = 0; k < nodes.Count; k++)
                {
                    HtmlNode percentNode = nodes[k];
                    HtmlNode companyNode = percentNode.SelectSingleNode(comUrlPath);
                    if (companyNode != null)
                    {
                        HtmlNode aLinkNode = percentNode.SelectSingleNode(SUBJECT_PATH);
                        string lsubject = aLinkNode.Id.ToLower();
                        string productName = aLinkNode.InnerText;
                        string proId = lsubject.Replace("lsubject_", "");
                        int rankProductId = Convert.ToInt32(proId);
                        if (rankProductId == item.ProductId)
                        {
                            item.Rank = i * 38 + (k + 1);
                            item.ProductName = productName;
                            break;
                        }
                    }
                }
                if (item.Rank > 0)
                {
                    break;                
                }
            }
            FinishedEvent(item, "Rank search finished.");
        }
    }
}
