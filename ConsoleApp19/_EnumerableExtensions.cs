public static class _EnumerableExtensions
{


    public static IEnumerable<int> Add(this IEnumerable<int> soure)
    {
        foreach (var item in soure)
        {
            yield return item + 5;
        }
    }
    public static IEnumerable<int> Add1(this IEnumerable<int> soure)
    {
        List<int> lll = new();
        foreach (var item in soure)
        {
            lll.Add(item + 5);
        }
        return lll;
    }
    public static IEnumerable<int> Test1(this IEnumerable<int> source, int dummy)
    {
        List<int> l = new();
        foreach (var item in source)
        {
            if (item > dummy)
                l.Add(item);
        }
        return l;
    }
    public static IEnumerable<int> Multiple(this IEnumerable<int> source, int dummy)
    {
        List<int> list = new();
        foreach (var item in source)
        {
            yield return item * dummy;
        }
    }
    public static IEnumerable<int> Multiple1(this IEnumerable<int> source, int dummy)
    {
        List<int> list1 = new List<int>();
        foreach (var item in source)
        {
            list1.Add(item * dummy);
        }
        return list1;
    }
    public static IEnumerable<int> Div(this IEnumerable<int> source, int dummy)
    {
        List<int> list = new List<int>();
        foreach (var item in source)
        {
            yield return item / dummy;
        }
    }

    public static IEnumerable<int> Div1(this IEnumerable<int> source, int dummy)
    {
        List<int> list1 = new List<int>();
        foreach (var item in source)
        {
            list1.Add(item / dummy);
        }
        return list1;
    }
    public static IEnumerable<int> First(this IEnumerable<int> source)
    {
        if (source == null)
        {
            throw new ArgumentNullException("null");
        }
        foreach (var item in source)
        {
            yield return item;
            yield break;
        }
    }
    public static IEnumerable<int> _First(this IEnumerable<int> source)
    {
        if (source == null) throw new ArgumentNullException();
        foreach (var item in source)
        {
            yield return item;
            yield break;
        }
    }
    public static IEnumerable<int> _MinMax(this IEnumerable<int> source, int min)
    {
        foreach (var item in source)
        {
            if (item > min)
                yield return item;
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
    public static IEnumerable<int> _Add(this IEnumerable<int> source, int factor)
    {
        foreach (var item in source)
        {
            yield return item + factor;
        }
    }
    public static IEnumerable<int> _Sub(this IEnumerable<int> source, int factor)
    {
        foreach (var item in source)
        {
            yield return item - factor;
        }
    }
    public static IEnumerable<int> _Mul(this IEnumerable<int> source, int factor)
    {
        if (source == null) throw new ArgumentNullException();
        foreach (var item in source)
        {
            yield return item * factor;
        }
    }
    public static IEnumerable<int> _Div(this IEnumerable<int> source, int factor)
    {
        if (source == null) throw new ArgumentNullException();
        foreach (var item in source)
        {
            yield return item / factor;
        }
    }
}
