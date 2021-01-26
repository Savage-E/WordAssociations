﻿using System.Collections.Generic;
using System.IO;

namespace WordAssociations
{
    public static class SaveInstruction
    {
        public static void SaveInst(string[] instruction)
        {
            using (StreamWriter sw = new StreamWriter("Resources/instruction_C.txt", false, System.Text.Encoding.UTF8))
            {
                int length = instruction.Length ;
                for (int i = 0; i < length - 2; i++)
                {
                    sw.WriteLine(instruction[i]);
                }

                sw.WriteLine(instruction[length-1]);
            }
        }
    }
}