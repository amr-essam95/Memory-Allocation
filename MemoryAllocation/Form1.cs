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
        Simulation sim ;
        Memory memory = new Memory();
        int numberOfHoles = 0;
        public Form1()
        {
            InitializeComponent();
            initializeList();
            comboBox1.SelectedIndex = 1;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            compact.SelectedIndex = 0;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }
        private void initializeList()
        { 
            list.Columns.Add("Hole Number", -2);
            list.Columns.Add("Starting Address", -2);
            list.Columns.Add("Size", -2);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public ListView getList()
        {
            return list;
        }
        public void UpdateList(LinkedList<Hole> x)
        {
            list.Items.Clear();
            for (LinkedListNode<Hole> temp = x.First; temp != null; temp = temp.Next)
            {
                if (temp.Value.getNumber() >= 0)
                {
                    String[] row = { temp.Value.getNumber().ToString(), temp.Value.getStarting().ToString(), temp.Value.getSize().ToString() };
                    var listItemView = new ListViewItem(row);
                    list.Items.Add(listItemView);
                }
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addHole_Click(object sender, EventArgs e)
        {
            int starting,sizeOfHole;
            try
            {
                starting = Convert.ToInt32(startingAdd.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid starting address");
                return;
            }
            try
            {
                sizeOfHole = Convert.ToInt32(size.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid Size");
                return;
            }
            numberOfHoles++;
            Hole tempHole = new Hole(numberOfHoles,starting, sizeOfHole);
            bool valid = memory.checkValidity(tempHole);
            if(!valid)
            {
                MessageBox.Show("Not valid Hole");
                return;
            }
            Hole adjacent = memory.checkAdjacency(tempHole);
            if (adjacent !=null)
            {
                //String[] row = { adjacent.getNumber().ToString(), adjacent.getStarting().ToString(), adjacent.getSize().ToString() };
                //var listItemView = new ListViewItem(row);
                //list.Items.Add(listItemView);
                UpdateList(memory.getHoles());
            }
            else
            {
                memory.addHole(tempHole);
                //String[] row = { numberOfHoles.ToString(), starting.ToString(), sizeOfHole.ToString() };
                //var listItemView = new ListViewItem(row);
                //list.Items.Add(listItemView);
                UpdateList(memory.getHoles());
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            memory.clear();
            list.Items.Clear();
            numberOfHoles = 0;
            sim.ss.Clear();
        }

        private void save_Click(object sender, EventArgs e)
        {
            sim = new Simulation();
            sim.setForm(this);
            sim.setMemory(memory);
            if (memory.noHoles())
            {
                MessageBox.Show("No holes are available. \nplease enter at least one hole.");
                return;
            }
            if (compact.Text.Equals("Compact With Deallocation"))
                memory.setCompaction(true);
            else
                memory.setCompaction(false);
            memory.setAlgorithm(comboBox1.Text);
            memory.fillGaps();
            sim.Show();
            sim.UpdateList(memory.getProcesses());
            this.Hide();
            sim.drawMemory();
        }
    }
}
