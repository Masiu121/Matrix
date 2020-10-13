using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class MatrixChain
    {
        Random rand = new Random();

        public int x, y, maxY;
        int[] matrixNumbers = new int[5];

        public MatrixChain(int x, int y)
        {
            this.x = x;
            this.y = y;
            maxY = y + 7;

            for(int i = 0; i < matrixNumbers.Length; i++)
            {
                matrixNumbers[i] = rand.Next(0, 2);
            }
        }

        public void updateMatrix()
        {
            maxY = y + 7;
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            y = y + 1;

            for (int i = 0; i < matrixNumbers.Length; i++)
            {
                matrixNumbers[i] = rand.Next(0, 2);
            }

            printMatrix();
        }

        void printMatrix()
        {
            for (int i = 0; i < matrixNumbers.Length; i++)
            {
                 Console.SetCursorPosition(x, y + i);
                 Console.Write(matrixNumbers[i]);
            }
        }

        public void unprintMatrix()
        {
            for (int i = 0; i < matrixNumbers.Length; i++) {
                Console.SetCursorPosition(x, y + i);
                Console.Write(" ");
            }
        }
    }
}
