
namespace FineArts.Entities
{
    public class Teacher
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Dir { get; set; } = string.Empty;

        public string Class { get; set; } = string.Empty;

        public List<Student>? Students { get; set; }

        public Teacher(string firstName, string lastName, string email, string dir, string @class, List<Student>? students)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Dir = dir;
            Class = @class;
            Students = students;
        }
        public Teacher() { }
    }
}