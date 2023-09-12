


using UseThread.Entity;

namespace UseThread.Classes;

public class EnterValue
{
    public Student student;
    public EnterValue() 
    {
        student = new Student();
    }

    public Student Create()
    {       
        Console.WriteLine("Enter your UserName");
        this.student.UserName = Console.ReadLine();
        Console.WriteLine("Enter your Ielts leave");
        this.student.Ielts = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter your Math leave");
        this.student.Math = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter your physics leave");
        this.student.physics = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter your chemistry leave");
        this.student.chemistry = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter your geography leave");
        this.student.geography = Convert.ToDecimal(Console.ReadLine()); 

        student.many = this.student.Ielts + student.Math + this.student.chemistry + this.student.geography + this.student.physics;

        return this.student;
    }
}
