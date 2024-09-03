using System.Text.Json.Serialization;

Console.WriteLine("Hur lång är du?");
string längd = Console.ReadLine();

int längdInt = 0;

int.TryParse(längd, out längdInt);

if (längdInt < 160)
{
Console.WriteLine("Du är kort");
}
else 
Console.WriteLine("du är lång");