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
            Console.WriteLine("Enter graph bounds");
            string input = Console.ReadLine();

            graphbounds = new int[4];
            count = 0;
            foreach (string item in input.Split())
            {
                graphbounds[count] = int.Parse(item);
                count++;
            }
            Console.WriteLine("Enter entry count");
            input = Console.ReadLine();
            lineCount = int.Parse(input);

            Graph myGraph = new Graph(graphbounds, lineCount);

            Console.WriteLine("Enter all entry lines");
            for (int i=0; i < lineCount; i++)
            {
                input = Console.ReadLine();
                int[] data = new int[3];
                count = 0;
                foreach (string item in input.Split())
                {
                    data[count] = int.Parse(item);
                    count++;
                }

                myGraph.addEntry(data[0], data[1], data[2]);
            }


            Console.ReadLine(); //just hanging around so I can view output
        }
    }
}
