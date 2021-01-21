using System;
using System.Collections.Generic;
using System.IO;
using WordAssociations.Properties;

namespace WordAssociations
{
    public static class WordsLoader
    {
        public static void LoadWords(string[] testeeData, List<string> associationsList, string[] wordsList)
        {
            string filePath = "Resources/Records/Record" + " " + DateTime.Now.ToFileTime() + ".txt";
            int count = 0;
            using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
            {
                foreach (string data in testeeData)
                {
                    sw.WriteLine(data);
                }

                foreach (string data in associationsList)
                {
                    sw.WriteLine(count + "." + wordsList[count++]);
                    sw.WriteLine(data);
                }
            }
        }
    }
}