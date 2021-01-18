using System;
using System.Collections;
using System.IO;
using System.Linq;

namespace WordAssociations
{
    public static class WordsReader
    {
        public static ArrayList ReadWords()
        {
            string[] words;
            const string filePath = "Resources/Words.txt";
            if (File.Exists(filePath))
            {
                words = File.ReadAllLines(filePath);
            }
            else
            {
                throw new FileNotFoundException();
            }
            
            return new ArrayList {words.ToArray()};
        }
    }
}