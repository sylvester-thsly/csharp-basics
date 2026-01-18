using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("My name is Sylvester");
        Console.WriteLine("I am learning C#!");
        
        // Variables
        int age = 25;
        string name = "Sylvester";
        double height = 1.75;
        bool isStudent = true;
        char grade = 'A';
        
        // Print them
        Console.WriteLine($"Myageis " +  age);

        Console.WriteLine ($"name is " + name);

        Console.WriteLine ($"Myhightis " + height);

        Console.WriteLine ($"am a student " + isStudent);

        Console.WriteLine ($"grade " + grade);
        
    
    }
} 
