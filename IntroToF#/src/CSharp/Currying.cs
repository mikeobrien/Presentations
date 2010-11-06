using System;

namespace CSharp
{
    class Currying
    {
        void Sample()
        {
            // Not curried
            Func<int, int, int> add1 = (x, y) => x + y;

            // I am curried
            Func<int, Func<int, int>> add2 = x => y => x + y;
            
            // Calling a non curried function
            var result1 = add1(10, 5);

            // Calling a curried function, the first function returns a function which returns a result.
            var firstFunction = add2(10);
            var result = firstFunction(5);

            var result2 = add2(10)(5);
        }
    }
}
