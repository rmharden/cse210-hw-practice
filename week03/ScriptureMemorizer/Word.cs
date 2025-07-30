public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        // changing the state:
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false; // not sure about this - I don't know where it goes in the Scripture class ... Chad Macbeth said we call all the classes and methods from the Scripture class and then the main Program calls the scripture methods... So where does the Show() method go?
    }
    public bool IsHidden()
    {
        // return false; // is this supposed to be different?
        return _isHidden;
    }
    public string GetDisplayText()
    {
        // This one is going to determine what to display, not the Scripture method GetDisplayText().
        // This is an if statement:

        // Should return the word if visible or return underscores, like this: _____ if hidden.

        if (_isHidden)
        {
            return new string('_', _text.Length); // When writing this, VS Code said that I couldn't put "_" because it meant something different than '_'.
        }
        else
        {
            return _text;
        }
    }
}
// https://video.byui.edu/media/t/1_sv3gxgzs
// https://learn.microsoft.com/en-us/dotnet/api/system.string.-ctor?view=net-9.0#system-string-ctor(system-char*-system-int32-system-int32)




        // Random randomWord = new Random();
        // int i = randomWord.Next(_words.Count);

        //Word useThisWord = _words[i];
        // string aHiddenWord = useThisWord.ToString();

            // //int lettersToHide = aHiddenWord.Length;
            // // hidding letters in a word:
            // for (int i2 = 0; i2 < aHiddenWord.Length; i2++)
            // {
            //     Console.Write("_");
            // }
            // Console.WriteLine();

            // This was from Chad Macbeth's video on BYU-I Videos:
            // https://video.byui.edu/media/t/1_86gjzj20

        // public string GetDisplayText()
        // {
        // if (IsHidden() == false)
        // {
        //     return _text;
        // }
        // else
        // {
        //     for (int index = 0; index < _text.Length; index++)
        //     {
        //         Console.Write("_");
        //     };
        // }
        // return "";
        // }