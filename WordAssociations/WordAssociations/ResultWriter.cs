using System;
using System.Data;
using System.IO;
using System.Text;

namespace WordAssociations
{
    public static class ResultWriter
    {
        public static void writeData(string[] testeeData, DataTable dataTable ,string [] instructions)
        {
            string filePath = "";

            filePath = "Resources/Records/" + testeeData[1] + " " + testeeData[0][0] + " " + testeeData[2][0] +
                       " " + DateTime.Now.ToString("dd.MM.yyyy hh.mm.ss") +
                       ".txt";


            using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < testeeData.Length - 1; i++)
                {
                    sw.Write(testeeData[i] + " ");
                }

                sw.Write(testeeData[4] + "\n");

                DataColumnCollection columns = dataTable.Columns;
                foreach (var name in columns)
                {
                    sw.Write(name+" ");
                }
                sw.Write("\n");
                DataRowCollection rows = dataTable.Rows;
                foreach (DataRow data in rows)
                {
                //    sw.WriteLine(data[instructions[]]);
                }
            }
        }
    }
}