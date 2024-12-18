using _2._7dars.Api.Services;
using HomeWork_2._7.Services.DTOs;

namespace HomeWork_2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dto1 = new StudentUpdateDto()
            {
                Id = Guid.NewGuid(),
                FirstName = "Aziz",
                LastName = "Botiriov",
                Age = 19,
                Email = "Botirov@gmail.com",
                Password = "password",
                Gender = 0,
                Degree = 0,
            };

            var dto2 = new StudentUpdateDto()
            {
                Id = Guid.NewGuid(),
                FirstName = "Azizjon",
                LastName = "Laripov",
                Age = 24,
                Email = "Latipov@gmail.com",
                Password = "password12",
                Gender = 0,
                Degree = (Services.Enums.DegreeDto)1,
            };

            IStudentService studentService = new StudentService();
            studentService.UpdateStudent(dto1);
            studentService.UpdateStudent(dto2);
        }
    }
}
