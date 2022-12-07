using FineArts.Entities;
using System.Runtime.CompilerServices;

namespace FineArts.Dal
{
    public class Repository
    {
        public bool HasTeachers()
        {
            using FineArtsContext context = new();
            return context.Teachers.Any();
        }
        public List<Teacher> GetTeachers()
        {
            using FineArtsContext context = new();
            return context.Teachers.ToList();
        }
        public bool AddTeachers(List<Teacher> teachers)
        {
            using FineArtsContext context = new();
            context.AddRange(teachers);
            return context.SaveChanges() > 0;
        }
        public List<Student> GetStudentsByTeacherId(int teacherId)
        {
            using FineArtsContext context = new();
            return context.Students.Where(x => x.TeacherId.Equals(teacherId)).ToList();
        }
        public bool FindStudent(int studentId, string nameClass)
        {
            using FineArtsContext context = new();
            var response=  context.Students.Where(s => s.Id.Equals(studentId) && s.Teacher != null && s.Teacher.Class.Equals(nameClass));
            if (response != null) 
            {
                return true;
            }
            return false;
        }
    }
}
