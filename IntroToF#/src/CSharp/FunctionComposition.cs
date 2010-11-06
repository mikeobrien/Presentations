using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp
{
    class FunctionComposition
    {
        void Sample()
        {
            var result = new [] {2, 56, 94, 65}.
                         Where(x => x > 10).
                         Select(x => x * x).
                         Sum();
        }
    }
}
