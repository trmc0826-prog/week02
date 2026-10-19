List<string> specimens = new List<string>();

while (true)
{
    Console.Write("Command (ADD/REMOVE/LIST/COUNT/QUIT): ");
    string? command = Console.ReadLine();

    if (command == "ADD")
  {
    Console.Write("Specimen name: ");
    string? name = Console.ReadLine();
    if (name != null)
    {
         specimens.Add(name);
    }
  }

 else if (command == "REMOVE")
  {
    Console.WriteLine("Specimen name:");
    string? name = Console.ReadLine();
    if (name != null)
    {
        specimens.Remove(name);
    }
  }
else if (command == "LIST")
{
    foreach (var item in specimens)
    {
        Console.WriteLine($"Specimen: {item}");
    }
}
else if (command == "COUNT")
{
    Console.WriteLine($"Specimens count: {specimens.Count}");
}
    else if (command == "QUIT")
    {
        break;
    }
else
{
    Console.WriteLine("Invalid Command");
}
}



  // TODO: Implementer kommandoene.
    // Tips: specimens må IKKE opprettes på nytt inne i løkken.