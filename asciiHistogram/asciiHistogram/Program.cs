using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asciiHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] graphbounds;
            int lineCount, count;
            Console.Write("> ");
            string input = Console.ReadLine();

            graphbounds = new int[4];
            count = 0;
            foreach (string item in input.Split())
            {
                graphbounds[count] = int.Parse(item);
                count++;
            }

            foreach (int item in graphbounds)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.Write("\n");

            input = Console.ReadLine();
            lineCount = int.Parse(input);
        }
    }
}
