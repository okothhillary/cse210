using System;
class Program
{
    static void Main(string[] args)
    {
        
        List<Scripture> scriptureList = new List<Scripture>();

        string userInput = "";

        //  STRETCH CHALLENGE
            // Load a list of scriptures from a file, display them as a list
            // and let the user choose one to memorise.
            
        // Clear console. 
        Console.Clear();
        LoadFile(scriptureList);

        // Choose a scripture from the list.
        Console.WriteLine("Pick one that you'd love to memorise: ");
        DisplayReferences(scriptureList);
        int option = int.Parse(Console.ReadLine());

        Console.Clear();
        
        while (userInput.ToLower() != "done"){
            // Clear the console.
            Console.Clear();
            
            // User gets more words concealed if they type 'CONCEAL'. Programme terminates when user types 'DONE'.
            Console.WriteLine(scriptureList[option - 1].GetScripture());
            Console.WriteLine();
            Console.WriteLine("Type 'Conceal' to conceal more words or type 'DONE' to finish:");
            userInput = Console.ReadLine();

            // Confirm that the whole scripture text is concealed before terminating the programme.
            bool terminate = scriptureList[option - 1].Memorize();
            // If true, terminate programme.
            if (terminate == true){
                break;
            }
        }
    }
    static void DisplayReferences(List<Scripture> scriptureList){
        int i = 1;
        foreach (Scripture scripture in scriptureList){
            Console.WriteLine($"{i}> {scripture.GetReference()}");
            i++;
        }
    }
    static void LoadFile(List<Scripture> scriptureList)
    {
    string fileName = "scriptureFile.txt";
    string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            if (parts.Length >= 5)
            {
                Reference reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));

                List<Word> text = new List<Word>();

                string[] words = parts[4].Split(" ");
                foreach (string word in words)
                {
                    Word newWord = new Word(word);
                    text.Add(newWord);
                }

                Scripture scripture = new Scripture(reference, text);
                scriptureList.Add(scripture);
            }
        }
    }
}    
