using HomeWork_2._7.Services.DTOs;
using HomeWork_2._7.Services.Enums;

namespace _2._7dars.Api.Services;

public interface IStudentService
{
    Guid AddStudent(StudentCreatDto studentCreateDto);
    void DeleteStudent(Guid studentId);
    StudentGetDto GetStudentById(Guid studentId);
    List<StudentGetDto> GetStudents();
    void UpdateStudent(StudentUpdateDto studentUpdateDto);
    List<StudentGetDto> GetStudentsByDegree(DegreeDto degreeStatusDto);
    List<StudentGetDto> GetStudentsByGender(GenderDto genderDto);
}