
string transmission = "AX?19??Q";
int markerCount = 0;


for (int i = 0; i < transmission.Length; i++)
{
    if (transmission[i] == '?')
    {
        markerCount ++;
        Console.WriteLine($"Marker location: {i}");
    }

}
// TODO: Bruk for og transmission[i].

Console.WriteLine($"Marker count: {markerCount}");
