using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BASE2_lang
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                string fileProgram = File.ReadAllText(args[0]);
                Interpreter interpreter = new Interpreter(fileProgram);
                interpreter.runProgram();
            }
            //Interpreter interpreter = new Interpreter("000010010010010010010010010010110001010010010010010010010010000011111001100");
            //interpreter.runProgram();

            Console.ReadLine();
        }
    }
}
