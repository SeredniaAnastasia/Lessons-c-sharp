// See https://aka.ms/new-console-template for more information


class TestClass
{
    static void Main(string[] args)
    {
        int n=0, m=0;
        Console.WriteLine("Enter the first two-digit number");
         n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second two-digit number");
         m=Convert.ToInt32(Console.ReadLine());
        int n1=n/10%10;
        int n2=n%10;
        int m1=m/10%10;
        int m2=m%10;
        int nMin, mMax;
        if(n1<n2){
            nMin=n1;
        }else{
           nMin=n2; 
        }
          if(m1>m2){
          mMax=m1;  
        }else{
          mMax=m2;
        }
        
        Console.Write ("suma= "+(nMin+mMax));

    }
}