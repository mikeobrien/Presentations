using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSample
{
    public static class Map
    {
        // Imperative Map
        public static string[] GetHosts_Imperative(string[] urls)
        {
            string[] newUrls = new string[urls.Length];
            for (int index = 0; index < urls.Length; index++)
            {
                string[] urlParts = urls[index].Split(new[] { '/' });
                newUrls[index] = urlParts[2];
            }
            return newUrls;
        }
            
        // OO Approach, .NET 1.0/1.1
        public static string[] GetHosts_OO_10_11(string[] urls)
        {
            ArrayList newUrls = new ArrayList();
            foreach (string url in urls)
            {
                newUrls.Add(new Uri(url).Host);
            }
            return (string[])newUrls.ToArray(typeof(string));
        }
            
        // OO Approach, .NET 2.0+
        public static IEnumerable<string> GetHosts_OO_20(IEnumerable<string> urls)
        {
            foreach (string url in urls)
            {
                yield return new Uri(url).Host;
            }
        }

        // Functional Approaches, .NET 3.5+
        public static IEnumerable<string> GetHosts_FuncExtension(IEnumerable<string> urls)
        {
            return urls.Select(url => new Uri(url).Host);
        }

        public static IEnumerable<string> GetHosts_FuncQuery(IEnumerable<string> urls)
        {
            return from url in urls select new Uri(url).Host;
        }
    }
}
