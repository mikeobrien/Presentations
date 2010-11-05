using System;

namespace CSharp
{
    class Lambdas
    {
        void Sample()
        {
            Action<Func<string>> printMe = x => Console.WriteLine(x());

            printMe(() => "I am totally a lambda!");
            // -----^ I'm not bound to a name so I'm a lambda

            Func<String> alsoALambda = () => "I'm a lambda too!";
            // ------------------------^ I'm also not bound to a name although I am assigned to a variable.

            printMe(alsoALambda);
        }

        string ImDefinitelyNotALambda() { return "I'm not a lambda.... :("; }
        // ----^ I'm bound to a name so I'm not a lambda.
    }
}
