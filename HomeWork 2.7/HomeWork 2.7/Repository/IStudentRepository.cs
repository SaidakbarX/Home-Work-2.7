using HomeWork_2._7.DataAccess.Entitiy;

namespace HomeWork_2._7.Repository;

public interface IStudentRepository
{
    Guid WriteStudent (Student student);
    List<Student> ReadAllStudents ();
    void RemoveStudent(Guid studentId);
    Student GetStudentById (Guid studentId);
    void UpdateStudent (Student student);
    void EmailContains (string email);
}