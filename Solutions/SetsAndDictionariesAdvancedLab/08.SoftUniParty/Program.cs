using System.Text.RegularExpressions;

var vips = new HashSet<string>();
var regulars = new HashSet<string>();

string input = Console.ReadLine();

while(input != "PARTY")
{
    if(new Regex("[0-9]").IsMatch(input[0].ToString()))
    {
        vips.Add(input);
    }
    else
    {
        regulars.Add(input);
    }
    input = Console.ReadLine();
}

input = Console.ReadLine();
while(input != "END")
{
    if (vips.Contains(input))
    {
        vips.Remove(input);
    }

    if(regulars.Contains(input) )
    {
        regulars.Remove(input);
    }
    input = Console.ReadLine();
}

Console.WriteLine(vips.Count + regulars.Count);
foreach (var vip in vips)
{
    Console.WriteLine(vip);
}

foreach (var regular in regulars)
{
    Console.WriteLine(regular);
}