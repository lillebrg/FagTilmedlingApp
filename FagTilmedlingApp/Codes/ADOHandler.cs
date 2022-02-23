using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTilmeldingApp.Codes
{
    internal class ADOHandler
    {
        public string? ConnectionString
        {
            get => "Data Source=DEM0N-LAPTOP; Initial Catalog=TEC; Integrated Security=True; Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False";
        }

        public List<Teacher2> GetTeachers()
        {
            List<Teacher2> teachers = new List<Teacher2>();

           using SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Teacher", con);
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Teacher2 teacher = new Teacher2() {Id = reader.GetInt32(0), FirstName = reader.GetString(1), LastName = reader.GetString(2)};
                teachers.Add(teacher);
            }

                return teachers;
        }

        //Fix course og student men er ikke noget til de øvelser endnu
        public List<Course2> GetCourse()
        {
            List<Course2> courses = new List<Course2>();

            using SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Course", con);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Course2 course = new Course2() { Id = reader.GetInt32(0), CourseName = reader.GetString(1)};
                courses.Add(course);
            }

            return courses;
        }

        //copy af GetTeacher laves til student
        public List<Teacher2> GetTeacher()
        {
            List<Teacher2> teachers = new List<Teacher2>();

            using SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Teacher", con);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Teacher2 teacher = new Teacher2() { Id = reader.GetInt32(0), FirstName = reader.GetString(1), LastName = reader.GetString(2) };
                teachers.Add(teacher);
            }

            return teachers;
        }

        public void InsertEnrollment(int studentId, int courseId)
        {
            using SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            SqlCommand command = new SqlCommand($"INSERT INTO Enrollment VALUES({studentId}, {courseId})", con);

            command.ExecuteNonQuery();
        }
    }
}
