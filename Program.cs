namespace LexicographicalNumbersCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

    }
}
public class Solution
{
    public IList<int> LexicalOrder(int n)
    {
        return Enumerable.Range(1, n).OrderBy(x => x.ToString(), StringComparer.CurrentCultureIgnoreCase).ToList();
    }
}