using ConsoleApp36;
using System;

namespace task1
{
    public delegate void ShowMess(string mes);

    public class ShowMes
    {
        public void Run()
        {
            ShowMess showMes = new ShowMess(ConsoleMes);
            showMes += ConsoleMes;

            showMes("Hello");
            showMes("World!");

        }

        void ConsoleMes(string mes)
        {
            Console.WriteLine($"mes: {mes}");
        }

    }
}
