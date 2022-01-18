using System;

namespace SchoolDemo.Model
{
    public class Student
    {

        public Student(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.IsAlive = true;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }

        public bool IsAlive { get; set; }

        public void Deactive()
        {
            this.IsAlive = false;
        }
        public bool Exist { get => IsAlive; }
    }
}
