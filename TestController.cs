using FactoryMethodPattern_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern_Project.Controllers
{
    public class TestController
    {
        private readonly IObjectFactory factory;
        public TestController(IObjectFactory factory)
        {
            this.factory = factory;
        }
        public void Action()
        {
            var students = new[]
            {
                factory.Create<Student>(1, "Noushin S", new DateTime(2012, 11, 23), "Winter"),
                factory.Create<Student>(2, "Noushin L", new DateTime(2003, 11, 23), "Spring"),
                factory.Create<Student>(3, "Fahim S", new DateTime(2013, 11, 23), "Winter")
            };
            Console.WriteLine("Student List");
            students.ToList()
                .ForEach(s => Console.WriteLine($"Id: {s.Id} Name: {s.Name} Semester: {s.Semester}"));
            var teachers = new[]
            {
                factory.Create<Teacher>(101, "Taijul I", "CSE", "p@gg.com"),
                factory.Create<Teacher>(102, "Kamrul H", "EEE", "a@gg.com"),
                factory.Create<Teacher>(103, "Raisul I", "MIS", "s@gg.com")
            };
            Console.WriteLine("Teacher List");
            teachers.ToList()
                .ForEach(t => Console.WriteLine($"Name: {t.Name}, Department: {t.Department}, Email: {t.Email}"));
        }
    }
}
