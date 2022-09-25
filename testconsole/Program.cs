// See https://aka.ms/new-console-template for more information


class TestClass
{
    static void Main(string[] args)
    {
         double y=0, x=0;
        Console.WriteLine("Input x  ");
        x = Convert.ToInt32(Console.ReadLine());
        if(x<=0){
            y=0;
        }else if(x>0 && x<=1){
            y=x*x-x;
        }else{
            y=x*x-Math.Sin(Math.PI*Math.Pow(x,2));
        }
        Console.WriteLine("y= " + y);
    }
}