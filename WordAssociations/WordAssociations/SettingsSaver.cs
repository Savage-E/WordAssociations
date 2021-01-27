using System.Collections.Generic;
using System.IO;

namespace WordAssociations
{
    public static class SettingsSaver
    {
        public static void SaveInst(string[] instruction)
        {
            using (StreamWriter sw = new StreamWriter("Resources/Settings.txt", false, System.Text.Encoding.UTF8))
            {
                int length = instruction.Length;
                for (int i = 0; i < length - 1; i++)
                {
                    sw.WriteLine(instruction[i]);
                }

                sw.Write(instruction[length - 1]);
            }
        }
    }
}