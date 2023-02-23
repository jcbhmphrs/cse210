using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        int x = 5;
        int y = 7;
        int z = x + y;
        Random randomGenerator = new Random();
        int randNumber = randomGenerator.Next(6,z);
        Console.WriteLine(randNumber);
        
    }
}