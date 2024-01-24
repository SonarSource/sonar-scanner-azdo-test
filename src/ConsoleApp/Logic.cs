using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Logic
    {
        public static bool AreEqual<T>(T first, T second)
            => EqualityComparer<T>.Default.Equals(first, second);

        public static TSelf Max<TSelf>(TSelf value1, TSelf value2) where TSelf : INumber<TSelf> => 
            value1.CompareTo(value2) > 0 ? value1 : value2;
    }
}
