using System;

namespace EnumerableExtensions
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new() { 10, 19, 22, -5, -11, 28, 31, 3, 2, 1 };
            var final = result.ToList();
            _ = final.GetEnumerator();
            _ = result._First();
            _ = result._Add(3);
            _ = result._Sub(2);
            _ = result._Mul(5);
            _ = result._Div(2);
            _ = result._MinMax(1, 10);
        }
    }
}
