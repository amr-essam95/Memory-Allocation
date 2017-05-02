using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryAllocation
{
    public partial class Memory : Form
    {
        Form mainform;
        public Memory()
        {
            InitializeComponent();
        }
        public void setForm(Form f)
        {
            mainform = f;
        }
    }
}
