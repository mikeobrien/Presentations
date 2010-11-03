using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpSample
{
    public static class Reduce
    {
        // NOTE: I'm purposly not using the string join function for the purpose 
        //       of demonstration so pretend it doesn't exist... :)

        // Imperative
        public static string GetHostsCSV_Imperative(string[] domains)
        {
            string data = "";
            for (int index = 0; index < domains.Length; index++)
            {
                if (index > 0) data = data + ",";
                data = data + "\"" + domains[index] + "\"";
            }
            return data;
        }

        // OO Approach, .NET
        public static string GetHostsCSV_OO(IEnumerable<string> domains)
        {
            StringBuilder data = new StringBuilder();
            foreach (string domain in domains)
            {
                if (data.Length > 0) data.Append(",");
                data.Append(string.Format("\"{0}\"", domain));
            }
            return data.ToString();
        }

        // Functional Approach, Extension Methods, .NET 3.5+
        public static string GetHostsCSV_FuncExtension(IEnumerable<string> domains)
        {
            return domains.Aggregate((state, item) => state + ", " + item);
        }			
    }
}
