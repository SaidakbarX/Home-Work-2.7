using HomeWork_2._7.DataAccess.Entitiy;
using HomeWork_2._7.Repository;
using HomeWork_2._7.Services.DTOs;
using HomeWork_2._7.Services.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._7.Services;

public class StudentService : IStudentService
{    

    private readonly IStudentRepository _studentRepository;
    public StudentService()
    {
        _studentRepository = new StudentRpository();
    }

    public Guid AddStudent(StudentCreatDto student)
    {
        var res = ValidateStudentCreatDto(student);
        if (res == false)
        {
            throw new Exception("xatolik yuz berdi");
        }

        var entity = ConvertToEntity(student);
        var Id = _studentRepository.WriteStudent(entity);
        return Id;



    }

    public void DeleteStudent(Guid studentId)
    {
        _studentRepository.RemoveStudent(studentId);
    }

    public List<StudentGetDto> GetAllStudents()
    {
       var students  = _studentRepository.ReadAllStudents();
        var studentDto = new List<StudentGetDto>();
        foreach (var student in students)
        {
            studentDto.Add(ConvertToDto(student));
        }
        return studentDto;

    }

    public StudentGetDto GetStudentById(Guid studentId)
    {
       var entity = _studentRepository.GetStudentById(studentId);
        var res = ConvertToDto(entity);
        return res;
    }

    public List<StudentGetDto> GetStudentsByDegree(DegreeDto degree)
    {
        var students = _studentRepository.ReadAllStudents();
        var studentDto = new List<StudentGetDto>();
        foreach (var student in students)
        {  if ((DegreeDto)student.Degree == degree)
            {
                studentDto.Add(ConvertToDto(student));
            }
        }
        return studentDto;
    }

    public List<StudentGetDto> GetStudentsByGender(GenderDto gender)
    {
        var students = _studentRepository.ReadAllStudents();
        var studentDto = new List<StudentGetDto>();
        foreach (var student in students)
        {  if ((GenderDto)student.Gender == gender)
            {
                studentDto.Add(ConvertToDto(student));
            }
        }
        return studentDto;
    }

    public void UpdadateStudent(StudentUpdateDto studentUpdateDto)
    {   var entity = ConvertToEntity(studentUpdateDto);
        _studentRepository.UpdateStudent(entity);
        
    }
    private  Student ConvertToEntity(StudentCreatDto student)
    {
        return new Student
        {
            Id = Guid.NewGuid(),
            FirstName = student.FirstName,
            LastName = student.LastName,
            Email = student.Email,
            Age = student.Age,
            Password = student.Password,
            Gender = (DataAccess.Enums.Gender)student.Gender,
            Degree = (DataAccess.Enums.Degree)student.Degree,

        };

    }
    private Student ConvertToEntity (StudentUpdateDto student)
    {
        return new Student
        {
            Id = student.Id,
            FirstName = student.FirstName,
            LastName = student.LastName,
            Email = student.Email,
            Password = student.Password,
            Age= student.Age,
            Degree = (DataAccess.Enums.Degree)student.Degree,
            Gender = (DataAccess.Enums.Gender)student.Gender,

        };
    }
    private StudentGetDto ConvertToDto(Student student)
    {
        return new StudentGetDto
        {
            Id = student.Id,
            FirstName = student.FirstName,
            LastName = student.LastName,
            Email = student.Email,
            Age = student.Age,
            Gender = (GenderDto)student.Gender,
            Degree = (DegreeDto)student.Degree,
        };
    }
    private bool ValidateStudentCreatDto (StudentCreatDto obj)
    {
        _studentRepository.EmailContains(obj.Email);
        if (string.IsNullOrWhiteSpace(obj.FirstName) || obj.FirstName.Length > 50)
        {
            return false;
        }
        if (string.IsNullOrWhiteSpace(obj.LastName) || obj.LastName.Length > 50)
        {
            return false ;
        }
        if (obj.Age < 15 || obj.Age > 50)
        {
            return false;
        }
        if (string.IsNullOrWhiteSpace(obj.Email)|| !obj.Email.EndsWith("@gmail.com")
            || obj.Email.Length > 100 || obj.Email.Length < 10)
        {
            return false;
        }
        if (string.IsNullOrWhiteSpace(obj.Password) || obj.Password.Length < 50)
        {
            return false;
        }
        return true;

    }
}
