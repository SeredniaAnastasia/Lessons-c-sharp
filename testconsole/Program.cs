// See https://aka.ms/new-console-template for more information


class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine ("What is your name?");
        string name =Console.ReadLine();
        Console.WriteLine("Hello " +name);
        
        Console.WriteLine ("Are you male or female?");
        string state =Console.ReadLine();
        Console.WriteLine("I'm a man " );
       
        Console.WriteLine ("What is your education?");
        string education = Console.ReadLine();
        
        if(education!="designer")
        Console.WriteLine("is a useful profession, and I'm studying to be a designer");
        else 
        Console.WriteLine("Wondeful, I'm aslo a designer");
      
        Console.WriteLine ("Are you happy?");
        string happy =Console.ReadLine();
        Console.WriteLine ("Me too ");
        
        Console.WriteLine ("Do you like studying?");
        string job =Console.ReadLine();
        
        Console.WriteLine ("What is your favorite book?");
        string book =Console.ReadLine();
        Console.WriteLine ("Great, I like Stephen King's books");
        
        Console.WriteLine ("Do you do sports?");
        string sport =Console.ReadLine();
        Console.WriteLine ("I like to run");
        Console.WriteLine ("It was nice to meet you, goodbye");   
    }
}