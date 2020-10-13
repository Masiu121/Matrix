using System;
using System.Collections.Generic;

namespace Matrix
{
    class Program
    {
        static List<MatrixChain> matrixChains = new List<MatrixChain>();
        static Random rand = new Random();

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.CursorVisible = false;

            while (true)
            {
                while(matrixChains.Count<200) {
                    MatrixChain chain = new MatrixChain(rand.Next(0, Console.WindowWidth), rand.Next(0, Console.WindowHeight-5));
                    matrixChains.Add(chain);
                }

                for (int i = 0; i < matrixChains.Count; i++)
                {
                    matrixChains[i].updateMatrix();
                    if(matrixChains[i].maxY > Console.WindowHeight)
                    {
                        matrixChains[i].unprintMatrix();
                        matrixChains[i].y = 0;
                        
                    }
                    System.Threading.Thread.Sleep(0);
                } 
            }
        }
    }
}
