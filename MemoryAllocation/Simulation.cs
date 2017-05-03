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
        int y_point = 20;
        public Simulation()
        {
            InitializeComponent();
            initializeList();
            comboBox1.SelectedIndex = 0;
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
                    return;
                }

                drawMemory();  
            }
            else
            {
                int removed;
                try
                {
                    removed = Convert.ToInt32(number.Text.ToString());
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number");
                    return;
                }
                memory.deallocate(removed);
                drawMemory();
            }
        }
        public void drawMemory()
        {
            LinkedList<Hole> holes = memory.getHoles();
            List<Hole> SortedList = holes.OrderBy(o => o.getStarting()).ToList();
            int x_point = 20;
            foreach (var hole in SortedList)
            {
                LinkedList<Process> processes = hole.getProcesses();
                List<Process> SortedProcesses = processes.OrderBy(o => o.getStarting()).ToList();
                foreach (var process in SortedProcesses)
                {
                    Point newLoc = new Point(x_point, y_point);
                    Button temp = new Button();
                    temp.Text = process.getNumber();
                    temp.Size = new Size(process.getSize(), 50);
                    temp.Location = newLoc;
                    if (process.getNumber() .Equals("Reserved"))
                        temp.Enabled = false;
                    Label label1 = new Label();
                    label1.Text = (process.getStarting()).ToString();
                    label1.Font = new Font("Arial", 6);
                    label1.Location = new Point(x_point-5,y_point+60);
                    Label label2 = new Label();
                    label2.Text = (process.getStarting() + process.getSize()).ToString();
                    label2.Font = new Font("Arial", 6);
                    label2.Location = new Point(x_point+process.getSize()-5, y_point+60);
                    memoryPanel.Controls.Add(temp);
                    memoryPanel.Controls.Add(label1);
                    memoryPanel.Controls.Add(label2);
                    x_point += process.getSize();
                }
            }
            y_point += 100;
        }
    }
}
