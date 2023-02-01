int n = int.Parse(Console.ReadLine());

var students = new Dictionary<string, List<decimal>>();

for(int i = 0;i < n; i++)
{
    string[] cmdArgs = Console.ReadLine().Split();
    string name = cmdArgs[0];
    decimal grade = decimal.Parse(cmdArgs[1]);
    if (students.ContainsKey(cmdArgs[0]))
    {
        students[cmdArgs[0]].Add(grade);
        continue;
    }

    students.Add(name, new List<decimal>() { grade });
}

foreach (var student in students)
{
    List<string> formatedGrades = student.Value.Select(x => x.ToString("0.00")).ToList();
    Console.WriteLine($"{student.Key} -> {String.Join(" ", formatedGrades)} (avg: {student.Value.Average():f2})");
}