namespace MemoryAllocation
{
    partial class Simulation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allocate = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.lableNumber = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListView();
            this.memoryPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Allocation",
            "Deallocation"});
            this.comboBox1.Location = new System.Drawing.Point(65, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allocate);
            this.groupBox1.Controls.Add(this.size);
            this.groupBox1.Controls.Add(this.number);
            this.groupBox1.Controls.Add(this.labelSize);
            this.groupBox1.Controls.Add(this.lableNumber);
            this.groupBox1.Location = new System.Drawing.Point(65, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // allocate
            // 
            this.allocate.Location = new System.Drawing.Point(145, 128);
            this.allocate.Name = "allocate";
            this.allocate.Size = new System.Drawing.Size(75, 23);
            this.allocate.TabIndex = 2;
            this.allocate.Text = "Allocate";
            this.allocate.UseVisualStyleBackColor = true;
            this.allocate.Click += new System.EventHandler(this.allocate_Click);
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(145, 76);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(167, 20);
            this.size.TabIndex = 3;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(145, 31);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(167, 20);
            this.number.TabIndex = 2;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(23, 79);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(71, 13);
            this.labelSize.TabIndex = 1;
            this.labelSize.Text = "Process Size:";
            // 
            // lableNumber
            // 
            this.lableNumber.AutoSize = true;
            this.lableNumber.Location = new System.Drawing.Point(23, 34);
            this.lableNumber.Name = "lableNumber";
            this.lableNumber.Size = new System.Drawing.Size(88, 13);
            this.lableNumber.TabIndex = 0;
            this.lableNumber.Text = "Process Number:";
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(562, 30);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(698, 235);
            this.list.TabIndex = 2;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // memoryPanel
            // 
            this.memoryPanel.AutoScroll = true;
            this.memoryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memoryPanel.Location = new System.Drawing.Point(65, 289);
            this.memoryPanel.Name = "memoryPanel";
            this.memoryPanel.Size = new System.Drawing.Size(1195, 360);
            this.memoryPanel.TabIndex = 3;
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.memoryPanel);
            this.Controls.Add(this.list);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Simulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hole";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Simulation_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button allocate;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label lableNumber;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.Panel memoryPanel;
    }
}