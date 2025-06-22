using System;

namespace BuilderPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var basicComputer = new Computer.Builder()
                .SetCPU("Intel i5")
                .SetRAM("8GB")
                .SetStorage("256GB SSD")
                .Build();

            Console.WriteLine("Basic Computer:");
            Console.WriteLine(basicComputer);
            Console.WriteLine();

            var gamingComputer = new Computer.Builder()
                .SetCPU("Intel i9")
                .SetRAM("32GB")
                .SetStorage("1TB NVMe SSD")
                .SetGPU("NVIDIA RTX 4080")
                .Build();

            Console.WriteLine("Gaming Computer:");
            Console.WriteLine(gamingComputer);
        }
    }
}
