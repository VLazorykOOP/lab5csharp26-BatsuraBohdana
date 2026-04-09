using System;

namespace Task3
{
    public abstract class Function
    {
        public abstract double Calculate(double x);
        public abstract void PrintInfo(double x);
    }

    public class Line : Function
    {
        public double A { get; set; }
        public double B { get; set; }

        public Line(double a, double b) { A = a; B = b; }

        public override double Calculate(double x) => A * x + B;

        public override void PrintInfo(double x)
        {
            Console.WriteLine($"[Лінійна функція] y = {A}x + {B} | При x = {x}, y = {Calculate(x)}");
        }
    }

    public class Quadratic : Function
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Quadratic(double a, double b, double c) { A = a; B = b; C = c; }

        public override double Calculate(double x) => A * x * x + B * x + C;

        public override void PrintInfo(double x)
        {
            Console.WriteLine($"[Квадратична функція] y = {A}x^2 + {B}x + {C} | При x = {x}, y = {Calculate(x)}");
        }
    }

    public class Hyperbola : Function
    {
        public double K { get; set; }

        public Hyperbola(double k) { K = k; }

        public override double Calculate(double x) => x == 0 ? double.NaN : K / x;

        public override void PrintInfo(double x)
        {
            if (x == 0) Console.WriteLine($"[Гіпербола] y = {K}/x | При x = {x} функція не визначена (ділення на нуль)!");
            else Console.WriteLine($"[Гіпербола] y = {K}/x | При x = {x}, y = {Calculate(x)}");
        }
    }
}