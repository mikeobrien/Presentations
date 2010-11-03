module Map
    open System

    let GetHosts urls = Seq.map (fun url -> (new Uri(url)).Host) urls