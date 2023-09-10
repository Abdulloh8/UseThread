using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseThread.Entity;

namespace UseThread.Classes
{
    internal static class StudentValue
    {
        public static List<Student> students = new List<Student>();

        public static void Add(Student student)
        {
            bool Enpty = students.Any(s => s.UserName != student.UserName);
            if (Enpty)
            {
                students.Add(student);
                Console.WriteLine("This username has been added before\nPlease try again with another username");
            }
            else
            {
                Console.WriteLine("User successfully Add");
            }
        }
        public static bool See(Student student) 
        {
            return false;
        }
    }
}
