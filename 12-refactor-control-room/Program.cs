using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

List<string> beacons = new List<string>();

  static void PrintMenu()
    {
    Console.WriteLine();
    Console.WriteLine("1 - Add beacon");
    Console.WriteLine("2 - Remove beacon");
    Console.WriteLine("3 - List beacons");
    Console.WriteLine("4 - Quit");
    Console.Write("Choice: ");
    }
    static void AddBeacon(List<string> beacons)
    {   
        Console.Write("Beacon name: ");
        string? name = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(name))
        {
            beacons.Add(name);
            Console.WriteLine("Beacon added.");
        }
    }
    static void RemoveBeacon(List<string> beacons)
    {   Console.Write("Beacon name: ");
        string? name = Console.ReadLine();
        if (name is not null && beacons.Remove(name))
       {
        Console.WriteLine("Beacon removed.");
       } else
       {
        Console.WriteLine("Beacon not found.");
       }
    }
    static void PrintBeacons(List<string> beacons)
    {if (beacons.Count == 0)
        {
            Console.WriteLine("No beacons registered.");
        }
        else
        {
            foreach (string beacon in beacons)
            {
                Console.WriteLine($"- {beacon}");
            }
        }
    }
    static void Quit()
    {
        Console.WriteLine("Terminating session.");
    }

while (true)
{
    PrintMenu();
    string? choice = Console.ReadLine();

    if (choice == "1")
    {
        AddBeacon(beacons);
    }
    else if (choice == "2")
    {
        RemoveBeacon(beacons);
    }
    else if (choice == "3")
    {
        PrintBeacons(beacons);
    }
    else if (choice == "4")
    {
        Quit();
        break;
    }
    else
    {
        Console.WriteLine("Unknown choice.");
    }

}

// TODO: Refaktorer den fungerende koden over til flere metoder.
