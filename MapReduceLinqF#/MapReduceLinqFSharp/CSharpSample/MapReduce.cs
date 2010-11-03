using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpSample
{
    class MapReduce
    {
        public static string GetHostsCSV(IEnumerable<string> urls)
        {
            return urls.Select(url => new Uri(url).Host).Aggregate((state, item) => state + ", " + item);
        }
    }
}
