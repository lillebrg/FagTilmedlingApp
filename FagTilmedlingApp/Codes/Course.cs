using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTilmeldingApp.Codes
{
    internal sealed class Course : Schooling
    {
        public List<string> SchoolingCourses = new();
        public string? CoursesEnum { get; set; }

        public Course(SchoolingCategory SchoolingName) : base(SchoolingName)
        {
          SetCourses();

        }
        public override void SetCourses()
        {
            base.SetCourses();
            if (SchoolingName == SchoolingCategory.Programmeringslinje)
            {
                List<string> schoolingCourses = Courses.Where(a => a.Contains("programmering")).ToList();
                SchoolingCourses = schoolingCourses;
            }
            else if (SchoolingName == SchoolingCategory.Supportlinje)
            {
                List<string> schoolingCourses = Courses.Where(a => a.Contains("server")).ToList();
                SchoolingCourses = schoolingCourses;
            }
            else
            {
                List<string> schoolingCourses = Courses.Where(a => a.Contains("netværk")).ToList();
                SchoolingCourses = schoolingCourses;
            }

        }

        public override void GetTeacher()
        {
            List<TECPerson> HvisTeachers = new();
            Teachers = HvisTeachers;

            foreach (var HvisTeacher in Teachers)
            {
                if (SchoolingName == HvisTeacher.UddannelsesLinje)
                {
                    if (HvisTeacher.FullName == "Niels Olsen")
                        HvisTeachers.Add(HvisTeacher);

                    else if (HvisTeacher.FullName == "Bo Hansen")
                        HvisTeachers.Add(HvisTeacher);

                    else
                        HvisTeachers.Add(HvisTeacher);                
                }
                else
                    HvisTeachers.Add(HvisTeacher);
            }

            
        }
    }
}
