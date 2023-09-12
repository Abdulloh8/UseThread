
using UseThread.Entity;

namespace UseThread.Classes
{
    public class inspection
    {
        public async Task See(Student student)
        {
            if (student.many < 13)
            {
                Console.WriteLine("Sizning balingiz hechqaysi fakultedga yetmadi");
            }
            else
            {
                Unversity("English Language", student);
                Unversity("Math", student);
                Unversity("geography", student);
                Unversity("physics", student);
                Unversity("chemistry", student);
            }
        }
        public async Task Unversity(string faculted, Student student)
        {
            switch (faculted)
            {
                case "English Language":
                    if (student.many > 30 && student.Ielts >= 7)
                    {
                        Grant(faculted);
                    }
                    else if (student.many >25  && student.Ielts >= 6)
                    {
                        Kantrakt(faculted);
                    }
                    else
                    {
                        fols(faculted); 
                    }
                    break;
                case "Math":
                    if (student.many > 30 && student.Math >= 7)
                    {
                        Grant(faculted);
                    }
                    else if (student.many > 25 && student.Math >= 6)
                    {
                        Kantrakt(faculted);
                    }
                    else
                    {
                        fols(faculted);
                    }
                    break;
                case "geography":
                    if (student.many > 30 && student.geography >= 7)
                    {
                        Grant(faculted);
                    }
                    else if (student.many > 25 && student.geography >= 6)
                    {
                        Kantrakt(faculted);
                    }
                    else
                    {
                        fols(faculted);
                    }
                    break;
                case "physics":
                    if (student.many > 30 && student.physics >= 7)
                    {
                        Grant(faculted);
                    }
                    else if (student.many > 25 && student.physics >= 6)
                    {
                        Kantrakt(faculted);
                    }
                    else
                    {
                        fols(faculted);
                    }
                    break;
                case "chemistry":
                    if (student.many > 30 && student.chemistry >= 7)
                    {
                        Grant(faculted);
                    }
                    else if (student.many > 25 && student.chemistry >= 6)
                    {
                        Kantrakt(faculted);
                    }
                    else
                    {
                        fols(faculted);
                    }
                    break;
            }

        }

        public async Task Grant(string faculted)
        {
            await Task.Delay(6000);
            Console.WriteLine($"Siz {faculted} facultetiga grant asosida kirishingiz mumkun");
        }
        public async Task Kantrakt(string faculted)
        {
            await Task.Delay(3500);
            Console.WriteLine($"Siz {faculted} facultetiga kontrakt asosida kirishingiz mumkun");
        }
        public async Task fols(string faculted)
        {
            await Task.Delay(1500);
            Console.WriteLine($"Siz {faculted} facultetiga kiraolmaysiz");
        }
    }
}




