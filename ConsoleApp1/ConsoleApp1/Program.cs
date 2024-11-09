using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting....");
            Program app = new Program();
        }

        public Program()
        {
            Console.WriteLine("In constructor and out of static context");
        }
    }
}
