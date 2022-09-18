// See https://aka.ms/new-console-template for more information

class TestClass
{
    static void Main(string[] args)
    {

        double f = 0, a = 0, x = 0, c = 0, b = 0;
        Console.WriteLine("Input a  ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input b  ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input x  ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Input c  ");
        c = Convert.ToDouble(Console.ReadLine());
        if (x == 0 && b != 0)
        {
            f = a * (x + c) * (x + c) - b;
        }
        else if (x == 0 && b == 0)
        {
            f = (x - a) / (-c);
        }
        else
        {
            f = a + x / c;
        }
        Console.WriteLine("f= " + f);
    }
}

