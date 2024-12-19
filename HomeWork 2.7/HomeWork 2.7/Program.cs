
using HomeWork_2._7.DataAccess.Enums;
using HomeWork_2._7.Services.DTOs;
using System.Security.Principal;

namespace HomeWork_2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dto1 = new StudentUpdateDto();
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

            
        }
    }
}
