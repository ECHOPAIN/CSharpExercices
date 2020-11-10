using System;

namespace CS.Impl._01_Basic
{
    public class Sentence
    {
        public string Reverse(string sentence)
        {
            string[] sentenceWords = sentence.Split(' ');
            Array.Reverse(sentenceWords);
            string newSentence = string.Join(" ", sentenceWords);
            return newSentence;
        }
    }
}
