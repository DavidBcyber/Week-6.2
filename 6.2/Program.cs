using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    class Student // The student class information
    {
        // public strings and int for the student info
        public string name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Student(string name, int ID, int Age, string Course) // the class infomation to identify to put in the system
        {
            this.name = name;
            this.ID = ID;
            this.Age = Age;
            this.Course = Course;
        }
        public virtual void DisplayInfo() // The display for every student information
        {
            Console.WriteLine($" {name} -- {ID} -- {Age} -- {Course} ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //The first student info for Jeff
            Student student1 = new Student("Jeff", 2589856, 10, "Math");
            student1.DisplayInfo();

            //The second student's info for Bob
            Student student2 = new Student("Bob", 7826984, 11, "History");
            student2.DisplayInfo();
            
            //The third student's info for Mike
            Student student3 = new Student("Mike", 4589896, 12, "Science");
            student3.DisplayInfo();
        }

    }
}
