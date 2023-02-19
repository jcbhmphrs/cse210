using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> inputs = new List<int>();
        int userInput = 1;
        int sum = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (userInput != 0)
        {
            Console.Write("Number: ");
            userInput = int.Parse(Console.ReadLine());
            inputs.Add(userInput);
        }
        int largest = inputs[0];
        for (int i = 0; i < inputs.Count; i++)
        {
        if (inputs[i] > largest)
        {
            largest = inputs[i];
        }    
        sum += inputs[i];
        }
        Console.WriteLine($"The sum is {sum}");
        float average = ((float)sum / (inputs.Count - 1));
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest is {largest}");
    }
}