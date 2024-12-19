using HomeWork_2._7.Services.DTOs;
using HomeWork_2._7.Services.Enums;

namespace HomeWork_2._7.Services;

public interface IStudentService
{
    Guid AddStudent(StudentCreatDto student);
    void DeleteStudent(Guid studentId);
    StudentGetDto GetStudentById(Guid studentId);
    List<StudentGetDto> GetAllStudents();
    void UpdadateStudent(StudentUpdateDto studentUpdateDto);
    List<StudentGetDto> GetStudentsByDegree (DegreeDto degree);
    List<StudentGetDto> GetStudentsByGender (GenderDto gender);
}