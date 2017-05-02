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
            this.startingAddLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.startingAdd = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.TextBox();
            this.addHole = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Best Fit";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "First Fit",
            "Best Fit"});
            this.comboBox1.Location = new System.Drawing.Point(185, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(269, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Algorithm of Allocation:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addHole);
            this.groupBox1.Controls.Add(this.size);
            this.groupBox1.Controls.Add(this.startingAdd);
            this.groupBox1.Controls.Add(this.sizeLabel);
            this.groupBox1.Controls.Add(this.startingAddLabel);
            this.groupBox1.Location = new System.Drawing.Point(53, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 218);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Holes Entry";
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
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(6, 111);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(67, 13);
            this.sizeLabel.TabIndex = 1;
            this.sizeLabel.Text = "Size of Hole:";
            // 
            // startingAdd
            // 
            this.startingAdd.Location = new System.Drawing.Point(162, 56);
            this.startingAdd.Name = "startingAdd";
            this.startingAdd.Size = new System.Drawing.Size(224, 20);
            this.startingAdd.TabIndex = 2;
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(162, 108);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(224, 20);
            this.size.TabIndex = 3;
            // 
            // addHole
            // 
            this.addHole.Location = new System.Drawing.Point(120, 169);
            this.addHole.Name = "addHole";
            this.addHole.Size = new System.Drawing.Size(75, 23);
            this.addHole.TabIndex = 4;
            this.addHole.Text = "Add Hole";
            this.addHole.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
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
    }
}

