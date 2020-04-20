using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace _9._1
{
    public class SimpleCrawler
    {
        public Hashtable urls = new Hashtable();
        public Hashtable nexturls = new Hashtable();
        public List<Url> used = new List<Url>();
        public int n = 0;
        public int count = 0;
        public bool flag = false;
        static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.Add(startUrl, false);//加入初始页面
            myCrawler.nexturls.Add(startUrl, false);
            myCrawler.Crawl();
        }

        public void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                flag = false;
                foreach (string url in urls.Keys)
                {
                    if (!(bool)urls[url])
                    {
                        current = url;
                        ThreadPool.QueueUserWorkItem(new WaitCallback(CrawlOnce), current);
                        flag = true;
                        count++;
                        if (count > 9)
                        {
                            flag = false;
                            break;
                        }
                         
                    }
                }
                Thread.Sleep(500);
                if (!flag)
                    break;
                foreach (string url in urls.Keys)
                {
                    if (!(bool)urls[url]) break;
                    urls = nexturls;
                }
            }
        }

        public void CrawlOnce(Object cu)
        {
            String current = (String)cu;
            Console.WriteLine("爬行" + current + "页面!");
            used.Add(new Url(current));
            string html = DownLoad(current); // 下载
            urls[current] = true;
            if (Regex.IsMatch(html, "<!DOCTYPE html>"))
                Parse(html, current);//解析,并加入新的链接
            Console.WriteLine("爬行结束");
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public void Parse(string html, string current)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (!Regex.IsMatch(strRef, @"^http") && Regex.IsMatch(strRef, @"^/"))
                    strRef = "https://www.cnblogs.com" + strRef;
                if (!Regex.IsMatch(strRef, @"^http") && !Regex.IsMatch(strRef, @"^/"))
                    strRef = current + strRef;
                if (!Regex.IsMatch(strRef, "cnblogs"))
                    continue;
                if (strRef.Length == 0) continue;
                if (nexturls[strRef] == null) nexturls[strRef] = false;
            }
        }
    }
}
