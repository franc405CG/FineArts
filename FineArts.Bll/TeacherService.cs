using FineArts.Dal;
using FineArts.Entities;
namespace FineArts.Bll
{
    public class TeacherService
    {
        private Repository repository;


        public TeacherService()
        {
            repository = new();
        }
        public static bool SeedData()
        {
            Repository? repository1;
            bool hasTestData = false;
            repository1 = new();
            if (repository1.HasTeachers() == false)
            {
                List<Teacher> teachers = new()
                {
                    new Teacher()
                    {
                        FirstName = "Esther",
                        LastName = "Valle",
                        Email = "Valle@fineArts.com",
                        Dir = "",
                        Class = "3C",
                        Students = new List<Student>
                    {
                        new Student()
                        {
                            FirstName ="Kevin",
                            LastName="Liu",
                            BirthDay = new DateTime(2005,10,10),
                         },
                        new Student()
                        {
                            FirstName ="Martin",
                            LastName="Weber",
                            BirthDay = new DateTime(2005,09,07),
                         },
                        new Student()
                        {
                            FirstName ="George",
                            LastName="Li",
                            BirthDay = new DateTime(2005,08,10),
                         },
                        new Student()
                        {
                            FirstName ="Lissa",
                            LastName="Miller",
                            BirthDay = new DateTime(2005,05,04),
                         }
                        ,
                        new Student()
                        {
                            FirstName ="Run",
                            LastName="Run",
                            BirthDay = new DateTime(2005,03,23),
                         }
                    }
                    },
                    new Teacher("Belinda", "Newman", "bNewman@fineArts.com", "", "2A", new List<Student>
                {
                        new Student()
                        {
                            FirstName ="Vijay",
                            LastName="Sundaram",
                            BirthDay = new DateTime(2007,02,03),
                         },
                        new Student()
                        {
                            FirstName ="Erick",
                            LastName="Gruber",
                            BirthDay = new DateTime(2007,05,26),
                         },
                        new Student()
                        {
                            FirstName ="Chris",
                            LastName="Meyer",
                            BirthDay = new DateTime(2006,05,09),
                         },
                        new Student()
                        {
                            FirstName ="Yuhong",
                            LastName="Li",
                            BirthDay = new DateTime(2007,05,28),
                         }
                        ,
                        new Student()
                        {
                            FirstName ="Yan",
                            LastName="Li",
                            BirthDay = new DateTime(2007,03,31),
                         }
                }),
                    new Teacher("David", "Waite", "dWaite@fineArts.com", "", "4B", new List<Student>
                    {
                        new Student()
                        {
                            FirstName ="Sean",
                            LastName="Stewart",
                            BirthDay = new DateTime(2003,02,18),
                         },
                        new Student()
                        {
                            FirstName ="Olinda",
                            LastName="Turner",
                            BirthDay = new DateTime(2003,05,17),
                         },
                        new Student()
                        {
                            FirstName ="Jhon",
                            LastName="Orton",
                            BirthDay = new DateTime(2002,08,10),
                         },
                        new Student()
                        {
                            FirstName ="Tobi",
                            LastName="Nixon",
                            BirthDay = new DateTime(2002,12,15),
                         },
                        new Student()
                        {
                            FirstName ="Daniela",
                            LastName="Guinot",
                            BirthDay = new DateTime(2002,08,01),
                         }
                    })
                };
                hasTestData = repository1.AddTeachers(teachers);
            }
            return hasTestData;
        }

        public List<Teacher> GetTeachers()
        {
            Repository repository = new();
            List<Teacher> response = repository.GetTeachers();
            return response;
        }

        public bool AddTeachers(List<Teacher> teachers)
        {
            Repository repository = new();
            bool response = repository.AddTeachers(teachers);
            return response;
        }

        public List<Student> GetStudentsByTeacherId(int teacherId)
        {
            Repository repository = new();
            List<Student> response = repository.GetStudentsByTeacherId(teacherId);
            return response;
        }
    }
}