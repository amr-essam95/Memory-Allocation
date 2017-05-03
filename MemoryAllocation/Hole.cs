using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryAllocation
{
    public class Hole
    {
        LinkedList<Process> processes = new LinkedList<Process>();
        int startingAddress;
        int Size;
        int number;
        int freeSpace = 0;
        int smallestFreeSpace = 0;
        

        public Hole(int num,int starting ,int size)
        {
            startingAddress = starting;
            Size = size;
            number = num;
            smallestFreeSpace = size;
            freeSpace = size;
            if(num<0)
            {
                Process tempReserved = new Process("reserved", size);
                tempReserved.setStarting(starting);
                processes.AddFirst(tempReserved);
                freeSpace = 0;
                return;
            }
            Process temp = new Process("free", size);
            temp.setStarting(starting);
            processes.AddFirst(temp);
            freeSpace = size;   // holds the size of the largest contiguous space
        }
        public int getSize()
        {
            return Size;
        }
        public LinkedList<Process> getProcesses()
        {
            return processes;
        }
        public int getSpace()
        {
            return freeSpace;
        }
        public void setFreeSpace(int s)
        {
            freeSpace = s;
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
        public bool placeFirstFit(Process p)
        {
            List<Process> SortedList = processes.OrderBy(o => o.getStarting()).ToList();
            foreach (var process in SortedList)
            {
                if(process.getNumber().Equals("free") && process.getSize() >= p.getSize())
                {
                    p.setStarting(process.getStarting());
                    int difference = process.getSize() - p.getSize();
                    p.setHole(this);
                    processes.AddFirst(p);
                    if (difference > 0)
                    {
                        Process temp = new Process("free", difference);
                        temp.setStarting(process.getStarting() + p.getSize());
                        processes.AddFirst(temp);
                    }
                    processes.Remove(process);
                    updateFreeSpace();
                    updateSamllestFreeSpace();
                    return true;
                }
            }
            updateFreeSpace();
            updateSamllestFreeSpace();
            return false;
        }
        public int getSmallestSpace()
        {
            return smallestFreeSpace;
        }
        public bool placeBestFit(Process p)
        {
            List<Process> SortedList = processes.OrderBy(o => o.getSize()).ToList();
            SortedList.Sort(delegate (Process c1, Process c2) {
                if (c1.getSize() == c2.getSize())
                    return c1.getStarting().CompareTo(c2.getStarting());
                return c1.getSize().CompareTo(c2.getSize());
                });
            foreach (var process in SortedList)
            {
                if (process.getNumber().Equals("free") && process.getSize() >= p.getSize())
                {
                    p.setStarting(process.getStarting());
                    int difference = process.getSize() - p.getSize();
                    p.setHole(this);
                    processes.AddFirst(p);
                    if (difference > 0)
                    {
                        Process temp = new Process("free", difference);
                        temp.setStarting(p.getStarting() + p.getSize());
                        processes.AddFirst(temp);
                    }
                    processes.Remove(process);
                    updateFreeSpace();
                    updateSamllestFreeSpace();
                    return true;
                }
            }
            updateFreeSpace();
            updateSamllestFreeSpace();
            return false;
        }
        private void updateFreeSpace()
        {
            List<Process> SortedList = processes.OrderByDescending(o => o.getSize()).ToList();
            foreach (var Process in processes)
            {
                if(Process.getNumber().Equals("free"))
                {
                    freeSpace = Process.getSize();
                    return;
                }
            }
            freeSpace = 0;
        }
        private void updateSamllestFreeSpace()
        {
            List<Process> SortedList = processes.OrderBy(o => o.getSize()).ToList();
            foreach (var Process in processes)
            {
                if (Process.getNumber().Equals("free"))
                {
                    smallestFreeSpace = Process.getSize();
                    return;
                }
            }
            freeSpace = 0;
        }
    }

}
