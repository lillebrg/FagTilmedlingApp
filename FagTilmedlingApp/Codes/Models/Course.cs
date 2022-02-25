using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTilmedlingApp.Codes.Models
{

    internal class Course
    {
        public int Id { get; set; }

        public string? CourseName { get; set; }

        public int TeacherId { get; set; }
    }
}
