using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    [Color(ColorText.Red)]
    class Sqrt: Shape
    {
        public Sqrt(int x1, int y1, string s1) : base(x1, y1, s1)
        {
            hight = x1;
            width = y1;
            symbol = s1;

        }

        
        public override void PrintFigure(Action<string>symbol1, int x2,int y2)
        {
            for (int i = 0, k =hight; i < hight; i++, k++)
            {
                for (int j = 0; j < width; j++)
                {
                   symbol1(symbol);
                }               
                Console.SetCursorPosition(x2,k);        
            }

        }
    }
}
