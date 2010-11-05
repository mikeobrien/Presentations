module Lambdas

    open System

    let printMe x = Console.WriteLine(x.ToString())

    let notALambda () = "I'm not a lambda!"
    // -^ I'm bound to a name so I'm not in the lambda club

    printMe notALambda

    printMe (fun () -> "I am totally a lambda!")
    // -----^ I'm not bound to a name so I'm a lambda

    let alsoALambda = (fun () -> "I am totally a lambda too!")
    // ---------------^ I'm still not bound to a name even though I'm assigned to a value

    printMe alsoALambda