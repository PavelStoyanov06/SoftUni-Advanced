using System;
using System.Collections.Generic;
using System.Text;

namespace _9SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();

            Stack<string[]> stack = new Stack<string[]>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ');
                int cmd = int.Parse(cmdArgs[0]);

                if(cmd == 1)
                {
                    string str = cmdArgs[1];
                    text.Append(str);
                    stack.Push(new string[] { cmd.ToString(), str });
                }
                else if(cmd == 2)
                {
                    int count = int.Parse(cmdArgs[1]);
                    string newText = text.ToString().Substring(text.Length - count, count);
                    text.Remove(text.Length - count, count);
                    stack.Push(new string[] { cmd.ToString(), newText });
                }
                else if(cmd == 3)
                {
                    int index = int.Parse(cmdArgs[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if(cmd == 4)
                {
                    string[] tempArgs = stack.Pop();
                    int tempCmd = int.Parse(tempArgs[0]);
                    
                    if(tempCmd == 1)
                    {
                        string oldTxt = tempArgs[1];
                        text.Remove(text.Length - oldTxt.Length, oldTxt.Length);
                    }
                    else if (tempCmd == 2)
                    {
                        string txt = tempArgs[1];
                        text.Append(txt);
                    }
                }
            }
        }
    }
}
