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
        public override void SetCourses()
        {
            

        }

        public override void GetTeacher()
        {

        }
    }
}
