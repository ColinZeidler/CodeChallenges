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
        private int[] bounds;
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

        }
    }
}
