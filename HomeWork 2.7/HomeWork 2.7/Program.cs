
using HomeWork_2._7.DataAccess.Enums;
using HomeWork_2._7.Repository;
using HomeWork_2._7.Services;
using HomeWork_2._7.Services.DTOs;
using System.Security.Principal;

namespace HomeWork_2._7;

internal class Program
{
    static void Main(string[] args)
    {
        IStudentService studentService = new StudentService();
        var dto1 = new StudentUpdateDto()
        {
            Id = new Guid("08cb4189-81f4-44b0-95f6-6f9286aea07a"),
            FirstName = "dsfds",
            LastName = "Botiriov",
            Age = 19,
            Email = "Botirov@gmail.com",
            Password = "password",
            Gender = 0,
            Degree = 0,
        };
        Guid id = new Guid("08cb4189-81f4-44b0-95f6-6f9286aea07a");
        studentService.DeleteStudent(id);

        
        
    }
}
