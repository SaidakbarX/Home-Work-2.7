using HomeWork_2._7.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._7.DataAccess.Entitiy;

public class Student
{
     public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Degree Degree { get; set; }
    public Gender Gender { get; set; }
}
