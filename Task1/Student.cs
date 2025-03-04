using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Student
    {
        public string Name;
        public string Surname;
        public string Group;


        // Конструктор для создания объекта
        public Student(string name, string surname, string group)
        {
            Name = name;
            Surname = surname;
            Group = group;
        
        }


        public void Print()
        {
            Console.WriteLine($"Имя: {Name}  Фамилия: {Surname} Группа: {Group}");
        }
    }

}
