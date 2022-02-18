namespace Algo.Solution;

public class Solution
{
    public string Greet(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException();


        return "Hello " + name + "!";
    }

    public int Add(int a, int b)
    {
        if (a < 0 || b < 0)
            throw new ArgumentException("Can not be negative");

        return a + b;
    }
}