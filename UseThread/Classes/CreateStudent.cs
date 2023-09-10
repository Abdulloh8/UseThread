using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseThread.Dto;
using UseThread.Entity;

namespace UseThread.Classes;

public class CreateStudent
{
    
    string username;
    bool empty;
    StudentValue value;

    public CreateStudent()
    {
        value = new StudentValue();
    }
    public void Create()
    {
        var studentdto = new StudentDto();
        
        do
        {
           // Console.WriteLine("This username has been added before\nPlease try again with another username");
            Console.WriteLine("Enter your UserName");
            username = Console.ReadLine();
            empty = value.Name(username);
        }while (empty);

        
        

        Console.WriteLine("Enter your Ielts leave");
        studentdto.Ielts = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter your Math leave");
        studentdto.Math = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter your physics leave");
        studentdto.physics = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter your chemistry leave");
        studentdto.chemistry = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter your geography leave");
        studentdto.geography = Convert.ToDecimal(Console.ReadLine());

        var student = new Student
        {
            Id = new Guid(),
            UserName = username,
            Ielts = studentdto.Ielts,
            Math = studentdto.Math,
            physics = studentdto.physics,
            chemistry = studentdto.chemistry,
            geography = studentdto.geography,
        };

        StudentValue.Add(student);

    }
}
