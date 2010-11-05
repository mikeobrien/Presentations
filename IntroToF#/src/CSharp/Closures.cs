using System;

namespace CSharp
{
    class Closures
    {
        private string _someMessage = "Dag yo!";

        void Sample()
        {
            Action<Func<string>> printMe = x => Console.WriteLine(x());

            printMe(() => "I'm a lambda but not a closure");
            // -----------^ I'm not a closure because I'm not referencing a local variable

            printMe(() => _someMessage);
            // -----------^ Still not a closure because there is nothing to lift that will go out of scope.
            //              _someMessage is not going anywhere because it is class scoped.

            // I'm out of scope as soon as this function ends so I need lifted to live on in infamy.
            var message = "I need lifting.";

            printMe(() => message);
            // -----------^ Ah! Now I'm a closure because I'm referencing a local variable which will 
            //              need to get "closed up" so it can out live the scope of this function.

            printMe(IAmNotAClosure);
        }

        string IAmNotAClosure()
        // ----^ Not a closure because there is nothing to lift that will go out of scope.
        //       _someMessage is not going anywhere.
        {
            return _someMessage;
        }
    }
}
