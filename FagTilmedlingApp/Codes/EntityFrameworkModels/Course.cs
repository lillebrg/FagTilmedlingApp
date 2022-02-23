using System;
using System.Collections.Generic;

namespace FagTilmeldingApp.Codes.EntityFrameworkModels
{
    public partial class Course
    {
        public Course()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int Id { get; set; }
        public string? Course1 { get; set; }
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; } = null!;
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
