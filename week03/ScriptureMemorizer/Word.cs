public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        
    }
    public bool IsHidden()
    {
        return false;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}