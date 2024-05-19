using System;

namespace task2
{

    public delegate double AriOp(double a, double b);

    public class AriOpp
    {
        public void Run()
        {
            AriOp plus = Plus;
            AriOp minu = Minu;
            AriOp mno = Mno;


            Console.WriteLine($"plus: {plus(1, 2)}");
            Console.WriteLine($"minu: {minu(4, 3)}");
            Console.WriteLine($"mno: {mno(5, 6)}");
        }

        double Plus(double a, double b)
        {
            return a + b;
        }

        double Minu(double a, double b)
        {
            return a - b;
        }

        double Mno(double a, double b)
        {
            return a * b;
        }
    }
}
