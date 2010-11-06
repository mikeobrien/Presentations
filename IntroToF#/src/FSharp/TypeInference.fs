module TypeInference

    open System.Net

    // Where have all the types gone? Done need 'em!

    let getFormattedWebPage url formatter = 
        let webClient = new WebClient()
        let html = webClient.DownloadString(url : string)
        (url, formatter html)

    let url = "http://www.google.com"

    let googleHomePageHtml = getFormattedWebPage url (fun x -> x.ToUpper())



    // Automatic Generalization

    let greaterThan a b = a > b
    // val greaterThan: 'a -> 'a -> bool 

    let add x y = x + y
    // val add: int -> int -> int