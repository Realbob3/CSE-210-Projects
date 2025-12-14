using System;

namespace Develop03
{
    public class Scripture
    {
        private ScriptureReference _reference;
        private List<Word> _words;
        public Scripture(ScriptureReference reference, string text)
        {
            _reference = reference;

            string[] textWords = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            _words = new List<Word>();
            foreach (string wordText in textWords)
            {
                _words.Add(new Word(wordText));
            }
        }

        public void HideRandomWords(int count)
        {
            List<Word> unhiddenWords = _words.Where(w => !w.IsHidden()).ToList();
            
            if (unhiddenWords.Count == 0)
            {
                return;
            }

            Random random = new Random();

            for (int i = 0; i < count && unhiddenWords.Count > 0; i++)
            {
                int index = random.Next(unhiddenWords.Count);
                
                unhiddenWords[index].Hide();

                unhiddenWords.RemoveAt(index);
            }
        }

        public string GetDisplayText()
        {
            string displayText = _reference.GetDisplayText() + " ";

            foreach (Word word in _words)
            {
                displayText += word.GetDisplayText() + " ";
            }

            return displayText.Trim();
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(w => w.IsHidden());
            
        }
    }
}