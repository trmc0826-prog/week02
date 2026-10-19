Console.WriteLine(FormatSignal("moon-base"));
Console.WriteLine(FormatSignal("relay-7"));
Console.WriteLine(FormatSignal("cargo-deck"));

static string FormatSignal(string source)
{
    string upperSource = source.ToUpper();
    return $"[SIGNAL FROM: {upperSource}]";
}


 // TODO: Returner formatert string.