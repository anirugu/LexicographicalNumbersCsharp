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
        List<int> value = new List<int>();
        if (n > 0)
            value.Add(0);
        
        for (int i = 0; i < 9; i++)
        {
            value.Add(i);
        }
    }

    public IList<int> DSF(List<int> value, int start, int n)
    {
        for (int i = start * 10; i < n; i++)
        {
            value.Add(i);
            
        }
        yield break;
    }
}