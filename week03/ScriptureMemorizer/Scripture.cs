public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
   private string _text;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string _text = text;
        string[] words = _text.Split(" ");
        string thisWord = words.ToString();
        List<Word> w = new List<Word>(thisWord); //was working but now it doesn't
        _words.Add(w);        
    }
    public void HideRandomWords(int numberToHide)
    {

        Random r = new Random();

    }
    public void SetRef(Reference reference)
    {
        _reference = reference;
    }
    public Reference GetRef()
    {
        return _reference;
    }
    public string GetDisplayText()
    {
        _reference.GetDisplayText();
        foreach (Word w2 in _words)
        {
            return w2.ToString() + " ";
        }
        return "";
    }
    public bool IsCompletelyHidden()
    {
        // this is supposed to be false, right? if I have it false, it won't run
        return true;
    }
}