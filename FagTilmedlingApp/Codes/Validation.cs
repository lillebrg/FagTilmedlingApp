using FagTilmedlingApp.Codes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FagTilmeldingApp.Codes;

namespace FagTilmeldingApp.Codes
{
    internal class Validation
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public string? ErrorMessage { get; set; }
        public bool ValidateCourse(string fagID, List<Course> listCourses)
        {
            bool succes = int.TryParse(fagID, out int result);
            if (!succes)
                ErrorMessage = "Det indtastede fagID er forkert format.";
            else
            {
                Course? fagId = listCourses.FirstOrDefault(a => a.Id == result);
                // eksistere id ikke.
                if (fagId == null)
                {
                    succes = false;
                    ErrorMessage = "Det indtastede fagID eksistere ikke.";
                }
                else
                {
                    CourseId = result;
                }
            }
            return succes;
        }
        public bool ValidateStudent(string elevID, List<Student> listStudents)
        {
            bool succes = int.TryParse(elevID, out int result);
            if (!succes)
                ErrorMessage = "Det indtastede elevID er forkert format";
            else
            {
                Student? studentId = listStudents.FirstOrDefault(a => a.Id == result);
                // Hvis ingen match er, eksistere id ikke.
                if (studentId == null)
                {
                    succes = false;
                    ErrorMessage = "Det indtastede ElevID eksistere ikke.";
                }
                else
                {
                    StudentId = result;
                }
            }
            return succes;
        }
        public bool EnrollmentValidation(List<Enrollment> listEnrollment)
        {
            bool succes = true;
            Enrollment? enrollmentID = listEnrollment.FirstOrDefault(a => a.CourseId == CourseId && a.StudentId == StudentId);

            if (enrollmentID != null)
            {
                succes = false;
            }
            return succes;
        }

    }
}
