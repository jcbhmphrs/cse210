using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput;
        do
        {
            Console.Clear();
            Console.Write("""

                         ~ Main Menu ~

                1} Start the Breathing Activity...
                2} Start the Reflecting Activity...
                3} Start the Writing Activity...
                4} Quit...

                Pick a numbered option: 
                """);
            userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.StartActivity();
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.StartActivity();
                    break;
                case 3:
                    WritingActivity writingActivity = new WritingActivity();
                    writingActivity.StartActivity();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("That is not a valid option. Press enter and try again...");
                    Console.Read();
                    break;
            }
        } while (userInput != 4);
    }
}