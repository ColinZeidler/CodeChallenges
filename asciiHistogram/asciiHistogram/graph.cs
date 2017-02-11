using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asciiHistogram
{
    class Graph
    {
        private int[,] table;
        private int[] bounds; // xStart, xEnd, yStart, yEnd
        private int entryCount;

        public Graph(int[] bounds, int entries)
        {
            this.table = new int[entries, 3];
            this.bounds = bounds;
            this.entryCount = 0;
        }

        public void addEntry(int xStart, int xEnd, int count)
        {
            this.table[entryCount, 0] = xStart;
            this.table[entryCount, 1] = xEnd;
            this.table[entryCount, 2] = count;
            this.entryCount++;
        }

        public void printGraph()
        {
            int columnWidth = 1;

            for (int i = this.bounds[3]; i > this.bounds[2]-1; i--)
            {
                Console.Write(i);
                // Write all columns out
                Console.Write("\n");
            }
            Console.Write(" "); //TODO space is width of y axis digits
            for (int i = 0; i < this.entryCount; i++)
            {
                Console.Write(this.table[i, 0]);
                Console.Write(" ");
            }
            Console.WriteLine(this.table[entryCount - 1, 1]);
        }
    }
}
