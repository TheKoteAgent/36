using task1;
using task2;
using task3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    public delegate void ShowMess(string mes);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1: ");
            ShowMes ShowMes = new ShowMes();
            ShowMes.Run();

            Console.WriteLine("\nTask2: ");
            AriOpp arOp = new AriOpp();
            arOp.Run();

            Console.WriteLine("\nTask3:");
            t3 tt3 = new t3();
            tt3.Run();
        }

    }
}
