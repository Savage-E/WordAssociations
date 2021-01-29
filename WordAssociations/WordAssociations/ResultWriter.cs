using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Text;

namespace WordAssociations
{
    public static class ResultWriter
    {
        public static void writeData(string[] testeeData, string[,] associations, string[] settings)
        {
            string filePath = "Resources/Records/" + testeeData[1] + " " + testeeData[0][0] + " " + testeeData[2][0] +
                              " " + DateTime.Now.ToString("dd.MM.yyyy HH.mm.ss") +
                              ".csv";

            //Записываем сначала данные тестируемого.
            using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.UTF8))
            {
                sw.Write(testeeData[1] + " ");
                sw.Write(testeeData[0] + " ");
                sw.Write(testeeData[2] + " ");
                sw.Write(testeeData[3] + " ");
                sw.Write(testeeData[4] + " ");


                sw.WriteLine();
                //Строка с базовыми словами.
                for (int i = 1; i < settings.Length; i++)
                {
                    sw.Write(settings[i] + ";");
                }

                sw.WriteLine();
                //Ассоциации.
                for (int i = 0; i < associations.GetLength(0); i++)
                {
                    for (int j = 0; j < associations.GetLength(1); j++)
                    {
                        sw.Write(associations[i, j] + ";");
                    }

                    sw.WriteLine();
                }
            }
        }
    }
}