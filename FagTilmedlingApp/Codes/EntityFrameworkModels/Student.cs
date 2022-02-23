using System;
using System.Collections.Generic;

namespace FagTilmeldingApp.Codes.EntityFrameworkModels
{
    public partial class Student
    {
        public Student()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
