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
        _isHidden = true;
    }

    public void Show()
    {
        // I still am not sure where to put this.
        _isHidden = true; // ?
    }

    public bool IsHidden()
    {
        // if statement loop?
        return false;
    }

    public string GetDisplayText()
    {
        // Should return the word if visible or return underscores if hidden. This is an if statement.
        return _text;
    }
}

//https://video.byui.edu/media/t/1_sv3gxgzs
