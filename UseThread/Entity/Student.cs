using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseThread.Entity;

internal class Student
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public decimal Ielts { get; set; }
    public decimal Math { get; set; }
    public decimal geography { get; set; }
    public decimal chemistry { get; set; }
    public decimal physics { get; set; }


}
