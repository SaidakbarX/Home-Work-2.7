using HomeWork_2._7.Services.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._7.Services.DTOs;

public class BaseStudentDto
{
    private GenderDto gender;

    public  string FirstName { get; set; }
    public string LastName { get; set; }
    public  int  Age { get; set; }
    public  string  Email { get; set; }
    public  DegreeDto Degree { get; set; }
}
