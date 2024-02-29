using Studenten;


// 2 en 3
var studentDictionary = new SortedDictionary<int, Student>
{
    {156, new Student { Studentnummer = 156, Name = "Julie Kraanen", Geboortedatum = new DateOnly(2006, 7, 18) }},
    {234, new Student { Studentnummer = 234, Name = "Toei Praw", Geboortedatum = new DateOnly(2004, 8, 23) }},
    {32, new Student { Studentnummer = 32, Name = "Bert Degenhart", Geboortedatum = new DateOnly(2000, 10, 1) }},
    {11, new Student { Studentnummer = 11, Name = "Sofyan Lamrini", Geboortedatum = new DateOnly(2005, 4, 3) }},
    {203, new Student { Studentnummer = 203, Name = "Malik Doe", Geboortedatum = new DateOnly(2000, 6, 19) }},
    {109, new Student { Studentnummer = 109, Name = "Jane Jojo", Geboortedatum = new DateOnly(2003, 8, 12) }},
    {323, new Student { Studentnummer = 323, Name = "Mario Kart", Geboortedatum = new DateOnly(2001, 7, 30) }},
    {42, new Student { Studentnummer = 42, Name = "Luigi Kart", Geboortedatum = new DateOnly(2006, 9, 24) }},
    {212, new Student { Studentnummer = 212, Name = "Toad Kart", Geboortedatum = new DateOnly(2005, 4, 2) }},
    {311, new Student { Studentnummer = 311, Name = "Yoshi Boo", Geboortedatum = new DateOnly(2003, 8, 27) }},
};

// 4 en 5
Console.WriteLine("Voer een studentnummer in: \n");
if (int.TryParse(Console.ReadLine(), out int FindStudent))
{
    if (studentDictionary.TryGetValue(FindStudent, out var found))
    {
        Console.WriteLine($"Student: {found.Name} - {found.Studentnummer} - {found.Geboortedatum}\n");
    }
    else
    {
        Console.WriteLine($"Student met studentnummer {FindStudent} niet gevonden.\n");
    }
}
else
{
    Console.WriteLine("Ongeldige studentnummer.\n");
}

// 6
Console.WriteLine("Studentennummers:\n");
foreach (var student in studentDictionary)
{
    Console.WriteLine(student.Value.Studentnummer);
}
Console.WriteLine("\n");

// 7
Console.WriteLine("Studenten namen:\n");
foreach (var student in studentDictionary)
{
    Console.WriteLine(student.Value.Name);
}
Console.WriteLine("\n");

// 8
Console.WriteLine("Studentennummers en namen:\n");
foreach (var student in studentDictionary)
{
    Console.WriteLine($"{student.Value.Studentnummer} - {student.Value.Name}");
}
Console.WriteLine("\n");

//9
var oudsteStudent = studentDictionary.Values.OrderBy(student => student.Geboortedatum).First();
Console.WriteLine($"Oudste student: {oudsteStudent.Name} - {oudsteStudent.Studentnummer} - {oudsteStudent.Geboortedatum}\n");

// 10
var gesorteerdeleeftijd = studentDictionary.Values.OrderBy(student => student.Geboortedatum).ToList();

Console.WriteLine("Studenten gesorteerd op leeftijd:\n");
foreach (var student in gesorteerdeleeftijd)
{
    Console.WriteLine($"{student.Name} - {student.Studentnummer} - {student.Geboortedatum}");
}
Console.WriteLine("\n");