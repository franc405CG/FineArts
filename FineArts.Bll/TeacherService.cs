using FineArts.Dal;
using FineArts.Entities;
namespace FineArts.Bll
{
    public class TeacherService
    {
        private Repository repository;
        private static Repository? repository1;

        public TeacherService() 
        {
            repository = new();
        }
        public static bool SeedData()
        {
            bool hasTestData = false;
            repository1 = new();
            if (repository1.HasTeachers() == false)
            {
                List<Teacher> teachers = new()
                {
                    new()
                    {
                        FirstName = "Esther",
                        LastName = "Valle",
                        Email = "Valle@fineArts.com",
                        Dir = "",
                        Class = "3C",
                        Students = new List<Student>
                    {
                        new()
                        {
                            FirstName ="Kevin",
                            LastName="Liu",
                            BirthDay = new DateTime(2005,10,10),
                         },
                        new()
                        {
                            FirstName ="Martin",
                            LastName="Weber",
                            BirthDay = new DateTime(2005,09,07),
                         },
                        new()
                        {
                            FirstName ="George",
                            LastName="Li",
                            BirthDay = new DateTime(2005,08,10),
                         },
                        new()
                        {
                            FirstName ="Lissa",
                            LastName="Miller",
                            BirthDay = new DateTime(2005,05,04),
                         }
                        ,
                        new()
                        {
                            FirstName ="Run",
                            LastName="Run",
                            BirthDay = new DateTime(2005,23,23),
                         }
                    }
                    },
                    new Teacher("Belinda", "Newman", "bNewman@fineArts.com", "", "2A", new List<Student>
                {
                        new()
                        {
                            FirstName ="Vijay",
                            LastName="Sundaram",
                            BirthDay = new DateTime(2007,02,03),
                         },
                        new()
                        {
                            FirstName ="Erick",
                            LastName="Gruber",
                            BirthDay = new DateTime(2007,05,26),
                         },
                        new()
                        {
                            FirstName ="Chris",
                            LastName="Meyer",
                            BirthDay = new DateTime(2006,05,09),
                         },
                        new()
                        {
                            FirstName ="Yuhong",
                            LastName="Li",
                            BirthDay = new DateTime(2007,05,28),
                         }
                        ,
                        new()
                        {
                            FirstName ="Yan",
                            LastName="Li",
                            BirthDay = new DateTime(2007,03,31),
                         }
                }),
                    new Teacher("David", "Waite", "dWaite@fineArts.com", "", "4B", new List<Student>
                {
                        new()
                        {
                            FirstName ="Sean",
                            LastName="Stewart",
                            BirthDay = new DateTime(2003,02,18),
                         },
                        new()
                        {
                            FirstName ="Olinda",
                            LastName="Turner",
                            BirthDay = new DateTime(2003,05,17),
                         },
                        new()
                        {
                            FirstName ="Jhon",
                            LastName="Orton",
                            BirthDay = new DateTime(2002,08,10),
                         },
                        new()
                        {
                            FirstName ="Tobi",
                            LastName="Nixon",
                            BirthDay = new DateTime(2002,12,15),
                         }
                        ,
                        new()
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