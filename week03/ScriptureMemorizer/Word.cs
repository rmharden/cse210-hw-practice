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

    }
    public void Show()
    {

    }
    public bool IsHidden()
    {
        return true;
    }
    public string GetDisplayText()
    {
        if (IsHidden() == false)
        {
            return _text;
        }
        else
        {
            for (int index = 0; index < _text.Length; index++)
            {
                Console.Write("_");
            };
        }
        return "";
    }
}

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