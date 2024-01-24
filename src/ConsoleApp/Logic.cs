using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Logic
    {
        public static bool AreEqual<T>(T first, T second)
            => EqualityComparer<T>.Default.Equals(first, second);
    }
}
