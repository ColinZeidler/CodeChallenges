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

            for (int row = this.bounds[3]; row > this.bounds[2]-1; row--)
            {
                Console.Write(row);
                // Write all columns out
                for (int j = 0; j < this.entryCount; j++) {
                    int temp = this.table[j, 0];

                    //width of x axis label
                    int columnWidth = 0;
                    do
                    {
                        columnWidth++;
                        temp = temp / 10;
                    } while (temp != 0);
                    for (int space = 0; space < columnWidth; space++)
                    {
                        Console.Write(" ");
                    }


                    if (this.table[j, 2] >= row)
                    {
                        Console.Write("*");
                    } else
                    {
                        Console.Write(" ");
                    }
                }
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
