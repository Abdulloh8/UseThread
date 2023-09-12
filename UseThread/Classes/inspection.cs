using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
        public async Task Unversity()
        {

        }
    }
}
