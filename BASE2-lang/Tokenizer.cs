using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASE2_lang
{
    class Tokenizer
    {
        public Tokenizer(string rawProg)
        {
            rawProgram = rawProg;
        }

        public string getTokenizedString()
        {
            tokenize();
            return tokenizedProgram;
        }

        void tokenize()
        {
            char[] rawProgramChars = rawProgram.ToCharArray();
            char[] tokenizedProgramChars = new char[rawProgramChars.Length / 3];
            int i = 0;
            int j = 0;
            while (i < rawProgramChars.Length - 1)
            {
                if (rawProgramChars[i] == '0')
                {
                    if (rawProgramChars[i + 1] == '0')
                    {
                        if (rawProgramChars[i + 2] == '0')
                        {
                            //000
                            tokenizedProgramChars[j] = '2';
                        }
                        else
                        {
                            //001
                            tokenizedProgramChars[j] = '3';
                        }
                    }
                    else
                    {
                        if (rawProgramChars[i + 2] == '0')
                        {
                            //010
                            tokenizedProgramChars[j] = '4';
                        }
                        else
                        {
                            //011
                            tokenizedProgramChars[j] = '5';
                        }
                    }
                }
                else
                {
                    if (rawProgramChars[i + 1] == '0')
                    {
                        if (rawProgramChars[i + 2] == '0')
                        {
                            //100
                            tokenizedProgramChars[j] = '6';
                        }
                        else
                        {
                            //101
                            tokenizedProgramChars[j] = '7';
                        }
                    }
                    else
                    {
                        if (rawProgramChars[i + 2] == '0')
                        {
                            //110
                            tokenizedProgramChars[j] = '8';
                        }
                        else
                        {
                            //111
                            tokenizedProgramChars[j] = '9';
                        }
                    }
                }
                i = i + 3;
                j++;
            }
            tokenizedProgram = new string(tokenizedProgramChars);
        }

        string rawProgram;
        string tokenizedProgram;
    }
}
