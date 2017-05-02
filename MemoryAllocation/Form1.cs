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
    public partial class Form1 : Form
    {
        Memory memory = new Memory();
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            memory.setForm(this);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            //for (int i = 0; i < 5; i++)
            //{
            //    Point newLoc = new Point(5, 5+i*50);
            //    Button x = new Button();
            //    x.Text = i.ToString();
            //    x.Size = new Size(100,50);
            //    x.Location = newLoc ;
            //    var margin = x.Margin;
            //    margin.Bottom = -10;
            //    margin.Left = 0;
            //    margin.Right = 0;
            //    margin.Top = -10;
            //    x.Margin = margin;
            //    x.Padding = new Padding(0, -10, 0, -10);
            //    //x.Dock = DockStyle.Fill;
            //    x.Margin = new Padding(0);
            //    x.AutoSize = true;

            //    this.Controls.Add(x);
            //}

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
