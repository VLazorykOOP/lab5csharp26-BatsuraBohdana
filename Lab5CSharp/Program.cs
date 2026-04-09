using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear(); 
                Console.WriteLine("================ ГОЛОВНЕ МЕНЮ ================");
                Console.WriteLine("1. Завдання 1 (Базова ієрархія та сортування)");
                Console.WriteLine("2. Завдання 2 (Демонстрація конструкторів/деструкторів)");
                Console.WriteLine("3. Завдання 3 (Математичні функції)");
                Console.WriteLine("4. Завдання 4 (Клас Triangle)");
                Console.WriteLine("0. Вийти з програми");
                Console.WriteLine("==============================================");
                Console.Write("Введіть номер завдання (1-4) та натисніть Enter: ");

                string choice = Console.ReadLine();

                Console.Clear(); 

                switch (choice)
                {
                    case "1":
                        RunTask1();
                        break;
                    case "2":
                        RunTask2();
                        break;
                    case "3":
                        RunTask3();
                        break;
                    case "4":
                        RunTask4();
                        break;
                    case "0":
                        Console.WriteLine("Завершення роботи. До побачення!");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Помилка: Невірний вибір. Будь ласка, введіть цифру від 0 до 4.");
                        break;
                }

                if (isRunning)
                {
                    Console.WriteLine("\n----------------------------------------------");
                    Console.WriteLine("Натисніть будь-яку клавішу, щоб повернутися до меню...");
                    Console.ReadKey();
                }
            }
        }
        
        static void RunTask1()
        {
            Console.WriteLine("========== ЗАВДАННЯ 1 ==========\n");
            
            Task1.Person[] people = new Task1.Person[]
            {
                new Task1.Worker("Олег", 30, "Зварювальник", 5),
                new Task1.Employee("Марія", 25, "Бухгалтерія", 15000),
                new Task1.Engineer("Іван", 40, "Розробка", 45000, "Проєкт А"),
                new Task1.Worker("Андрій", 22, "Вантажник", 1) 
            };

            Console.WriteLine("--- Масив до сортування ---");
            foreach (var p in people) { p.Show(); }

            Array.Sort(people);

            Console.WriteLine("\n--- Масив після сортування за іменем ---");
            foreach (var p in people) { p.Show(); }
        }
        
        static void RunTask2()
        {
            Console.WriteLine("========== ЗАВДАННЯ 2 ==========\n");
            Console.WriteLine("--- Створення об'єктів (виклик конструкторів) ---");
            
            // Використовуємо класи з Task2
            Task2.Person[] people = new Task2.Person[]
            {
                new Task2.Worker("Олег", 30, "Зварювальник", 5),
                new Task2.Employee("Марія", 25), 
                new Task2.Engineer()           
            };

            Console.WriteLine("\n--- Виведення даних ---");
            foreach (var p in people) { p.Show(); }

            Console.WriteLine("\n[Система] Очікуємо виклик деструкторів...");
            people = null; 
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        
        static void RunTask3()
        {
            Console.WriteLine("========== ЗАВДАННЯ 3 ==========\n");
            Task3.Function[] functions = new Task3.Function[]
            {
                new Task3.Line(2, 3),          
                new Task3.Quadratic(1, -2, 1), 
                new Task3.Hyperbola(5)         
            };

            Console.WriteLine("--- Обчислення значень у точці x = 2.5 ---");
            foreach (var f in functions) { f.PrintInfo(2.5); }

            Console.WriteLine("\n--- Обчислення значень у точці x = 0 ---");
            foreach (var f in functions) { f.PrintInfo(0); }
        }
        
        static void RunTask4()
        {
            Console.WriteLine("========== ЗАВДАННЯ 4 ==========\n");
            Lab4CSharp.Task1.Execute(); 
        }
    }
}