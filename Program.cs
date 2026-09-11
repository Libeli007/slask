namespace simpleGit;

class Program
{
    static void Main()
    {
        Console.WriteLine(DoSomething("Bruno"));
    }

    static string DoSomething(string name)
    {
        return $"Hello {name}";
    }
}
