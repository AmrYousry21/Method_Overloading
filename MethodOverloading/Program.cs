using System;

namespace MethodOverloading // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods program = new Methods();

            Console.WriteLine(program.Add(5, 2));
            Console.WriteLine(program.Add(6.7, 3.5));
            Console.WriteLine(program.Add(0, 1, true));
        }
    }
}
