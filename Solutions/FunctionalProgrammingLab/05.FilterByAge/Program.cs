int n = int.Parse(Console.ReadLine());

List<Person> people = new List<Person>();

for (int i = 0; i < n; i++)
{
    string[] cmdArgs = Console.ReadLine().Split(", ");
    people.Add(new Person(cmdArgs[0], int.Parse(cmdArgs[1])));
}

string olderFrom = Console.ReadLine();
int ageFrom = int.Parse(Console.ReadLine());

Func<Person, int, bool> filter = MeetsCondition(olderFrom);

people = people.Where(x => filter(x, ageFrom)).ToList();



Action<Person> formatter = GetFormat(Console.ReadLine());

foreach (var person in people)
{
    formatter(person);
}

Func<Person, int, bool> MeetsCondition(string condition)
{
    if(condition == "younger")
    {
        Func<Person, int, bool> result = (p, value) => p.age < value;
        return result;
    }
    else if(condition == "older")
    {
        Func<Person, int, bool> result = (p, value) => p.age >= value;
        return result;
    }
    return null;
}

Action<Person> GetFormat(string formatType)
{
    if(formatType == "name age")
    {
        return p => Console.WriteLine($"{p.name} - {p.age}");
    }

    if(formatType == "age")
    {
        return p => Console.WriteLine($"{p.age}");
    }

    if (formatType == "name")
    {
        return p => Console.WriteLine($"{p.name}");
    }

    return null;
}

public class Person
{
    public string name { get; set; } 
    public int age { get; set; }
    public Person (string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}