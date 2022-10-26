using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    public static class ConsoleUsersActionsAndData
    {
        public static string EnterText()
        {
            Console.Write("Enter Text - ");

            string enterText = Console.ReadLine();
            


            return enterText;
        }
        public static string UserChoise()
        {
            Console.Write(" Choise  figure: sqrt or triangl or text - ");

            string enterChoise = Console.ReadLine();
            if (enterChoise != "sqrt" && enterChoise != "triangl" && enterChoise != "text")
            {
                Console.WriteLine("return choise");               
                UserChoise();

            }
            

            return enterChoise;
        }
        public static void SetColorFromAttribute(Shape shape)
        {
            var attributr = shape.GetType().GetCustomAttributes(false);

            foreach (var att in attributr)
            {
                if (att is ColorAttribute col)
                {

                    var color = col.Color;
                    ConsoleUsersActionsAndData.SetColor(color);
                }
            }
        }

        public static string EnterSymbol()
        {
            Console.Write("Enter symbol - ");            
            string enterChar = Console.ReadLine();
            
            return enterChar;
        }
        public static void ClearPrewievString()
        {
            string emptyString = "                                                  ";
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(emptyString);
            }
            Console.SetCursorPosition(0, 0);



        }
        public static  void SetColor(ColorText col)
        {
            

            switch (col)
            {
                case ColorText.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case ColorText.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case ColorText.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

            }



        }
        public static int EnterHight()
        {
            Console.Write("Enter hight - ");            
            int hight = Convert.ToInt32(Console.ReadLine());          

            return hight;
        }
        public static int  EnterWidth()
        {           
            Console.Write("Enter width - ");            
            int width = Convert.ToInt32(Console.ReadLine());            
            return  width;
        }
        public static int EnterX()
        {
            Console.Write("Enter X - ");
            int XOffset = Convert.ToInt32(Console.ReadLine());           
            return XOffset;
        }
        public static int EnterY()
        {
            Console.Write("Enter Y - ");
            int YOffset = Convert.ToInt32(Console.ReadLine());            
            return YOffset;
        }

    }
}
