using FagTilmeldingApp.Codes.EntityFrameworkModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTilmeldingApp.Codes.EntityFrameWork_eksempel;

internal class EntityFrameworkHancler
{
    public List<Teacher> GetTeachers()
    {

        using TECContext db = new();
        return db.Teachers.ToList();
    }

    //Fix course og student men er ikke noget til de øvelser endnu
    public List<Course> GetCourse()
    {
        using TECContext db = new();
        return db.Courses.ToList();
    }

    public void InsertEnrollment(int studentId, int courseId)
    {
        using TECContext db = new();
        Enrollment enrollment = new Enrollment() { StudentId = studentId, CourseId = courseId };

        db.Add(enrollment);
        db.SaveChanges();
    }
}
