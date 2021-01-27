using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordAssociations
{
    public static class SettingsLoader
    {
        public static string[] LoadInstruction(string filePath, string[] instructions)
        {
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