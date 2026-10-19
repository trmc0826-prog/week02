List<string> crew = new List<string> { "Bex", "Ivo", "Nia" };

crew.Add("Mira");
crew.Add("Sol");
crew.Remove("Bex");

Console.WriteLine($"Crew count: {crew.Count}");

foreach (string member in crew)
{
    Console.WriteLine($"Crewmember: {member}");
}


// TODO: Skriv alle navn med en løkke.
// TODO: Endre listen etter instruksjonene.
