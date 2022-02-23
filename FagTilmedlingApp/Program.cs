// Iteration 2
using FagTilmeldingApp.Codes.EntityFrameWork_eksempel;
using FagTilmeldingApp.Codes.EntityFrameworkModels;
//string SkoleInput, HovedforlobInput;
//Console.WriteLine("Angiv skole: ");
//SkoleInput = Console.ReadLine();
//Console.WriteLine("Angiv hovedforløb: ");
//HovedforlobInput = Console.ReadLine();
//Semester se = new(SkoleInput, HovedforlobInput);
//Console.Clear();

//Console.WriteLine("-------------------------------------------------");
//Console.WriteLine("{0}, {1} fag tildmelding app.", se.SchoolName, se.SemesterNavn);
//Console.WriteLine("-------------------------------------------------");



List<Teacher> lisTeacher = new()
{
    new Teacher() { Id = 1, FirstName = "Niles", LastName = "Olesen" }
};


//ADOHandler adoHandler = new();

EntityFrameworkHancler entityFrameworkhandler = new();

List<Teacher> teachers = entityFrameworkhandler.GetTeachers();
foreach (Teacher teacher in teachers)
{
    Console.WriteLine($"{teacher.FirstName} {teacher.LastName}");
}

Console.WriteLine("Indsæt elevid: ");
int elevId = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Indsæt fagId: ");
int fagId = Convert.ToInt32(Console.ReadLine());

entityFrameworkhandler.InsertEnrollment(elevId, fagId);
