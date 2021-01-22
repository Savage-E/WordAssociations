using System;
using System.Collections.Generic;
using System.IO;
using WordAssociations.Properties;

namespace WordAssociations
{
    public static class WordsLoader
    {
        public static void LoadWords(string[] testeeData, List<string> associationsList)
        {
            string filePath = "Resources/Records/Record" + " " + DateTime.Now.ToShortDateString() + ".txt";

            using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < testeeData.Length - 1; i++)
                {
                    sw.Write(testeeData[i] + " ");
                }

                sw.Write(testeeData[4] + "\n");
                foreach (string data in associationsList)
                {
                    sw.WriteLine(data);
                }
            }
        }
    }
}