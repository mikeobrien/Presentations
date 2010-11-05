using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    //let printMe x = Console.WriteLine(x.ToString())

    //let notALambda () = "I'm not a lambda!"
    //// -^ I'm bound to a name so I'm not in the lambda club

    //printMe notALambda

    //printMe (fun () -> "I am totally a lambda!")
    //// -----^ I'm not bound to a name so I'm a lambda

    //let printMeWithADate x =
    //    let currentDateTime = DateTime.Now.ToString()
    //    printMe (fun () -> x + currentDateTime)
    //    // ----------------^---^ Whoa! I'm picking up locally scopped values! I'm now a closure!

    //let printMeWithADate2 x =
    //    printMe (fun () -> "Hello, its " + DateTime.Now.ToString())
    //    // ----------------^ Hmmm, not picking up locally scoped values anymore. I'm not a closure.

namespace CSharp
{
    class LambdasAndClosures
    {
    }
}
