using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryAllocation
{
    class Process
    {
        private String number;
        private int size;
        private TextBox box;
        public Process(string num,int s)
        {
            number = num;
            size = s;
        }
        public void setSize(int s)
        {
            size = s;
        }
        public int getSize()
        {
            return size;
        }
        public String getNumber()
        {
            return number;
        }
    }
}
