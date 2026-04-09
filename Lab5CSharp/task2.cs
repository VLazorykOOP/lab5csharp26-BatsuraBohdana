using System;

namespace Task2
{
    public abstract class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        protected Person()
        {
            Name = "Невідомо"; Age = 0;
            Console.WriteLine("Викликано конструктор за замовчуванням базового класу Person");
        }

        protected Person(string name)
        {
            Name = name; Age = 0;
            Console.WriteLine($"Викликано конструктор Person з 1 параметром (Name: {name})");
        }

        protected Person(string name, int age)
        {
            Name = name; Age = age;
            Console.WriteLine($"Викликано конструктор Person з 2 параметрами (Name: {name}, Age: {age})");
        }

        ~Person() { Console.WriteLine($"Викликано деструктор для Person: {Name}"); }

        public abstract void Show();

        public int CompareTo(Person other)
        {
            if (other == null) return 1;
            return string.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }
    }

    public class Worker : Person
    {
        public string Specialty { get; set; }
        public int ExperienceYears { get; set; }

        public Worker() : base() { Specialty = "Різноробочий"; ExperienceYears = 0; Console.WriteLine("Викликано конструктор за замовчуванням Worker"); }
        public Worker(string name, int age) : base(name, age) { Specialty = "Різноробочий"; ExperienceYears = 0; Console.WriteLine("Викликано конструктор Worker (часткові параметри)"); }
        public Worker(string name, int age, string specialty, int experienceYears) : base(name, age) { Specialty = specialty; ExperienceYears = experienceYears; Console.WriteLine("Викликано конструктор Worker (усі параметри)"); }

        ~Worker() { Console.WriteLine($"Викликано деструктор для Worker: {Name}"); }

        public override void Show() { Console.WriteLine($"[Робітник] Ім'я: {Name}, Вік: {Age}, Спеціальність: {Specialty}"); }
    }

    public class Employee : Person
    {
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Employee() : base() { Department = "Загальний"; Salary = 0m; Console.WriteLine("Викликано конструктор за замовчуванням Employee"); }
        public Employee(string name, int age) : base(name, age) { Department = "Загальний"; Salary = 0m; Console.WriteLine("Викликано конструктор Employee (часткові параметри)"); }
        public Employee(string name, int age, string department, decimal salary) : base(name, age) { Department = department; Salary = salary; Console.WriteLine("Викликано конструктор Employee (усі параметри)"); }

        ~Employee() { Console.WriteLine($"Викликано деструктор для Employee: {Name}"); }

        public override void Show() { Console.WriteLine($"[Службовець] Ім'я: {Name}, Вік: {Age}, Відділ: {Department}"); }
    }

    public class Engineer : Employee
    {
        public string ProjectName { get; set; }

        public Engineer() : base() { ProjectName = "Без проєкту"; Console.WriteLine("Викликано конструктор за замовчуванням Engineer"); }
        public Engineer(string name, int age) : base(name, age) { ProjectName = "Без проєкту"; Console.WriteLine("Викликано конструктор Engineer (часткові параметри)"); }
        public Engineer(string name, int age, string department, decimal salary, string projectName) : base(name, age, department, salary) { ProjectName = projectName; Console.WriteLine("Викликано конструктор Engineer (усі параметри)"); }

        ~Engineer() { Console.WriteLine($"Викликано деструктор для Engineer: {Name}"); }

        public override void Show() { Console.WriteLine($"[Інженер] Ім'я: {Name}, Вік: {Age}, Проєкт: {ProjectName}"); }
    }
}