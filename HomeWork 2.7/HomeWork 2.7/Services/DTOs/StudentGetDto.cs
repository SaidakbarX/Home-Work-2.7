using HomeWork_2._7.Services.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._7.Services.DTOs;

public class StudentGetDto : BaseStudentDto
{
    public  Guid  Id { get; set; }
    public GenderDto Gender { get; internal set; }
}
