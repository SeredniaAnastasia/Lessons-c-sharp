// See https://aka.ms/new-console-template for more information

class TestClass
{
static void Main(string[] args)
{
  int r=0; 
            Console.WriteLine ("Input radius  ");
         r=Convert.ToInt32(Console.ReadLine());
         r=r+20;
         double s=Math.PI*Math.Pow(r,2)-Math.PI*Math.Pow(20,2);
        Console.WriteLine ("plocha  " + s);
}

}