class Scripture 
{
    private Reference _reference;
    private List<Word> _scripture;

    
    public Scripture ()
    {

    }
    public Scripture (Reference reference)
    {
        _reference = reference;
    }
    public Scripture (Reference reference, List<Word> scripture)
    {
        _reference = reference;
        _scripture = scripture;
    }

     
    public void SetScripture (List<Word> scripture, Reference reference){
        _scripture = scripture;
        _reference = reference;
    }   
    public void SetScriptureText (List<Word> scripture){
        _scripture = scripture;
    }
    public void SetScriptureReference (Reference reference){
        _reference = reference;
    }
    public string GetScripture (){
        string text = "";
        foreach (Word word in _scripture){
            text += word.GetWord();
            text += " ";
        }
        text = text.Trim();
        return $"{_reference.GetReference()} '{text}'";
    }
    public string GetReference(){
        return _reference.GetReference();
    }
    public bool Memorize (){
        // List of integers that save  indices of words in concealed texts.
        List<int> nonConcealed = new List<int>();

        // Saving indices of displayed words.
        for (int i = 0; i < _scripture.Count ; i++){
            if (_scripture[i].GetCondition()){
                nonConcealed.Add (i);
            }
        }

        // For words being displayed change status with Conceal method.
        if (nonConcealed.Count > 3){
            // Conceal 3 random words.
            Conceal(3, nonConcealed);
            return false;
        }
        else if (nonConcealed.Count > 0){
            // Conceal remaining words.
            Conceal(nonConcealed.Count, nonConcealed);
            return false;
        }
        // Condition returned is true if all words are concealed
        else{
            return true;
        }
    }
    private void Conceal (int times, List<int> nonConcealed){
        Random random = new Random();

        // Random selection of a word that is not concealed and the condition is switched
        for (int i = 0; i < times; i++){
            int index = random.Next(0, nonConcealed.Count);

            // Removing index from list
            int remove = nonConcealed[index];
            nonConcealed.RemoveAt(index);

            // conceal selected word.
            _scripture[remove].ChangeCondition();
        }
    }
  
}