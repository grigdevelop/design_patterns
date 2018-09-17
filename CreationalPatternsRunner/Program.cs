using CreationalPatterns;
using System;
using System.Linq;
using System.Reflection;

namespace CreationalPatternsRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureRunners();
            Console.Read();
        }

        static void ConfigureRunners()
        {
            var interfaces = typeof(IRunner).Assembly.GetTypes().Where(x => x.GetInterfaces().Any(i => i == typeof(IRunner)))
                .ToList();
            interfaces.ForEach(r =>
            {
                var runnerAttr = r.GetCustomAttribute<RunnerAttribute>();
                if (runnerAttr != null && runnerAttr.Ignore)
                {
                    // do something
                }
                else
                {
                    var instance = Activator.CreateInstance(r) as IRunner;
                    instance?.Run();
                }

            });
        }

    }
}
