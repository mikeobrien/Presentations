using System;
using System.Net;

namespace CSharp
{
    public class FirstClassAndHigherOrderFunctions
    {
        string GetFormatedWebPage(string url, Func<string, string> formatter)
        // -----------------------------------^ This is a higher order function because it takes a function as a paramater
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);
            return formatter(html);
        }

        // Also first class
        string TrimFormatter(string text)
        {
            return text.Trim();
        }

        void Sample3()
        {
            var url = "http://www.googl.com";

            // First class function
            Func<string, string> lowerCaseFormatter = x => x.ToLower();

            var googleLowerCaseHomePage = GetFormatedWebPage(url, lowerCaseFormatter);
            // ---------------------------------------------------^ Can be passed into another function

            var googleUpperCaseHomePage = GetFormatedWebPage(url, x => x.ToUpper());
            // ---------------------------------------------------^ Can be passed into another function

            var googleTrimmedHomePage = GetFormatedWebPage(url, TrimFormatter);
            // -------------------------------------------------^ Can be passed into another function
        }
    }
}
