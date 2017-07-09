using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
			var sentence = "This is going to be a really really really really long sentence.";
            var summary = SummarizeText(sentence, 25);
            Console.WriteLine(summary);
        }

        static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                return text;
            
			var words = text.Split(' ');
			var totalCharacters = 0;
			var summaryWords = new List<string>();

			foreach (var word in words)
			{
				summaryWords.Add(word);


				totalCharacters += word.Length + 1;
				if (totalCharacters > maxLength)
					break;
			}

			return String.Join(" ", summaryWords) + "...";
        }
    }
}