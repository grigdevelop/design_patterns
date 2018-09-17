using System;

namespace CreationalPatterns
{
    public interface IRunner
    {
        void Run();
    }

    public class RunnerAttribute : Attribute
    {
        public bool Ignore { get; set; }
    }
}
