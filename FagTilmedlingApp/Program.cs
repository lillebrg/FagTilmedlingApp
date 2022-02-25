using FagTilmedlingApp.Codes.Models;
// Iteration 4

string? errorMsg = null;
Student? matchedStudent = null;
Course ? matchedCourse = null;

Console.WriteLine("Angiv Skole: ");
string? skoleNavn = Console.ReadLine();

Console.WriteLine("Angiv Hovedforløb: ");
string? hovedforløbNavn = Console.ReadLine();

Console.WriteLine("Angiv Uddannelseslinje: ");
string? uddannelseslinje = Console.ReadLine();

Semester semester = new(hovedforløbNavn, skoleNavn);
semester.SetUddannelseslinje(uddannelseslinje);

string? uddannelseslinjeBeskrivelse = null;
bool exitLoop = false;
while (!exitLoop)
{
    Console.WriteLine();
    Console.WriteLine("Ønsker du at angiv en kort beskrivelse af uddannelseslinje: ");
    Console.WriteLine("1) Ja");
    Console.WriteLine("2) Nej");
    Console.Write("Vælg 1 eller 2: ");
    switch ((Console.ReadKey()).Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine();
            Console.WriteLine("Angiv kort beskrivelse af uddannelseslinje: ");
            uddannelseslinjeBeskrivelse = Console.ReadLine();
            exitLoop = true;
            break;
        case ConsoleKey.D2:
            exitLoop = true;
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("Forkert valgt, prøv igen: ");
            break;
    }
}

Semester se = new(hovedforløbNavn, skoleNavn);
if (uddannelseslinjeBeskrivelse != null)
    semester.SetUddannelseslinje(uddannelseslinje, uddannelseslinjeBeskrivelse);
else
    semester.SetUddannelseslinje(uddannelseslinje);



List<Teacher> teachers = new()
{
    new Teacher() { Id = 1, FirstName = "Niels", LastName = "Olesen" },
    new Teacher() { Id = 2, FirstName = "Henrik", LastName = "Poulsen" }
};

List<Student> students = new()
{
    new Student() { Id = 1, FirstName = "Martin", LastName = "Jensen" },
    new Student() { Id = 2, FirstName = "Patrik", LastName = "Nielsen" },
    new Student() { Id = 3, FirstName = "Susanne", LastName = "Hansen" },
    new Student() { Id = 4, FirstName = "Thomas", LastName = "Olsen" }
};

List<Course> courses = new()
{
    new Course() { Id = 1, CourseName = "Grundlæggende programmering", TeacherId = 1 },
    new Course() { Id = 2, CourseName = "Database programmering", TeacherId = 1 },
    new Course() { Id = 6, CourseName = "StudieTeknik", TeacherId = 1 },
    new Course() { Id = 7, CourseName = "Clientside programmering", TeacherId = 2 }
};

List<Enrollment> enrollments = new();
Validation v = new();
while (true)
{
    Console.Clear();

    Semester s = new(hovedforløbNavn, skoleNavn);
    Console.WriteLine("--------------------------------------------------------------");
    Console.WriteLine("{0}, {1}, {2} fag tilmelding app", skoleNavn, hovedforløbNavn, uddannelseslinje);
    Console.WriteLine("--------------------------------------------------------------");
    Console.WriteLine();

    int antalTilmeld = (enrollments.Where(a => a.CourseId == 1).ToList()).Count();
    string fagNavn = (courses.FirstOrDefault(a => a.Id == 1)).CourseName;
    Console.WriteLine("{0} elever i {1}", antalTilmeld, fagNavn);

    antalTilmeld = (enrollments.Where(a => a.CourseId == 2).ToList()).Count();
    fagNavn = (courses.FirstOrDefault(a => a.Id == 2)).CourseName;
    Console.WriteLine("{0} elever i {1}", antalTilmeld, fagNavn);

    antalTilmeld = (enrollments.Where(a => a.CourseId == 6).ToList()).Count();
    fagNavn = (courses.FirstOrDefault(a => a.Id == 6)).CourseName;
    Console.WriteLine("{0} elever i {1}", antalTilmeld, fagNavn);

    Console.WriteLine();


    if (errorMsg != null)
    {
        Console.WriteLine(errorMsg);
    }

    if (enrollments.Count() > 0)
    {
        foreach (Enrollment item in enrollments)
        {
            matchedStudent = students.FirstOrDefault(a => a.Id == item.StudentId);
            matchedCourse = courses.FirstOrDefault(a => a.Id == item.CourseId);
            if (matchedStudent != null && matchedCourse != null)
            {
                Console.WriteLine("{0} {1} tilmeldt fag {2}", matchedStudent.FirstName, matchedStudent.LastName, matchedCourse.CourseName);
            }
        }
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine();
    }

    errorMsg = null;

    Console.WriteLine("Indsæt elev id: ");
    string? studentId = Console.ReadLine();
    bool succes = v.ValidateStudent(studentId, students);
    if (succes)
    {
        Console.WriteLine("Indsæt fag id: ");
        string courseId = Console.ReadLine();
        succes = v.ValidateCourse(courseId, courses);
    }
    else
    {
        errorMsg = v.ErrorMessage;
    }

    if (succes)
    {
        int id = enrollments.Count() + 1;
        enrollments.Add(new Enrollment() { Id = id, StudentId = v.StudentId, CourseId = v.CourseId });
    }
    else
    {
        errorMsg = v.ErrorMessage;
    }
}