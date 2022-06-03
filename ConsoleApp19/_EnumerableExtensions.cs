public static class _EnumerableExtensions
{
    public static IEnumerable<int> _First(this IEnumerable<int> source)
    {
        if (source == null)
        {
            throw new ArgumentNullException();
        }
        foreach (var item in source)
        {
            yield return item;
            yield break;
        }
    }
    public static IEnumerable<int> _MinMax(this IEnumerable<int> source, int min, int max)
    {
        foreach (var item in source)
        {
            if (item > min && item < max)
                yield return item;
        }
    }
    public static IEnumerable<int> _Add(this IEnumerable<int> source, int value)
    {
        foreach (var item in source)
        {
            yield return item + value;
        }
    }
    public static IEnumerable<int> _Sub(this IEnumerable<int> source, int value)
    {
        foreach (var item in source)
        {
            yield return item - value;
        }
    }
    public static IEnumerable<int> _Mul(this IEnumerable<int> source, int value)
    {
        if (source == null) throw new ArgumentNullException();
        foreach (var item in source)
        {
            yield return item * value;
        }
    }
    public static IEnumerable<int> _Div(this IEnumerable<int> source, int value)
    {
        if (source == null) throw new ArgumentNullException();
        foreach (var item in source)
        {
            yield return item / value;
        }
    }
}
