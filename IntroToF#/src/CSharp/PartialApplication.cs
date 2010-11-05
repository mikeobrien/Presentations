using System;

namespace CSharp
{
    class PartialApplication
    {
        void Sample()
        {
            // I am curried so I can be partially applied
            Func<int, Func<int, int>> add = x => y => x + y;

            // Lets create a funtion that increments, that is based on the add function
            // We partially apply it by specifying the first parameter as 1
            Func<int, int> increment = add(1);

            var index = 0;

            index = increment(index); // index = 1
            index = increment(index); // index = 2
            index = increment(index); // index = 3
            // ...
        }
    }
}
