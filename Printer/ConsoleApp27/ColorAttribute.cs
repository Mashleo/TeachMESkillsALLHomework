using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    public class ColorAttribute : Attribute
    {
        public ColorAttribute( ColorText color)
        {
            Color = color;

        }
        public ColorText Color { get; set; }
    }
}
