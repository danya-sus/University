using System;
using University.Data;
using University.Data.Models;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new UniversityContext())
            {
                var student = new Student();

                student.Name = "Вася";
                student.PhoneNumber = "9991234567";
                student.RegisteredOn = DateTime.Now;

                db.Students.Add(student);

                db.Courses.Add(new Course
                {
                    Name = "EF CORE",
                    Price = 0,
                    Description = "Курс о разработке приложений, работающих с БД.",
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddDays(30)
                });

                db.SaveChanges();
            }
        }
    }
}
