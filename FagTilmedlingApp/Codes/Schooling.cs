using FagTilmedlingApp.Codes.Models;
using FagTilmedlingApp.Codes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTilmeldingApp.Codes
{
    internal abstract class Schooling
    {
        Enums.SchoolingCategory SchoolingName { get; set; }
        
         
        public Schooling(Enums.SchoolingCategory s)
        {
            SchoolingName = s;
        }
        
        public Schooling()
        {
        }

        List<Course> Courses = new()
        {

        };

        List<TECPerson> Teachers = new()
        {
            new TECPerson() { FullName = "Bo Hansen" },
            new TECPerson() { FullName = "Niels Olesen" },
            new TECPerson() { FullName = "Ole Nielsen" }
        };

        public virtual void SetCourses()
        {

            foreach (string? str in Enum.GetNames(typeof(Enums.CourseCategory)))
            {
                new Course() { CoursesEnum = str};

            }
        }
        public abstract void GetTeacher();
    }
}
