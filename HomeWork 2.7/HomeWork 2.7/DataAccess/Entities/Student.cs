using HomeWork_2._7.DataAccess.Data.Enums;
using HomeWork_2._7.Services.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._7.DataAccess.Entities;

public  class Student
{
    public  Guid Id { get; set; }
    public string FirtName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public GenderDto Gender { get; set; }
    public Data.Enums.Degree Status { get; set; }
    public DegreeDto Degree { get; internal set; }
    public string FirstName { get; internal set; }
}
