module Closures

    open System

    let printMe x = Console.WriteLine(x.ToString())

    let someMessage = "Dag yo!"

    printMe (fun () -> "I'm a lambda but not a closure.")
    // ----------------^ I'm not a closure because I'm not referencing a local variable

    printMe (fun () -> someMessage)
    // ----------------^ Still not a closure because there is nothing to lift that will go out of scope.
    //                   someMessage is not going anywhere because it is class scoped.

    let printSomething1 message =
        printMe (fun () -> message)
    // --------------------^ Ah! Now I'm a closure because I'm referencing a local variable which will 
    //                       need to get "closed up" so it can out live the scope of this function.

