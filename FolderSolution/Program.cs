using System;

namespace FolderSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var ops = new string[] {"d1/","d2/","../","d21/","./"};
            
            Console.WriteLine(Solution(ops));
        }

        static byte Solution(string[] ops)
        {
            // для экономии памяти
            // т.к ops.length <= 103
            byte begin = 0;

            for(byte i = 0; i < ops.Length; i++)
            {
                if (ops[i] == "./")
                {
                    continue;
                }

                if (ops[i] == "../" && begin > 0)
                {
                    begin--;
                }
                else
                {
                    begin++;
                }
            }
            
            return begin;
        }
    }
}