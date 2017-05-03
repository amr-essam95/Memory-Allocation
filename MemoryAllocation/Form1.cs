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
        Simulation sim = new Simulation();
        Memory memory = new Memory();
        int numberOfHoles = 0;
        public Form1()
        {
            InitializeComponent();
            initializeList();
            comboBox1.SelectedIndex = 1;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            sim.setForm(this);
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
        private void initializeList()
        { 
            list.Columns.Add("Hole Number", -2);
            list.Columns.Add("Starting Address", -2);
            list.Columns.Add("Size", -2);
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
                String[] row = { adjacent.getNumber().ToString(), adjacent.getStarting().ToString(), adjacent.getSize().ToString() };
                var listItemView = new ListViewItem(row);
                list.Items.Add(listItemView);
            }
            else
            {
                memory.addHole(tempHole);
                String[] row = { numberOfHoles.ToString(), starting.ToString(), sizeOfHole.ToString() };
                var listItemView = new ListViewItem(row);
                list.Items.Add(listItemView);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            memory.clear();
            list.Items.Clear();
            numberOfHoles = 0;
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
            memory.setAlgorithm(comboBox1.Text);
            memory.fillGaps();
            sim.Show();
            this.Hide();
        }
    }
}
