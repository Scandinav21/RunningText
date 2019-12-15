using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningString
{
    class Program
    {
        static void Main(string[] args)
        {

            ShowRunningString(new ALitera());

            Console.ReadLine();
        }

        public static void ShowRunningString(ALitera aLitera)
        {
            string[] initialDisplayArrayLine = new string[] { "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*"};

            string[] initialDisplayArrayLines = new string[3] { initialDisplayArrayLine.ToString(), 
                initialDisplayArrayLine.ToString(), initialDisplayArrayLine.ToString() };

            for (int i = 0; i < initialDisplayArrayLines.Length; i++)
            {
                for (int j = 0; j < initialDisplayArrayLine.Length; j++)
                {
                    Console.Write(initialDisplayArrayLine[j]);
                }

                Console.WriteLine();
            }
            
        }

        public struct ALitera
        {
            public static string[] A = new string[] { new string[] { @"/" }.ToString(),
                                                      new string[] { @"/_\" }.ToString(),
                                                      new string[] { @"\" }.ToString()};
        }
    }
}
