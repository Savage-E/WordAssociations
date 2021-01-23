using System;
using System.Collections.Generic;
using System.IO;
using WordAssociations.Properties;

namespace WordAssociations
{
    public static class WordsLoader
    {
        public static void LoadWords(string[] testeeData, List<string> associationsList, string option)
        {
            string strOption = option == "1" ? "chain" : "single";
            string filePath = "Resources/Records/Record_" + strOption + " " + DateTime.Now.ToFileTimeUtc() + ".txt";

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