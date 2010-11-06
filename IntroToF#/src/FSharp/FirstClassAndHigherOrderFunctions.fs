module FirstClassAndHigherOrderFunctions
    
    open System.Net

    let getFormattedWebPage url formatter = 
        // ------------^ This is a higher order function because it takes a function as a paramater
        let webClient = new WebClient()
        let html = webClient.DownloadString(url : string)
        formatter html

    let lowerCaseFormatter x = x.ToString().ToLower()

    let googleLowerCaseHomePage = getWebPage "http://www.google.com" lowerCaseFormatter
    // --------------------------------------------------------------^ First class baby!

    let googleUpperCaseHomePage = getWebPage "http://www.google.com" (fun x -> x.ToLower())
    // --------------------------------------------------------------^ First class baby!
