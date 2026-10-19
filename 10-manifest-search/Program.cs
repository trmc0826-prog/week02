List<string> manifest = new List<string> { "LENS", "BATTERY", "FILTER", "CABLE" };

Console.WriteLine(ContainsItem(manifest, "FILTER"));
Console.WriteLine(ContainsItem(manifest, "WRENCH"));

static bool ContainsItem(List<string> items, string search)
{
    foreach (string item in items)
    {
        if (search == item)
        {
            return true;
        }
    }
    return false;
}
