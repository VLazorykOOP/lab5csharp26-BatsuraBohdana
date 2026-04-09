using System;

namespace Task1
{
    public abstract class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

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

        public Worker(string name, int age, string specialty, int experienceYears) : base(name, age)
        {
            Specialty = specialty;
            ExperienceYears = experienceYears;
        }

        public override void Show()
        {
            Console.WriteLine($"[Робітник] Ім'я: {Name}, Вік: {Age}, Спеціальність: {Specialty}, Стаж: {ExperienceYears} років");
        }
    }

    public class Employee : Person
    {
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, int age, string department, decimal salary) : base(name, age)
        {
            Department = department;
            Salary = salary;
        }

        public override void Show()
        {
            Console.WriteLine($"[Службовець] Ім'я: {Name}, Вік: {Age}, Відділ: {Department}, Зарплата: {Salary} грн");
        }
    }

    public class Engineer : Employee
    {
        public string ProjectName { get; set; }

        public Engineer(string name, int age, string department, decimal salary, string projectName) 
            : base(name, age, department, salary)
        {
            ProjectName = projectName;
        }

        public override void Show()
        {
            Console.WriteLine($"[Інженер] Ім'я: {Name}, Вік: {Age}, Відділ: {Department}, Зарплата: {Salary} грн, Проєкт: {ProjectName}");
        }
    }
}