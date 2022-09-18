// See https://aka.ms/new-console-template for more information

class TestClass
{
static void Main(string[] args)
{

double z1=0, z2=0, n=0, m=0;
        Console.WriteLine ("Input n  ");
        n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Input m  ");
        m=Convert.ToInt32(Console.ReadLine());
        z1=(n-1)*Math.Sqrt(n)-(m-1)*Math.Sqrt(m)/Math.Sqrt(Math.Pow(n,3)*m)+m*n+n*n-n;
        z2=Math.Sqrt(n)-Math.Sqrt(m)/n;
        Console.WriteLine ("z1= " + z1);
        Console.WriteLine ("z2= " + z2);
}

