using System;
using System.Net;

namespace CSharp
{
    public class TypeInference
    {
        #region Type Infered vs Not Infered

        class SomeGenericClass<T1, T2, T3>
        {
            public T1 DoSomething<TSomething>(TSomething something, T2 doh, T3 doubleDohForYou)
            {
                return default(T1);
            }
        }

        void Sample()
        {
            // WOW what a mouthfull!

            SomeGenericClass<string, bool, DateTime> uglyExample = new SomeGenericClass<string, bool, DateTime>();

            string result = uglyExample.DoSomething<DateTime>(DateTime.Now, false, DateTime.Now);

            Func<string, bool> myFuntion = delegate(string x) { return x.Length > 10; };

            // Ok, lets use some type inference

            var terseExample = new SomeGenericClass<string, bool, DateTime>();

            var result2 = terseExample.DoSomething(DateTime.Now, false, DateTime.Now);

            Func<string, bool> myFunction2 = x => x.Length > 10;
        }

        #endregion

        #region Get Web Page

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

            WebPage webPage = new WebPage {Url = url, Html = googleHomePage};
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

            var webPage = new WebPage { Url = url, Html = googleHomePage };
        }

        #endregion
    }

    public class WebPage
    {
        public string Url { get; set; }
        public string Html { get; set; }
    }
}
