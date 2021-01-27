using System.IO;

namespace WordAssociations
{
    public class InstructionSaver
    {
        public static void saveInst(string[] instruction)
        {
            using (StreamWriter sw = new StreamWriter("Resources/instruction.txt", false, System.Text.Encoding.UTF8))
            {
                foreach (var i in instruction)
                {
                    sw.WriteLine(i);
                }
            }
        }
    }
}