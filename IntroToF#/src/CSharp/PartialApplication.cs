using System;

namespace CSharp
{
    class PartialApplication
    {
        void Sample()
        {
            // I am curried so I can be partially applied
            Func<int, Func<int, int>> add = x => y => x + y;

            // I want to create an increment function
            Func<int, int> increment1 = x => x + 1;

            // Lets create a funtion that increments, that is based on the add function
            // We partially apply it by specifying the first parameter as 1
            Func<int, int> increment2 = add(1);

            // add(1) = add = 1 => y => 1 + y

            var index = 0;

            index = increment2(index); // index = 1
            index = increment2(index); // index = 2
            index = increment2(index); // index = 3
            // ...
        }
    }
}
