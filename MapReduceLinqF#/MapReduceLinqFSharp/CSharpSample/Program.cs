using System;
using System.Linq;

namespace CSharpSample
{
    class Program
    {
        private static string[] Urls = {
				"http://www.trinug.org/location.aspx?locationid=5",
				"http://projecteuler.net/index.php?section=problems&id=1",
				"http://codebetter.com/blogs/jeremy.miller/default.aspx",
				"http://www.lostechies.com/blogs/jimmy_bogard/default.aspx"};

        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------- MAP --------------------------------------");
            Map.GetHosts_FuncQuery(Urls).ToList().ForEach(url => Console.WriteLine(url));
            Console.WriteLine();

            Console.WriteLine("------------------------------------ REDUCE ------------------------------------");
            Console.WriteLine(Reduce.GetHostsCSV_FuncExtension(Urls));
            Console.WriteLine();

            Console.WriteLine("---------------------------------- MAP/REDUCE ----------------------------------");
            Console.WriteLine(MapReduce.GetHostsCSV(Urls));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
