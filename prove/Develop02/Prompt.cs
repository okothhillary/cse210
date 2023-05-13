public class Prompt
{
    public List<string> _promptList = new List<string>();

    public void FillPromptList(){
        _promptList.Clear();
        _promptList.Add("Hmm...this guy today was just mind-blowing: ");
        _promptList.Add("This event today made me feel like I'm in Heaven: ");
        _promptList.Add("This made me feel as though I'm Jared's brother! 'Seeing The Lord's finger: '");
        _promptList.Add("Something that really evoked feelings inside me: ");
        _promptList.Add("Yeah, I really screwed up that one thing. Needs some introspection and redoing: ");
        _promptList.Add("Guess, what, I'm actually greatful for something today and it's: ");
        _promptList.Add("I didn't just whine through out the day. I helped this guy: ");
    }
    
    public string GetRandomPrompt(){
        FillPromptList();

        Random random = new Random();
        int randomPromptNumber = random.Next(0, _promptList.Count);

        return _promptList[randomPromptNumber];
    }
}