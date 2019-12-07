using QualityTest.Controllers;
using QualityTest.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityTest
{
    class Program
    {

        static void Main(string[] args)
        {
            StudentController studentController = new StudentController();
            List<Student> students = new List<Student>();
            Student student = new Student();
            bool quit = false;
            while (!quit)
            {
                Menu();
                byte choose = Byte.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        student = studentController.CreateStudent();
                        students.Add(student);
                        break;
                    case 2:
                        studentController.PrintListStudent(students);
                        break;
                    case 0:
                        quit = true;
                        break;
                    default: Console.WriteLine("Unavailable function, choose againt!"); break;
                }
            }
        }

        public static void Menu()
        {
            Console.WriteLine("=============== MENU ==============");
            Console.WriteLine("[1] - Add new student: ");
            Console.WriteLine("[2] - View list student: ");
            Console.WriteLine("[0] - Quit program: ");
            Console.WriteLine("-----------------------------------");
            Console.Write("Enter your choice: ");
        }
    }
}
