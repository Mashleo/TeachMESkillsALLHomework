using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    public class NewsInfoEventArgs : EventArgs
    {       
    }

    public class RunningPrint
    {

        public event EventHandler<NewsInfoEventArgs> Repeat;
        protected virtual void RepeatUI()
        {

            EventHandler<NewsInfoEventArgs> repeat = Repeat; //генерация события
            if (repeat != null) //проверка подписчиков
            {
                SwitchAndCase();
            }

        }


        public static void SwitchAndCase()
        {
            IPrintable printer = new Printer();
            Shape shape;


            


            switch (ConsoleUsersActionsAndData.UserChoise())
            {
                case "sqrt":
                    shape = new Sqrt(ConsoleUsersActionsAndData.EnterHight(), ConsoleUsersActionsAndData.EnterWidth(), ConsoleUsersActionsAndData.EnterSymbol());

                    ConsoleUsersActionsAndData.SetColorFromAttribute(shape);

                    printer.Print(shape, ConsoleUsersActionsAndData.EnterY(), ConsoleUsersActionsAndData.EnterX());

                    Console.ResetColor();
                    ConsoleUsersActionsAndData.ClearPrewievString();
                    
                    SwitchAndCase();
                    break;
                case "triangl":
                    shape = new Triangle(ConsoleUsersActionsAndData.EnterHight(), ConsoleUsersActionsAndData.EnterWidth(), ConsoleUsersActionsAndData.EnterSymbol());
                    ConsoleUsersActionsAndData.SetColorFromAttribute(shape);
                    printer.Print(shape, ConsoleUsersActionsAndData.EnterY(), ConsoleUsersActionsAndData.EnterX());
                    Console.ResetColor();
                    ConsoleUsersActionsAndData.ClearPrewievString();
                    
                    break;
                case "text":
                    shape = new Text(0, 0, ConsoleUsersActionsAndData.EnterText());
                    ConsoleUsersActionsAndData.SetColorFromAttribute(shape);
                    printer.Print(shape, ConsoleUsersActionsAndData.EnterY(), ConsoleUsersActionsAndData.EnterX());
                    Console.ResetColor();
                    ConsoleUsersActionsAndData.ClearPrewievString();
                    SwitchAndCase();
                    break;
            }
        }
        
    }
}
