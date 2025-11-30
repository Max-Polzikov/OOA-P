using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace IteratorCumulatives
{
    public abstract class IteratorCumulative : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}