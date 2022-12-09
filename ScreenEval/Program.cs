using System;
using System.Linq;
using System.Reflection;
using ScreenEval;

var types = Assembly
    .GetEntryAssembly()
    ?.GetTypes()
    .Where(p => typeof(IAnswer).IsAssignableFrom(p) && !p.IsInterface)
    .ToList();

if (types is null)
{
    Console.WriteLine("No answers found");
    return;
}

foreach (var t in types)
{
    Console.WriteLine($"Running {t.Name}:");

    if (Activator.CreateInstance(t) is not IAnswer ans)
    {
        continue;
    }
                
    Console.WriteLine("Beginning Part 1:");
    ans.Part1();
                
    Console.WriteLine("Beginning Part 2:");
    ans.Part2();
}