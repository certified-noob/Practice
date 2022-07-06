using System;

namespace PracticeConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {

            long[] inputs = {2147483647,328,5,16,124,9,11,19,42,328,20,561892,6291457,1073741825,1610612737};

            var t = new BinaryGap();

            
                System.Console.WriteLine("{0}", t.Solution(20));
        }
    }
}
