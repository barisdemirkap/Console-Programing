// See https://aka.ms/new-console-template for more information
using System;

namespace console_programing
{

class Program
{
    public static void Main(string[] args)
    {
        
         Console.WriteLine("Hello, World!");
         Console.WriteLine("Write your name");
         string name=Console.ReadLine();
         Console.WriteLine("Write your surname");
         string surname=Console.ReadLine();

         Console.WriteLine("Merhaba "+ name + " "+ surname);
         
         Console.ReadLine();

    }
}

}

