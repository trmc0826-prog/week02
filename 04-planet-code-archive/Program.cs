string[] planetCodes = { "ORION-4", "KAPPA-9", "LYRA-2", "NOVA-7", "VEGA-3" };
bool found = false;

foreach (string planet in planetCodes)
{
    if (planet == "KAPPA-9")
   {
    found = true;
    break;
   }
}

Console.WriteLine($"First Planet{planetCodes[0]}");
Console.WriteLine($"Last planet: {planetCodes[planetCodes.Length - 1]}");
Console.WriteLine($"total Planets: {planetCodes.Length}");
Console.WriteLine($"Found KAPPA-9: {found}");








// TODO: Skriv Length, første og siste element.
// TODO: Finn KAPPA-9 med en løkke.