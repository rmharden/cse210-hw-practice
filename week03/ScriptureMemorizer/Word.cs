// Restarting the code to learn more.

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
        // I still am not sure where to put this.
    }

    public bool IsHidden()
    {
        // if statement loop?
        return false;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}