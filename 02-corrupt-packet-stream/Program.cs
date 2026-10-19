string[] packets = { "P-100", "CORRUPT", "P-101", "P-102", "CORRUPT", "P-103" };
int processedCount = 0;
int ErrorCount = 0;

foreach (string packet in packets)
{
    if (packet == "CORRUPT")
    {
        ErrorCount ++;
        continue;
    }
    else
    {
        processedCount ++;
        Console.WriteLine($"Processed: {packet}");
    }

}

Console.WriteLine($"Errors found: {ErrorCount}");
Console.WriteLine($"Processed packets: {processedCount}");







    // TODO: Bruk continue for CORRUPT.
    // TODO: Prosesser resten og øk processedCount.