module Reduce
    open System

    let HostsToCsv urls = urls |> Seq.reduce (fun state item -> state + ", " + item)