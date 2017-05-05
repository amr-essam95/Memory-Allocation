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
        List<string> ss = new List<string>();
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
        public void UpdateList(LinkedList<Process> x)
        {
            list.Items.Clear();
            for (LinkedListNode<Process> temp = x.First; temp != null; temp = temp.Next)
            {
                String[] row = { temp.Value.getNumber(), temp.Value.getSize().ToString() };
                var listItemView = new ListViewItem(row);
                list.Items.Add(listItemView);
            }
        }

        private void Simulation_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            mainform.Show();
            memory.clear();
            mainform.Close();
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
                if(ss.Contains(number.Text))
                {
                    MessageBox.Show("There is a process with this number.");
                    return;
                }
                ss.Add(number.Text);
                Process temp = new Process(number.Text,s);
                memory.addProcess(temp);
                //String[] row = { temp.getNumber(),temp.getSize().ToString() };
                //var listItemView = new ListViewItem(row);
                //list.Items.Add(listItemView);
                UpdateList(memory.getProcesses());
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
                ss.Remove(number.Text);
                UpdateList(memory.getProcesses());
                drawMemory();
            }
        }
        public void drawMemory()
        {
            LinkedList<Hole> holes = memory.getHoles();
            List<Hole> SortedList = holes.OrderBy(o => o.getStarting()).ToList();
            int x_point = 40;
            int var = 1;
            foreach (var hole in SortedList)
            {
                LinkedList<Process> processes = hole.getProcesses();
                List<Process> SortedProcesses = processes.OrderBy(o => o.getStarting()).ToList();
                foreach (var process in SortedProcesses)
                {
                    Point newLoc = new Point(x_point, y_point);
                    Button temp = new Button();
                    temp.Text = process.getNumber();
                    temp.Size = new Size(process.getSize()*var, 30);
                    temp.Location = newLoc;
                    if (process.getNumber() .Equals("Reserved"))
                        temp.Enabled = false;
                    Label label1 = new Label();
                    label1.Text = (process.getStarting()).ToString();
                    label1.Font = new Font("Arial", 6);
                    label1.BorderStyle = BorderStyle.None;
                    label1.Margin = new Padding(0,0,0,0);
                    label1.MaximumSize = new Size(30, 20);
                    label1.Location = new Point(x_point-5,y_point+40);
                    Label label2 = new Label();
                    label2.Text = (process.getStarting() + process.getSize()).ToString();
                    label2.Font = new Font("Arial", 6);
                    label2.BorderStyle = BorderStyle.None;
                    label2.MaximumSize = new Size(30, 20);
                    label2.Margin = new Padding(0, 0, 0, 0);
                    label2.Location = new Point(x_point+process.getSize()*var-5, y_point+40);
                    memoryPanel.Controls.Add(temp);
                    memoryPanel.Controls.Add(label1);
                    memoryPanel.Controls.Add(label2);
                    x_point += process.getSize()*var;
                }
            }
            y_point += 80;
            memoryPanel.MaximumSize = new Size(10000,10000);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            list.Items.Clear();
            mainform.Show();
        }

        private void compact_Click(object sender, EventArgs e)
        {
            memory.compact();
            drawMemory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            memory.compact();
            drawMemory();
        }
    }
}
