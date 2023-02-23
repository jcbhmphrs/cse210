using System;

class Program
{
    static void Main(string[] args)
    {


        static void EditorOptions(Journal newJournal, string response)
        {
            
            do
            {
                Console.Clear();
                Console.WriteLine("- Write");
                Console.WriteLine("- Display");
                Console.WriteLine("- Save As");
                Console.WriteLine("- Back");
                Console.Write("type an option: ");
                response = Console.ReadLine().ToLower();
                switch (response)
                {
                    case "write":
                        newJournal.AddEntry();
                        break;
                    case "display":
                        newJournal.Show();
                        break;
                    case "save":
                        newJournal.SaveFile();
                        break;
                    default:
                        if (response == "back")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("That is an Invalid Input. Press Enter to Continue...");
                            Console.ReadLine();
                            break;
                        }
                }

            } while (response != "back");
        }


        static void HomeDisplay()
        {
            Journal newJournal = new Journal();
            string response;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Journal Program");
                Console.WriteLine("Please select one of the following choises:");
                Console.WriteLine("- New");
                Console.WriteLine("- Open");
                Console.WriteLine("- Quit");
                Console.Write("type an option: ");
                response = Console.ReadLine().ToLower();

                switch (response)
                {

                    case "new":
                        newJournal.entries.Clear();
                        EditorOptions(newJournal, response);
                        break;


                    case "open":
                        newJournal.LoadFile();
                        EditorOptions(newJournal, response);
                        break;
                    default:
                        if (response == "quit")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("That is an Invalid Input. Press Enter to Continue...");
                            Console.ReadLine();
                            break;
                        }

                }

            } while (response != "quit");

        }
        HomeDisplay();

    }
}