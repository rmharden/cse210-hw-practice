public class EmotionsGenerator
{
    List<string> _emotions = new List<string>()
    {
        "awe", "hope", "love", "wonder", "kind", "curious", "vulnerable", "inspired", "compassion", "gratitude", "peace", "forgiven", "grounded","accepted", "contentment","courage", "clarity", "humble", "excited", "confident", "pride", "empowered", "freedom", "joy","possible", "fear", "anxious", "failure", "rage", "grief", "sorrow", "loneliness", "discomfort", "uncertainty", "judgement", "dissapointment", "rejection", "guilt", "frustration", "shame", "overwhelm", "doubt", "empathy"
    };
    public string GetRandomEmotion()
    {
        // This works:
        Random r = new Random();
        //get a random index value and lookup the string in _prompts
        int i = r.Next(_emotions.Count);
        return _emotions[i];
    }
}

// The idea for words to evoke emotions for journal writing came from a book called Dwell by Devon Loftus
