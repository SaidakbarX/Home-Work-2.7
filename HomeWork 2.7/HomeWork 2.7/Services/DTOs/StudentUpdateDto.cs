using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._7.Services.DTOs;

public class StudentUpdateDto : BaseStudentDto
{
    public  Guid Id { get; set; }
    public string Password { get; set; }
    public DataAccess.Data.Enums.Gender Gender { get; internal set; }
}
