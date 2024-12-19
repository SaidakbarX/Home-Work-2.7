using HomeWork_2._7.DataAccess.Entitiy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HomeWork_2._7.Repository;

public class StudentRpository : IStudentRepository
{
    private readonly string _path;
    private List<Student> _students;
    public StudentRpository()
    {
        _path = "../../../DataAccess/Data/Students.json";
        _students = new List<Student>();
        if (!File.Exists(_path))
        {
            File.WriteAllText(_path, "[]");
        }
        _students = ReadAllStudents();
    }
    
    public void EmailContains(string email)
    {
        foreach (var student in _students)
        {
            if (student.Email==email)
            {
                throw new Exception("Bunday Email bor qoshaolmaysiz");
            }
        }
    }

    public Student GetStudentById(Guid studentId)
    {
        foreach (var student in _students)
        {
            if(student.Id==studentId)
            {
                return student;
            }
        }
        throw new Exception($"Bunday id {studentId} li talaba mavjud emas");
    }

    public List<Student> ReadAllStudents()
    {
        var studentJson = File.ReadAllText(_path);
        var students = JsonSerializer.Deserialize<List<Student>>(studentJson);
        return students;
    }

    public void RemoveStudent(Guid studentId)
    {
        var student = GetStudentById(studentId);
        _students.Remove(student);
        SaveData();

    }

    public void UpdateStudent(Student student)
    {
        var updatingStudents = GetStudentById(student.Id);
        var index = _students.IndexOf(student);
        _students[index] = student;
        SaveData();
    }

    public Guid WriteStudent(Student student)
    {
        _students.Add(student);
        SaveData();
        return student.Id;
    }
    private void SaveData ()
    {
        var studentJson = JsonSerializer.Serialize(_students);
        File.WriteAllText(_path, studentJson);
    }
}
