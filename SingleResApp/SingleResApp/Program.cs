using System;
using SingleResApp.Lib;

namespace SingleResApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine machine = new VendingMachine();

            Console.WriteLine(machine.Start());
            Console.WriteLine(machine.Stop());
        }
    }
}
