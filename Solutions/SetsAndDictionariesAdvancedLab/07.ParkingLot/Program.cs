var parking = new HashSet<string>();

string input = Console.ReadLine();

while(input != "END")
{
    string[] cmdArgs = input.Split(", ");
    string cmd = cmdArgs[0];
    string number = cmdArgs[1];

    if(cmd == "IN")
    {
        parking.Add(number);
    }
    else if (cmd == "OUT")
    {
        parking.Remove(number);
    }
    input = Console.ReadLine();
}

if(parking.Count == 0)
{
    Console.WriteLine($"Parking Lot is Empty");
}
else
{
    foreach (var item in parking)
    {
        Console.WriteLine(item);
    }
}