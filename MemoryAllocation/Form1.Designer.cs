namespace MemoryAllocation
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.addHole = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.TextBox();
            this.startingAdd = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.startingAddLabel = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListView();
            this.compact = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Best Fit";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "First Fit",
            "Best Fit"});
            this.comboBox1.Location = new System.Drawing.Point(185, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(269, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Algorithm of Allocation:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.addHole);
            this.groupBox1.Controls.Add(this.size);
            this.groupBox1.Controls.Add(this.startingAdd);
            this.groupBox1.Controls.Add(this.sizeLabel);
            this.groupBox1.Controls.Add(this.startingAddLabel);
            this.groupBox1.Location = new System.Drawing.Point(53, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 286);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Holes Entry";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(264, 165);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(122, 23);
            this.clear.TabIndex = 5;
            this.clear.Text = "Clear All Holes";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(162, 212);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(223, 23);
            this.save.TabIndex = 3;
            this.save.Text = "Save Holes and Proceed to Simulation";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // addHole
            // 
            this.addHole.Location = new System.Drawing.Point(162, 165);
            this.addHole.Name = "addHole";
            this.addHole.Size = new System.Drawing.Size(75, 23);
            this.addHole.TabIndex = 4;
            this.addHole.Text = "Add Hole";
            this.addHole.UseVisualStyleBackColor = true;
            this.addHole.Click += new System.EventHandler(this.addHole_Click);
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(162, 108);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(224, 20);
            this.size.TabIndex = 3;
            // 
            // startingAdd
            // 
            this.startingAdd.Location = new System.Drawing.Point(162, 56);
            this.startingAdd.Name = "startingAdd";
            this.startingAdd.Size = new System.Drawing.Size(224, 20);
            this.startingAdd.TabIndex = 2;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(6, 111);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(67, 13);
            this.sizeLabel.TabIndex = 1;
            this.sizeLabel.Text = "Size of Hole:";
            // 
            // startingAddLabel
            // 
            this.startingAddLabel.AutoSize = true;
            this.startingAddLabel.Location = new System.Drawing.Point(6, 59);
            this.startingAddLabel.Name = "startingAddLabel";
            this.startingAddLabel.Size = new System.Drawing.Size(124, 13);
            this.startingAddLabel.TabIndex = 0;
            this.startingAddLabel.Text = "Starting Address of Hole:";
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(551, 35);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(242, 357);
            this.list.TabIndex = 3;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // compact
            // 
            this.compact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compact.FormattingEnabled = true;
            this.compact.Items.AddRange(new object[] {
            "Compact With Deallocation",
            "No Compaction"});
            this.compact.Location = new System.Drawing.Point(185, 63);
            this.compact.Name = "compact";
            this.compact.Size = new System.Drawing.Size(269, 21);
            this.compact.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Compaction:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.compact);
            this.Controls.Add(this.list);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addHole;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox startingAdd;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label startingAddLabel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ComboBox compact;
        private System.Windows.Forms.Label label2;
    }
}

