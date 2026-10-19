
while (true)
{
    Console.Write("Command: ");
    string? command = Console.ReadLine();

    if (command == "EXIT" || command == null)
    {
        break;
    }
    else
    {
        Console.WriteLine($"Received: {command}");
    }

    // TODO: Avslutt med break når command er EXIT eller null.
    // TODO: Ellers skriv Received: <command>.
}

Console.WriteLine("Receiver stopped.");
