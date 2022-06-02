using System;

namespace EnumerableExtensions
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new(){ 5, 21, 12, 6, -18, -59, 31, 3, 2, 4 };
            var final = result.ToList();
            _ = final.GetEnumerator();
            _ = result._First();
            _ = result._Add(2);
            _ = result._Sub(1);
            _ = result._Mul(10);
            _ = result._Div(3);
            _ = result._MinMax(3, 10);
        }
    }
}
