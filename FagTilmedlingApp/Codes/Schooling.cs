using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTilmeldingApp.Codes
{
    internal abstract class Schooling
    {
       public SchoolingCategory SchoolingName { get; set; }
        public List<string>? Courses { get; set; }
        public List<TECPerson> Teachers { get; set; }


        public Schooling(SchoolingCategory SchoolingName)
        {
            List<TECPerson> TeacherName = new()
            {
                new TECPerson { FullName = "Niels Olsen", UddannelsesLinje = SchoolingCategory.Programmeringslinje },
                new TECPerson { FullName = "Bo Hansen", UddannelsesLinje = SchoolingCategory.Supportlinje },
                new TECPerson { FullName = "Ole Nielsen", UddannelsesLinje = SchoolingCategory.Infrastrukturlinje }
            };
            Teachers = TeacherName.ToList();
        }

        public virtual void SetCourses()
        {
            List<string> courses = new();
            Courses = courses;
            foreach (var displayCourses in (Enum.GetNames(typeof(CourseCategory))))
                courses.Add(displayCourses);

        }
        public abstract void GetTeacher();
    }
}
