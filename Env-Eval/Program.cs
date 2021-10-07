using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace Env_Eval
{
    class Program
    {
        static int Main(string[] args)
        {
            var types = Assembly
                .GetEntryAssembly()
                ?.GetTypes()
                .Where(p => typeof(IAnswer).IsAssignableFrom(p) && !p.IsInterface)
                .ToList();

            if (types is null)
            {
                return 1;
            }

            foreach (var t in types)
            {
                Console.WriteLine($"Running {t.Name}:");
                
                var ans = Activator.CreateInstance(t) as IAnswer;

                if (ans is null)
                {
                    continue;
                }
                
                Console.WriteLine("Beginning Part 1:");
                ans.Part1();
                
                Console.WriteLine("Beginning Part 2:");
                ans.Part2();
            }

            return 0;
        }
    }
}