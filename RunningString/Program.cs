using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningString
{
    class Program
    {
        const string plhldr = "*";
        static void Main(string[] args)
        {

            //ShowRunningString(new ALitera());

            string[][] text = { ConcatArrays(ALitera.A[0], ALitera.R[0], ALitera.I[0], ALitera.N[0], ALitera.A[0]),
                                ConcatArrays(ALitera.A[1], ALitera.R[1], ALitera.I[1], ALitera.N[1], ALitera.A[1]),
                                ConcatArrays(ALitera.A[2], ALitera.R[2], ALitera.I[2], ALitera.N[2], ALitera.A[2]),
                                ConcatArrays(ALitera.A[3], ALitera.R[3], ALitera.I[3], ALitera.N[3], ALitera.A[3]),
                                ConcatArrays(ALitera.A[4], ALitera.R[4], ALitera.I[4], ALitera.N[4], ALitera.A[4])};

            string[][] text2 = {ConcatArrays(ALitera.H[0], ALitera.E[0], ALitera.L[0], ALitera.L[0], ALitera.O[0]),
                                ConcatArrays(ALitera.H[1], ALitera.E[1], ALitera.L[1], ALitera.L[1], ALitera.O[1]),
                                ConcatArrays(ALitera.H[2], ALitera.E[2], ALitera.L[2], ALitera.L[2], ALitera.O[2]),
                                ConcatArrays(ALitera.H[3], ALitera.E[3], ALitera.L[3], ALitera.L[3], ALitera.O[3]),
                                ConcatArrays(ALitera.H[4], ALitera.E[4], ALitera.L[4], ALitera.L[4], ALitera.O[4])};

            ShowRunningString(text2);

            Console.ReadLine();
        }

        public async static void ShowRunningString(string[][] text)
        {
            string[] initialDisplayArrayLine = new string[] { plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr,
            plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr,
            plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr,
            plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr,
            plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr,
            plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr,
            plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr,
            plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr,
            plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr,
            plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr, plhldr};

            string[] initialDisplayArrayLines = new string[5] { initialDisplayArrayLine.ToString(),
                                                                initialDisplayArrayLine.ToString(),
                                                                initialDisplayArrayLine.ToString(),
                                                                initialDisplayArrayLine.ToString(),
                                                                initialDisplayArrayLine.ToString()};

            int initialPosition = initialDisplayArrayLine.Length;
            int textLength = text[0].Length;

            Console.CursorVisible = false;

            //Строка
            for (int i = 0; i < initialDisplayArrayLines.Length; i++)
            {
                //Символ в текущей строке
                for (int j = 0; j < initialDisplayArrayLine.Length; j++)
                {
                    Console.Write(plhldr);
                }

                Console.WriteLine();
            }

            int currPosition = initialPosition;
            while (true)
            {
                if (currPosition == -initialDisplayArrayLine.Length-1)
                    currPosition = initialPosition;

                //Строка
                for (int i = 0; i < initialDisplayArrayLines.Length; i++)
                {
                    //Символ в текущей строке
                    for (int j = 0; j < initialDisplayArrayLine.Length; j++)
                    {
                        if (j == currPosition && currPosition >= 0)
                        {
                            int symbolPos = 0;

                            for (int k = j; k < initialDisplayArrayLine.Length && symbolPos < text[0].Length; k++, symbolPos++, j++)
                            {
                                if (text[i][symbolPos] != plhldr)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.SetCursorPosition(j+1, i);
                                    Console.Write("\b");
                                    Console.Write(plhldr);
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.SetCursorPosition(j + 1, i);
                                    Console.Write("\b");
                                    Console.Write(plhldr);
                                }
                            }
                        }

                        if (currPosition < 0)
                        {
                            int symbolPos = Math.Abs(currPosition);

                            for (int k = j; k < initialDisplayArrayLine.Length && symbolPos < text[0].Length; k++, symbolPos++, j++)
                            {
                                Console.SetCursorPosition(j + 1, i);

                                if (text[i][symbolPos] != plhldr)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write("\b");
                                    Console.Write(plhldr);
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.Write("\b");
                                    Console.Write(plhldr);
                                }
                            }

                            j = initialDisplayArrayLine.Length;
                        }
                    }
                }

                await Task.Delay(1);

                currPosition--;
            }

        }

        public struct ALitera
        {
            public static string[][] A =
                {
                //..*..
                //.*.*.
                //*****
                //*...*
                //*...*
                new string[] { plhldr, plhldr, "0", plhldr, plhldr },
                new string[] { plhldr, "0", plhldr, "0", plhldr },
                new string[] {"0", "0", "0", "0", "0" },
                new string[] {"0", plhldr, plhldr, plhldr, "0" },
                new string[] {"0", plhldr, plhldr, plhldr, "0" }
                };

            public static string[][] R =
                {
                //*.*..
                //*...*
                //*.*..
                //*....
                //*....
                new string[] { "0", plhldr, "0", plhldr, plhldr },
                new string[] { "0", plhldr, plhldr, plhldr, "0" },
                new string[] {"0", plhldr, "0", plhldr, plhldr },
                new string[] {"0", plhldr, plhldr, plhldr, plhldr },
                new string[] {"0", plhldr, plhldr, plhldr, plhldr }
                };

            public static string[][] I =
                {
                /*
                *...*
                *..**
                *.*.*
                **..*
                *...*
                */
                new string[] { "0", plhldr, plhldr, plhldr, "0" },
                new string[] { "0", plhldr, plhldr, "0", "0" },
                new string[] {"0", plhldr, "0", plhldr, "0" },
                new string[] {"0", "0", plhldr, plhldr, "0" },
                new string[] {"0", plhldr, plhldr, plhldr, "0" }
                };

            public static string[][] N =
                {
                 /*
                *...*
                *...*
                *****
                *...*
                *...*
                */
                new string[] { "0", plhldr, plhldr, plhldr, "0" },
                new string[] { "0", plhldr, plhldr, plhldr, "0" },
                new string[] {"0", "0", "0", "0", "0" },
                new string[] {"0", plhldr, plhldr, plhldr, "0" },
                new string[] {"0", plhldr, plhldr, plhldr, "0" }
                };

            public static string[][] H =
                {
                 /*
                *...*
                *...*
                *****
                *...*
                *...*
                */
                new string[] { "0", plhldr, plhldr, plhldr, "0" },
                new string[] { "0", plhldr, plhldr, plhldr, "0" },
                new string[] {"0", "0", "0", "0", "0" },
                new string[] {"0", plhldr, plhldr, plhldr, "0" },
                new string[] {"0", plhldr, plhldr, plhldr, "0" }
                };

            public static string[][] E =
                {
                 /*
                *****
                *....
                *****
                *....
                *****
                */
                new string[] { "0", "0", "0", "0", "0" },
                new string[] { "0", plhldr, plhldr, plhldr, plhldr },
                new string[] { "0", "0", "0", "0", "0" },
                new string[] { "0", plhldr, plhldr, plhldr, plhldr },
                new string[] { "0", "0", "0", "0", "0" }
                };

            public static string[][] L =
                {
                 /*
                *....
                *....
                *....
                *....
                *****
                */
                new string[] { "0", plhldr, plhldr, plhldr, plhldr },
                new string[] { "0", plhldr, plhldr, plhldr, plhldr },
                new string[] {"0", plhldr, plhldr, plhldr, plhldr },
                new string[] {"0", plhldr, plhldr, plhldr, plhldr },
                new string[] {"0", "0", "0", "0", "0" }
                };

            public static string[][] O =
                {
                 /*
                .***.
                *...*
                *...*
                *...*
                .***.
                */
                new string[] { plhldr, "0", "0", "0", plhldr },
                new string[] { "0", plhldr, plhldr, plhldr, "0" },
                new string[] { "0", plhldr, plhldr, plhldr, "0" },
                new string[] { "0", plhldr, plhldr, plhldr, "0" },
                new string[] { plhldr, "0", "0", "0", plhldr }
                };
        }

        public static string[] ConcatArrays(params string[][] literas)
        {
            List<string> text = new List<string>();

            foreach (var param in literas)
            {
                foreach (var arr in param)
                {
                    text.Add(arr);
                }

                text.Add(plhldr);
            }

            return text.ToArray();
        }
    }
}
