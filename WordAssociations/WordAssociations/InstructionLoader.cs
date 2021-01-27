﻿using System.IO;

namespace WordAssociations
{
    public class InstructionLoader
    {
        public static string[] LoadInst(string filePath)
        {
            string[] instructions;
            if (File.Exists(filePath))
            {
                instructions = File.ReadAllLines(filePath);
               
            }
            else
            {
                throw new FileNotFoundException();
            }

            return instructions;
        }
            
    }
}