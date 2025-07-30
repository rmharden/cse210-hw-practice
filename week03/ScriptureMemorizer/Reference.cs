public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        // set _endVerse to "something good".
        _endVerse = _verse;
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        // Two ways to return the string:
        // If statement goes here:
        // If _endVerse exists, this portion needs to handle that.

        while (_endVerse != _verse)
        {
            return _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
        }
        return _book + " " + _chapter + ":" + _verse;
    }
}

// https://video.byui.edu/media/t/1_sv3gxgzs