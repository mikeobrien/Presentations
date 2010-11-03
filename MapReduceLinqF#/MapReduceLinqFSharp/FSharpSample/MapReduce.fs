module MapReduce
    open System

    let UrlsToCsv urls = urls |> Seq.map (fun url -> (new Uri(url)).Host) |> Seq.reduce (fun state item -> state + ", " + item)