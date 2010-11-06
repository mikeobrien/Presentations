using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp
{
    class Tuple
    {
        void Sample()
        {
            var pointTuple = new Tuple<int, int>(10, 5);

            var x = pointTuple.Item1;
            var y = pointTuple.Item2;
        }

        public class TupleTypeExample<T1, T2>
        {
            public readonly T1 Value1;
            public readonly T2 Value2;

            public TupleTypeExample(T1 value1, T2 value2)
            {
                Value1 = value1;
                Value2 = value2;
            }
        }
    }
}
