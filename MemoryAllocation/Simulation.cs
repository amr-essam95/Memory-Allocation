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
    public partial class Simulation : Form
    {
        Form mainform;
        Memory memory;
        int x_point = 0;
        public Simulation()
        {
            InitializeComponent();
            initializeList();
            comboBox1.SelectedIndex = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Point newLoc = new Point(i*50,100);
            //    TextBox x = new TextBox();
            //    x.Text = i.ToString();
            //    x.Size = new Size(50, 100);
            //    x.Location = newLoc;
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
        public void setForm(Form f)
        {
            mainform = f;
        }
        public void setMemory(Memory x)
        {
            memory = x;
        }
        private void initializeList()
        {
            list.Columns.Add("Process Number", -2);
            list.Columns.Add("Size", -2);
        }

        private void Simulation_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            mainform.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Allocation"))
            {
                allocate.Text = "Allocate";
                size.Show();
                labelSize.Show();
            }
            else
            {
                allocate.Text = "Deallocate";
                size.Hide();
                labelSize.Hide();
            }
               
        }

        private void allocate_Click(object sender, EventArgs e)
        {
            if(allocate.Text == "Allocate")
            {
                // Case of allocation
                int s;
                try
                {
                    s = Convert.ToInt32(size.Text.ToString());
                }
                catch
                {
                    MessageBox.Show("Please enter a valid size");
                    return;
                }
                Process temp = new Process(number.Text,s);
                memory.addProcess(temp);
                String[] row = { temp.getNumber(),temp.getSize().ToString() };
                var listItemView = new ListViewItem(row);
                list.Items.Add(listItemView);
                bool valid;
                if(memory.getAlgorithm().Equals("First Fit"))
                {
                    valid = memory.firstFit(temp);
                }
                else
                {
                    valid = memory.bestFit(temp);
                }
                if(!valid)
                {
                    MessageBox.Show("This process is in the waiting queue.\nAfter process is deallocated it'll be allocated");
                }

                drawMemory();  
            }
            else
            {
                // case of deallocation
            }
        }
        private void drawMemory()
        {
            LinkedList<Hole> holes = memory.getHoles();
            List<Hole> SortedList = holes.OrderBy(o => o.getStarting()).ToList();
            x_point += 200;
            int y_point = 50;
            foreach (var hole in SortedList)
            {
                LinkedList<Process> processes = hole.getProcesses();
                List<Process> SortedProcesses = processes.OrderBy(o => o.getStarting()).ToList();
                foreach(var process in SortedProcesses)
                {
                    Point newLoc = new Point(x_point, y_point);
                    Button temp = new Button();
                    temp.Text = process.getNumber();
                    temp.Size = new Size(100, process.getSize());
                    temp.Location = newLoc;
                    memoryPanel.Controls.Add(temp);
                    y_point += process.getSize();
                }
                
                //    Point newLoc = new Point(i*50,100);
                //    TextBox x = new TextBox();
                //    x.Text = i.ToString();
                //    x.Size = new Size(50, 100);
                //    x.Location = newLoc;
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
        }
    }
}
