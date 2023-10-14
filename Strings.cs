using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Param Thakkar");
        Console.WriteLine("Param\nThakkar");
        string Name = "Param Thakkar";
        Console.WriteLine("My name is " + "Param Thakkar\n");
        Console.WriteLine(Name.Length);
        
        Console.WriteLine(Name.ToUpper());
        Console.WriteLine(Name.ToLower());
        Console.WriteLine(Name.Contains("Param"));
        Console.WriteLine(Name[0]);
        Console.WriteLine(Name.IndexOf("Param"));
        Console.WriteLine(Name.Substring(0, 4));
    }
}
