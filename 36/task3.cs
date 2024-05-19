using System;

namespace task3
{
    public class t3
    {
        public void Run()
        {
            Predicate<int> Parr = par;
            Predicate<int> NeParr = nepar;
            Predicate<int> Simpp = simp;
            Predicate<int> Fiboo = Fibo;


            int num = 5;
            Console.WriteLine($"{num} par: {Parr(num)}");
            Console.WriteLine($"{num} nepar: {NeParr(num)}");
            Console.WriteLine($"{num} simp: {Simpp(num)}");
            Console.WriteLine($"{num} Fibo: {Fiboo(num)}");
        }

        bool par(int num)
        {
            return num % 2 == 0;
        }

        bool nepar(int num)
        {
            return num % 2 != 0;
        }

        bool simp(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        bool Fibo(int num)
        {
            if (num < 0) return false;
            int a = 0;
            int b = 1;
            while (b < num)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return num == b || num == 0;
        }
    }
}
