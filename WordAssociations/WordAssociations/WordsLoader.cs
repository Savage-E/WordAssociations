using System;
using System.Collections.Generic;
using System.IO;
using WordAssociations.Properties;

namespace WordAssociations
{
    public static class WordsLoader
    {
        public static bool LoadWords(string[] testeeData, List<string> associationsList)
        {
            bool result = false;
            
            string filePath="Resources/Recods/Record" +" "+DateTime.Now.ToFileTime() +".txt";
            
            using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
            {
                foreach (string data in testeeData)
                {
                    sw.WriteLine(data);
                }

                foreach (string data in associationsList)
                {
                    sw.WriteLine(data);
                }

                result = true;
            }

            return result;
        }
    }
}