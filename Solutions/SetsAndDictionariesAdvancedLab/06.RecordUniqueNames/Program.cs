﻿var names = new HashSet<string>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    names.Add(Console.ReadLine());
}

foreach (var name in names)
{
    Console.WriteLine(name);
}