using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"\nCheers to the ones that we got...MEMORIES BRING BACK MEMORIES!");
       
        // Display list of choices.
        int userOption = DisplayMenu();
        
        // Journal Class.
        Journal journal = new Journal();

        // The user keeps choosing until they decide to quit. While-loop.
        bool ind = true;
        while (ind){
            if (userOption == 1){
                // Option 1: new entry
                journal.WriteNewEntry();
                
                Console.WriteLine($"\nDo you want to do something else?");
                userOption = DisplayMenu();
            }
            else if (userOption == 2){
                // Option 2: showing previous recordings
                Console.WriteLine();
                journal.DisplayJournal();

                Console.WriteLine("");
                userOption = DisplayMenu();
            }
            else if (userOption == 3){
                // Option 3: load journal
                journal.LoadFile();

                Console.WriteLine();
                Console.WriteLine("Anything else that you'd need to do?");
                userOption = DisplayMenu();
            }
            else if (userOption == 4){
                // Option 4: save all entries
                journal.SaveFile();             

                Console.WriteLine();
                Console.WriteLine("Anything other sweet memory to save...(not about your ex's)");
                userOption = DisplayMenu();
            }
            else if (userOption == 5){
                // Option 5: exit after saving
                Console.WriteLine("We can close the recordings after you have SAVED them. You must save.");
                Console.Write("Type Yes or No ");
                string close_Option = Console.ReadLine();
                if (close_Option.ToLower() == "yes" || close_Option.ToLower() == "y"){
                    break;
                }
                else {
                    userOption = DisplayMenu();
                }
            }
            else {
                // In case the choice is not in the list:
                Console.Write("Nope! No 'agency' today, you can only choose what's there. Try again ");
                userOption = int.Parse(Console.ReadLine());
            }
        }
        // Option 5: exit 
        
        Console.WriteLine($"\nMemory is the treasure house of the mind wherein the monuments thereof are kept and preserved.\n");
        
    }

    static int DisplayMenu(){
        List<string> menu = new List<string>();
        // Menu Options:
        menu.Add("1. Record some new thoughts and feelings");
        menu.Add("2. See how I've felt before");
        menu.Add("3. Load my journal");
        menu.Add("4. Save my thoughts and feelings");
        menu.Add("5. That's it. I'm done!");

        // Print the menu options.
        foreach (string option in menu){
            Console.WriteLine(option);
        }

        Console.Write("What will you do today? ");
        int userOption = int.Parse(Console.ReadLine());

        return userOption;
    }
}