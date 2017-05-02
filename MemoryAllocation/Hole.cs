using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryAllocation
{
    class Hole
    {
        LinkedList<Process> processes = new LinkedList<Process>();
        int startingAddress;
        int Size;
        int number;
        TextBox box = new TextBox();

        public Hole(int num,int starting ,int size)
        {
            startingAddress = starting;
            Size = size;
            number = num;
            box.Size = new Size(size, 50);
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
