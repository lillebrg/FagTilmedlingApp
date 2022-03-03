

SchoolingCategory school = new();
List<TECPerson> persons = new();

Course c = new(school);

while (true)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Vælg UddannelsesLinje");
    Console.WriteLine("1: Programmering");
    Console.WriteLine("2: Support");
    Console.WriteLine("3: Infrastruktur");

    Console.WriteLine("vælg 1, 2 eller 3");

    var choice = Console.ReadKey();

    switch (choice.Key)
    {
        case ConsoleKey.D1:
            c.SchoolingName = SchoolingCategory.Programmeringslinje;
            c.SetCourses();
            break;
        case ConsoleKey.D2:
            c.SchoolingName = SchoolingCategory.Supportlinje;
            c.SetCourses();
            break;
        case ConsoleKey.D3:
            c.SchoolingName = SchoolingCategory.Infrastrukturlinje;
            c.SetCourses();
            break;
        default:
            Console.Clear();
            Console.WriteLine("Det skrevet svar er forkert prøv igen. Tryk enter for og forsætte.");
            Console.ReadKey();
            break;
    }

    Console.Clear();

    if (choice.Key == ConsoleKey.D1 || choice.Key == ConsoleKey.D2 || choice.Key == ConsoleKey.D3)
    {
        Console.WriteLine($"{c.ToString()}");
        Console.WriteLine("------------------------------------");

        if (c.SchoolingName == SchoolingCategory.Programmeringslinje)
        {
            Console.Write("Af alle uddannelseslinjer har vi ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Programmering");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" med de følgene fag:");
        }
        else if (c.SchoolingName == SchoolingCategory.Supportlinje)
        {
            Console.Write("Af alle uddannelseslinjer har vi ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Support");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" med de følgene fag:");
        }
        else
        {
            Console.Write("Af alle uddannelseslinjer har vi ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Infrastruktur");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" med de følgene fag:");
        }

        Console.WriteLine("------------------------------------");

        foreach (string temp in c.Courses)
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (c.SchoolingName == SchoolingCategory.Programmeringslinje && temp.Contains("programmering"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{temp}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (c.SchoolingName == SchoolingCategory.Supportlinje && temp.Contains("server"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{temp}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (c.SchoolingName == SchoolingCategory.Infrastrukturlinje && temp.Contains("netværk"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{temp}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{temp}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        Console.WriteLine("------------------------------------");

        Console.WriteLine("Lærer:");

        c.Teachers.Sort();
        foreach (var item in c.Teachers)
        {
            if (c.SchoolingName == item.UddannelsesLinje)
            {
                if (item.FullName == "Niels Olsen")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{item.FullName}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (item.FullName == "Bo Hansen")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{item.FullName}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{item.FullName}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{item.FullName}");
            }
        }

        Console.ReadKey();
    }
    Console.Clear();
}