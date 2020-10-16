using SnakeConsoleApp.UserServices;
using System;

namespace SnakeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UIService uIService = new UIService();
            uIService.GetMenu();

            while(true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                uIService.GetCommand(key.Key);
            }
        }
    }
}
