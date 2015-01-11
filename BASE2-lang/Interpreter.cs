using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASE2_lang
{
    class Interpreter
    {
        public Interpreter(string prog)
        {
            memory = new char[30000];

            Tokenizer tokenizer = new Tokenizer(prog);
            program = tokenizer.getTokenizedString().ToCharArray();

            pointer = 0;
            programIndex = 0;
        }

        void valueIncrease()
        {
            memory[pointer]++;
        }

        void valueDecrease()
        {
            memory[pointer]--;
        }

        void pointerIncrease()
        {
            pointer++;
        }

        void pointerDecrease()
        {
            pointer--;
        }

        void write()
        {
            Console.Write(memory[pointer]);
        }

        void read()
        {
            memory[pointer] = (char) Console.Read();
        }

        void bracketOpen()
        {
            int numberOfBrackets = 1;
            if (memory[pointer] == 0)
            {
                do
                {
                    programIndex++;
                    if (program[programIndex] == '8')
                    {
                        numberOfBrackets++;
                    }
                    else if (program[programIndex] == '9')
                    {
                        numberOfBrackets--;
                    }
                } while (numberOfBrackets != 0);
            }
        }

        void bracketClose()
        {
            int numberOfBrackets = 0;
            do
            {
                if (program[programIndex] == '8')
                {
                    numberOfBrackets++;
                }
                else if (program[programIndex] == '9')
                {
                    numberOfBrackets--;
                }
                programIndex--;
            } while (numberOfBrackets != 0);
        }

        public void runProgram()
        {
            while (programIndex < program.Length)
            {
                switch (program[programIndex])
                {
                    case '2':
                        pointerIncrease();
                        break;
                    case '3':
                        pointerDecrease();
                        break;
                    case '4':
                        valueIncrease();
                        break;
                    case '5':
                        valueDecrease();
                        break;
                    case '6':
                        write();
                        break;
                    case '7':
                        read();
                        break;
                    case '8':
                        bracketOpen();
                        break;
                    case '9':
                        bracketClose();
                        break;
                }
                programIndex++;
            }
        }

        char[] memory;
        char[] program;
        int pointer;
        int programIndex;
    }
}
