using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    class Student // type of class
    {
        // public strings and ints
        public string name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Student(string name, int ID, int Age, string Course)
        {
            this.name = name;
            this.ID = ID;
            this.Age = Age;
            this.Course = Course;
        }
        //Display Info
        public virtual void DisplayInfo()
        {
            Console.WriteLine($" {name} -- {ID} -- {Age} -- {Course} ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Students Info
            Student student1 = new Student("Jeff", 2589856, 10, "Math");
            student1.DisplayInfo();


            Student student2 = new Student("Bob", 7826984, 11, "History");
            student2.DisplayInfo();

            Student student3 = new Student("Mike", 4589896, 12, "Science");
            student3.DisplayInfo();
        }

    }
}
