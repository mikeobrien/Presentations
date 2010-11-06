using System;
using System.Net;

namespace CSharp
{
    public class TypeInference
    {
        string GetFormatedWebPage(string url, Func<string, string> formatter)
        {
            WebClient webClient = new WebClient();
            string html = webClient.DownloadString(url);
            return formatter(html);
        }

        void Sample2()
        {
            string url = "http://www.googl.com";

            string googleHomePage = GetFormatedWebPage(url, delegate(string x) { return x.ToUpper(); });

            Tuple<string, string> webPage = new Tuple<string, string>(url, googleHomePage);
        }

        // -----------------------------------------------------------------------------------------------------

        string GetFormatedWebPage2(string url, Func<string, string> formatter)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);
            return formatter(html);
        }

        void Sample3()
        {
            var url = "http://www.googl.com";

            var googleHomePage = GetFormatedWebPage(url, x => x.ToUpper());

            var webPage = new Tuple<string,string>(url, googleHomePage);
        }
    }
}
