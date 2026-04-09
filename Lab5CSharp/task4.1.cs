using System;

namespace Lab4CSharp
{
    public sealed partial class Triangle
    {
        private int a, b, c;
        private int color;

        public Triangle(int sideA, int sideB, int sideC, int triangleColor)
        {
            a = sideA; 
            b = sideB; 
            c = sideC;
            color = triangleColor;
        }
    }

    // Клас для запуску 4-го завдання, який шукав Program.cs
    public static class Task1
    {
        public static void Execute()
        {
            Console.WriteLine("--- Завдання 1 (Лаб 4): Перевантаження Triangle ---");
            Triangle t = new Triangle(3, 4, 5, 1);
            Console.WriteLine($"Початковий: {(string)t}");
            
            t++; Console.WriteLine($"Після ++: {(string)t}");
            t = t * 2; Console.WriteLine($"Після * 2: {(string)t}");
            
            Console.WriteLine($"Сторона b через індексатор [1]: {t[1]}");
            
            if (t) Console.WriteLine("Трикутник існує.");
        }
    }
}