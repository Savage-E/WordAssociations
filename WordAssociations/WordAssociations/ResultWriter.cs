using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Text;

namespace WordAssociations
{
    public static class ResultWriter
    {
        public static void writeData(string[] testeeData, string[,] associations, string[] instructions)
        {
            string filePath = "Resources/Records/" + testeeData[1] + " " + testeeData[0][0] + " " + testeeData[2][0] +
                              " " + DateTime.Now.ToString("dd.MM.yyyy HH.mm.ss") +
                              ".txt";


            using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.UTF8))
            {
                for (int i = 0; i < testeeData.Length - 1; i++)
                {
                    sw.Write(testeeData[i] + " ");
                }
                sw.WriteLine();
                for (int i = 0; i < associations.GetLength(0); i++)
                {
                    for (int j = 0; j < associations.GetLength(1); j++)
                    {
                        sw.Write(associations[i,j]+" ");
                    }
                    sw.WriteLine();
                }
            }
        }
    }
}