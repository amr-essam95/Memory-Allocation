using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryAllocation
{
    class Hole
    {
        LinkedList<Process> processes = new LinkedList<Process>();
        int startingAddress;
        int Size;
        int number;

        public Hole(int num,int starting ,int size)
        {
            startingAddress = starting;
            Size = size;
            number = num;
        }
        public int getSize()
        {
            return Size;
        }
        public int getNumber()
        {
            return number;
        }
        public void setNumber(int num)
        {
            number = num;
        }
        public int getStarting()
        {
            return startingAddress;
        }
        public void setSize(int size)
        {
            Size = size;
        }
        public void setStarting(int start)
        {
            startingAddress = start;
        }
    }
}
