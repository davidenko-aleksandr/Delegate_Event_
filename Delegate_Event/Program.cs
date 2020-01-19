using System;

namespace Delegate_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(100);
            //account.MethodToDelegate(Display);
            //account.MethodToDelegate(ColorDisplay);
            account.Adding += Display;
            account.Added += ColorDisplay;
            account.Put(50);
            account.Withdraw(80);
            //account.UnmethodToDelegate(ColorDisplay);
            account.Withdraw(90);
        }

        static void Display(string message)
        {
            Console.WriteLine(message);
        }
        static void ColorDisplay(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
