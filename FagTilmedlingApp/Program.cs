// Iteration 2
string SkoleInput, HovedforlobInput;
Console.WriteLine("Angiv skole: ");
SkoleInput = Console.ReadLine();
Console.WriteLine("Angiv hovedforløb: ");
HovedforlobInput = Console.ReadLine();
Semester se = new(SkoleInput, HovedforlobInput);
Console.Clear();

Console.WriteLine("-------------------------------------------------");
Console.WriteLine("{0}, {1} fag tildmelding app.", se.SchoolName, se.SemesterNavn);
Console.WriteLine("-------------------------------------------------");