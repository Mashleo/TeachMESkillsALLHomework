using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class Triangle: Shape
    {
        public Triangle(int x1, int y1, string s1) : base(x1, y1, s1)
        {

        }

        [Color(ColorText.Blue)]
        public override void PrintFigure(Action<string> symbol1,int x, int y1)
        {
            int i = 0;
            int j = 0;
            while (i < width)
            {
                while (j < hight - i && j >= 0)
                {
                    Console.Write(symbol);
                    j++;
                }
                j = 0;
                i++;
                Console.WriteLine();
                for (int k = 0; k < y1; k++)
                {
                    Console.Write(" ");

                }
            }


        }
    }
}
