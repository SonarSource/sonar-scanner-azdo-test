using System.Numerics;

namespace ConsoleApp
{
    public static class Logic
    {
        public static bool AreEqual<T>(T first, T second)
            => EqualityComparer<T>.Default.Equals(first, second);

        public static TSelf Max<TSelf>(TSelf value1, TSelf value2) where TSelf : INumber<TSelf>
        {
            // Test coverage: Don't use a ternary operator to see the missing line coverage
            var compare = value1.CompareTo(value2);
            if (compare > 0)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }
    }
}
