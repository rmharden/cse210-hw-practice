public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    //private string _text; VS Code said I wasn't using this.
    public Scripture(Reference reference, string text)
    {
        // Initialize reference:
        _reference = reference;

        _words = new List<Word>(); // I had to change this. It gave me a null exception when it was List<Word> _words = new List<word>();

        // Split up the words in texts and store each as a Word object in the list _words:

        // Split and then loop through each word
        // create a word object and put it into _words

        foreach (string w in text.Split(" "))
        {
            // This is adding the split string as a new object to the list:
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // Set the state of a randomly selected group of words to be hidden

        Random r = new Random();

        //Step 1:
        // Need to find a set of visible words.
        // This would be where we use the Word class method, IsHidden().

        List<int> _wordsNotHidden = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden()) // the ! negates the boolean.
            {
                _wordsNotHidden.Add(i);
            }
        }
        if (_wordsNotHidden.Count == 0)
        {
            Console.Clear();
            Console.Write($"{_words} ");
        }

        // Step 2:
        // I need to randomly select the numberToHide that was passed through this method.
        // Can be done with loops, if statements, call the "IsVisible function" (I don't know what Chad Macbeth is referring to here...).

        numberToHide = Math.Min(numberToHide, _wordsNotHidden.Count);

        for (int i = 0; i < numberToHide; i++)
        {
            int randomWordIndex = r.Next(_wordsNotHidden.Count);
            // Use the Hide function to hide them.
            int _wordsNotHiddenIndex = _wordsNotHidden[randomWordIndex];

            _words[_wordsNotHiddenIndex].Hide();
            _wordsNotHidden.RemoveAt(randomWordIndex);
        }
    }
    public string GetDisplayText()
    {
        // Display the reference and all the words. 
        // This is going to call GetDisplayText on the Word and if it gets underscores back, it will display underscores.
        // example: string text = "abc" + "def";

        string newText = _reference.GetDisplayText() + "\n\n";
        foreach (Word word in _words)
        {
            newText += word.GetDisplayText() + " ";
        }
        return newText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden()) return false;
        }
        return true;
    }
}

// https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.removeat?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/api/system.string.trim?view=net-9.0
// https://learn.microsoft.com/en-us/shows/lets-learn-dotnet/lets-learn-dotnet-csharp
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#compound-assignment