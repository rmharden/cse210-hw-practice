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

        List<Word> _words = new List<Word>();


        // Split and then loop through each word
        // create a word object and put it into _words

        foreach (string w in text.Split(" "))
        {
            // This is adding the split string as a new object to the list:
            _words.Add(new Word(w));
        }
    }

    // // I do not know if this is how I get this to other areas of the program:
    // public string GetText()
    // {
    //     return _text;
    // }
    // public void SetText(string text)
    // {
    //     _text = text;
    // }



    public void HideRandomWords(int numberToHide)
    {
        // Set the state of a randomly selected group of words to be hidden

        //Step 1:
        // Need to find a set of visible words.
        // This would be where we use the Word class method, IsHidden().

        // Step 2:
        // I need to randomly select the numberToHide that was passed through this method.
        // Can be done with loops, if statements, call the "IsVisible function" (I don't know what Chad Macbeth is referring to here...).

        // Use the Hide function to hide them.

        Random r = new Random();

        Word w2 = new Word(_text);

        w2.GetDisplayText();
    }
    public string GetDisplayText()
    {
        // Display the reference and all the words. 
        // This is going to call GetDisplayText on the Word and if it gets underscores back, it will display underscores.
        // example: string text = "abc" + "def";

        return "";
    }

    public bool IsCompletelyHidden()
    {
        // this is supposed to be false, right? if I have it false, it won't run
        return true;
    }
}