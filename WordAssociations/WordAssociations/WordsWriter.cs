using System;
using System.Collections.Generic;
using System.IO;
using WordAssociations.Properties;

namespace WordAssociations
{
    public static class WordsLoader
    {
        public static void WriteWords(string[] testeeData, List<string> associationsList, string option)
        {
            string filePath = "";
            if (option == "1")
            {
                filePath = "Resources/Records/" + testeeData[2] + " " + testeeData[0][0] + " " + testeeData[1][0] +
                           " " + DateTime.Now.ToString("dd.MM.yyyy hh.mm.ss") +
                           ".txt";
            }
            else
            {
                filePath = "Resources/Records/" + testeeData[2] + " " + testeeData[0][0] + " " + testeeData[1][0] +
                           " " + DateTime.Now.ToString("dd.MM.yyyy hh.mm.ss") +
                           ".txt";
            }

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