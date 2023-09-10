
using UseThread.Entity;

namespace UseThread.Classes;

public class StudentValue
{
    public static List<Student> students { get; set; }
    public static List<string> userNames { get; set; }

    public StudentValue()
    {
        students = new List<Student>();
        userNames = new List<string>();
    }

    public static void Add(Student student)
    {
            students.Add(student);   
    }
    public static bool See(Student student) 
    {
        return false;
    }
    public bool Name(string name)
    {
        Thread.Sleep(1500);
        bool s;
        for (int i = 0; i < userNames.Count; i++)
        {
            if (userNames[i] == name)
            {
                return true;
            }
        }
        
        userNames.Add(name);
          
        return false;
    }
}
