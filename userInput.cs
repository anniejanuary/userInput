using System;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); //console awaits input with a flashing underscore. I write sth and enter
            Console.WriteLine(input); //console replies with what i wrote as input. 
            Console.Read();
        }
    }
}
