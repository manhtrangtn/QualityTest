using QualityTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityTest.Controllers
{
    class StudentController
    {
        public void PrintListStudent(List<Student> students)
        {
            string status;
            Console.WriteLine("================================================================== STUDENT LIST ===============================================================");
            Console.WriteLine("|{0,15}|{1,25}|{2,15}|{3,35}|{4,15}|{5,15}|{6,15}|","Roll Number", "Full Name", "Birth Date", "Email", "Phone", "Joined Date", "Status");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------");
            foreach(Student student in students)
            {
                if (!student.IsDeactive())
                {
                    if (student.IsNewStudent())
                    {
                        status = "New Student";
                    }
                    else status = student.Status.ToString();

                    Console.WriteLine("|{0,15}|{1,25}|{2,15}|{3,35}|{4,15}|{5,15}|{6,15}|", student.RollNumber, student.FullName, student.BirthDate.ToString("MM/dd/yyyy"), student.Email, student.Phone, student.CreatedAt.ToString("MM/dd/yyyy"), status);
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------");

                }
            }
        }

        public Student CreateStudent()
        {
            Student student = new Student();
            Console.Write("Enter student roll number: ");
            student.RollNumber = Console.ReadLine();
            Console.Write("Enter student name: ");
            student.FullName = Console.ReadLine();
            Console.Write("Enter student birth day: ");
            student.BirthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter student email: ");
            student.Email = Console.ReadLine();
            Console.Write("Enter student phone number: ");
            student.Phone = Console.ReadLine();
            Console.Write("Enter student created date: ");
            student.CreatedAt = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter student status (0 = Deactive or 1 - Active): ");
            if (Int32.Parse(Console.ReadLine()) == 0)
            {
                student.Status = StudentStatus.Deactive;
            } else student.Status = StudentStatus.Active;
            return student;
        }
    }
}
