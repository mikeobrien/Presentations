module TypeInference

    open System.Net

    // Where have all the types gone? Done need 'em!

    let getFormattedWebPage url formatter = 
        let webClient = new WebClient()
        let html = webClient.DownloadString(url : string)
        formatter html

    let url = "http://www.google.com"

    let googleHomePageHtml = getFormattedWebPage url (fun x -> x.ToUpper())

    type WebPage = { Url : string; Html : string }

    let googleHomePage = { Url = url; Html = googleHomePageHtml }

    // Automatic Generalization

    let greaterThan x y = x > y
    // val greaterThan: 'a -> 'a -> bool 

    let add x y = x + y
    // val add: int -> int -> int