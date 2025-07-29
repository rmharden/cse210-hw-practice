public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
   private string _text;
    public Scripture(Reference reference, string text)
    {
        // Initialize reference:
        _reference = reference;

        // Split up the words in texts and store each as a Word object in the list _words:
       
    }
    public void HideRandomWords(int numberToHide)
    {

    }
    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        // this is supposed to be false, right? if I have it false, it won't run
        return true;
    }
}