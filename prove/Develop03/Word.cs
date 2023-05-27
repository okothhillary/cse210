class Word
{
    private string _word;
    private bool _condition;
    
    public Word ()
    {
        _condition = true;
    }
    public Word (string word, bool condition)
    {
        _word = word;
        _condition = condition;
    }
    public Word (string word)
    {
        _word = word;
        _condition = true;
    }
    
    public string Replace(){
        string underscores = "";
        for (int i = 0; i < _word.Length; i++){
            underscores += "_";
        }
        return underscores;
    }
    public void SetWord (string word){
        _word = word;
    }
    public string GetWord(){
        if (_condition == true){
            return _word;
        }
        else {
            string underscores = Replace();
            return underscores;
        }
    }
    public bool GetCondition(){
        return _condition;
    }
    public void ChangeCondition(){
        if (_condition == true){
            _condition = false;
        }
        else {
            _condition = true;
        }
    }
}