using System;

namespace OOP_lab_1_16_1
{
    public class Program
    {
        public static double Pifagor(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }

        public static double Perymetr(double a, double b)
        {
            return Pifagor(a, b) + a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Довжина першого катета: ");
            
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Довжина першого катета: ");

            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("c = {0}, p = {1}", Pifagor(a, b), Perymetr(a, b));
        }
    }
}
