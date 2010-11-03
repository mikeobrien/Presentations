open System

let urls = ["http://www.trinug.org/location.aspx?locationid=5";
            "http://projecteuler.net/index.php?section=problems&id=1";
            "http://codebetter.com/blogs/jeremy.miller/default.aspx";
            "http://www.lostechies.com/blogs/jimmy_bogard/default.aspx"]

Console.WriteLine("------------------------------------- MAP --------------------------------------")
Map.GetHosts urls |> Seq.iter (fun host -> Console.WriteLine(host))
Console.WriteLine()

Console.WriteLine("------------------------------------ REDUCE ------------------------------------")
Console.WriteLine(Reduce.HostsToCsv urls)
Console.WriteLine()

Console.WriteLine("---------------------------------- MAP/REDUCE ----------------------------------")
Console.WriteLine(MapReduce.UrlsToCsv urls)

Console.ReadKey() |> ignore
