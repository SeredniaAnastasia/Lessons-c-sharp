// See https://aka.ms/new-console-template for more information

class TestClass
{
static void Main(string[] args)
{
       int a1 = 0, a2 = 0, a3 = 0;
        Console.WriteLine("Input first number");
        a1 = Convert.ToInt32(Console.ReadLine());
        a2 = a1 + 5;
        a3 = a1 + 5;
        Console.WriteLine(a1);
        Console.WriteLine(a2);
        Console.WriteLine(a3);
}
}

