using System.IO;
public class Journal
{
    public List<Entry> _entriesList = new List<Entry>();
    public Prompt _promptList = new Prompt();
    public void WriteNewEntry(){
        // Create new Entry object.
        Entry _entry = new Entry();

        //Random prompt is shown and saved in _entry object.
        _entry._prompt = _promptList.GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine($"Prompt: {_entry._prompt}");

        // Save answer in _entry object.
        Console.Write("> ");
        _entry._answer = Console.ReadLine();

        // Save DateTime value in _entry object.
        DateTime _dateTimeNow = DateTime.Now;
        _entry._dateTime = _dateTimeNow.ToString();

        // Save optimism rating in _entry object.
        Console.WriteLine("How optimistic are you on a scale of 1 - 10?)");
        Console.Write("> ");
        _entry._optimism = Console.ReadLine();

        // Save all Entry object data.
        _entriesList.Add(_entry);

        Console.WriteLine();
        Console.WriteLine("Your thoughts and feelings have been sacredly saved in the cloud. (sacredly, not secretly. Haha!)");
    }
    public void DisplayJournal(){
        decimal sumOptimism = 0;
        foreach (Entry entry in _entriesList){
            entry.DisplayEntry();
            Console.WriteLine();

            int optimism = int.Parse(entry._optimism);
            sumOptimism += optimism;
        }
        
        // Shows creativity and exceeds core requirements: Calculating and displaying the user's overall optimism
        decimal optimismRate = decimal.Round(sumOptimism/_entriesList.Count, 2);
        Console.WriteLine($"Your overall optimism: {optimismRate}");
        Console.WriteLine();
    }
    public void SaveFile(){
        Console.Write("Give today's recording a name or will you whine about that as well: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName)){
            foreach (Entry entry in _entriesList){
                outputFile.WriteLine($"{entry._dateTime}~{entry._prompt}~{entry._answer}~{entry._optimism}");
            }
        }
    }
    public void LoadFile(){
        
        _entriesList.Clear();

        Console.Write("Give today's recording a name, or will you whine about this as well: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines){
            Entry _entry = new Entry();

            string[] parts = line.Split("~");

            _entry._dateTime = parts[0];
            _entry._prompt = parts[1];
            _entry._answer = parts[2];
            _entry._optimism = parts[3];

            _entriesList.Add(_entry);
        }
    }
}