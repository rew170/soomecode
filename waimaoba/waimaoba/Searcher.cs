﻿using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace com.soomes
{
    class Searcher
    {
       
        public Searcher() { }

        //深度3 //最大线程数10
        public void DoSearch(string url)
        {
            if (url.EndsWith("/"))
            {
                url = url.Substring(0, url.Length-1);
            }
            HtmlWeb clinet = new HtmlWeb();
            List<string> links = new List<string>();
            HtmlDocument document = clinet.Load(url);
            HtmlNodeCollection linkNodes = document.DocumentNode.SelectNodes("//a");
            foreach (HtmlNode linkNode in linkNodes)
            {
                if (linkNode.Attributes["href"] != null)
                {
                    string currUrl = linkNode.Attributes["href"].Value;
                    if (currUrl == "" || currUrl == "#")
                    {
                        continue;
                    }
                    string currFullUrl = currUrl;
                    if (currUrl.StartsWith("/"))
                    {
                        currFullUrl = url + currUrl;
                        Console.WriteLine("localhstURL: "+ currFullUrl);
                    }
                    else 
                    {
                        Console.WriteLine(currFullUrl);
                    }
                    if (!links.Contains(currFullUrl))
                    {
                        links.Add(currFullUrl);
                    }
                }
                    
            }

        }
    }


}
