

using UseThread.Classes;

var cr = new CreateStudent();
string z; 


while (true)
{
    Console.WriteLine("1 : Create student\n2 : See student");
    z = Console.ReadLine();
    if (z == "1")
    {
        cr.Create();
    }
    else if (z == "2")
    {

    }
    else
    {
        Console.WriteLine("Error");
    }
    
}

