using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    [Color(ColorText.Blue)]
    class Text : Shape
    {
        
        public Text(int x1, int y1, string s1) : base(x1, y1, s1)
        {
            hight = x1;
            width = y1;
            symbol = s1;

        }


        


        public override void PrintFigure(Action<string> printSymbol, int x, int y1)
        {
            
            printSymbol(symbol);
            
        }
    }
}
