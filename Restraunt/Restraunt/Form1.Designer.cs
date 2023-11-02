namespace Restraunt
{
    partial class TastyForm1
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
            this.MenugroupBox1 = new System.Windows.Forms.GroupBox();
            this.EggradioButton2 = new System.Windows.Forms.RadioButton();
            this.ChickenradioButton1 = new System.Windows.Forms.RadioButton();
            this.Quantitylabel = new System.Windows.Forms.Label();
            this.NametextBox1 = new System.Windows.Forms.TextBox();
            this.Submitbutton = new System.Windows.Forms.Button();
            this.Copybutton = new System.Windows.Forms.Button();
            this.Egglabel = new System.Windows.Forms.Label();
            this.Preparebutton = new System.Windows.Forms.Button();
            this.Resultslabel = new System.Windows.Forms.Label();
            this.Food = new System.Windows.Forms.ListBox();
            this.MenugroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenugroupBox1
            // 
            this.MenugroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MenugroupBox1.Controls.Add(this.EggradioButton2);
            this.MenugroupBox1.Controls.Add(this.ChickenradioButton1);
            this.MenugroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenugroupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.MenugroupBox1.Location = new System.Drawing.Point(17, 15);
            this.MenugroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.MenugroupBox1.Name = "MenugroupBox1";
            this.MenugroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.MenugroupBox1.Size = new System.Drawing.Size(205, 74);
            this.MenugroupBox1.TabIndex = 0;
            this.MenugroupBox1.TabStop = false;
            this.MenugroupBox1.Text = "Menu";
            // 
            // EggradioButton2
            // 
            this.EggradioButton2.AutoSize = true;
            this.EggradioButton2.ForeColor = System.Drawing.Color.DarkBlue;
            this.EggradioButton2.Location = new System.Drawing.Point(115, 41);
            this.EggradioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.EggradioButton2.Name = "EggradioButton2";
            this.EggradioButton2.Size = new System.Drawing.Size(51, 21);
            this.EggradioButton2.TabIndex = 1;
            this.EggradioButton2.TabStop = true;
            this.EggradioButton2.Text = "Egg";
            this.EggradioButton2.UseVisualStyleBackColor = true;
            this.EggradioButton2.CheckedChanged += new System.EventHandler(this.EggradioButton2_CheckedChanged);
            // 
            // ChickenradioButton1
            // 
            this.ChickenradioButton1.AutoSize = true;
            this.ChickenradioButton1.ForeColor = System.Drawing.Color.DarkBlue;
            this.ChickenradioButton1.Location = new System.Drawing.Point(11, 41);
            this.ChickenradioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.ChickenradioButton1.Name = "ChickenradioButton1";
            this.ChickenradioButton1.Size = new System.Drawing.Size(76, 21);
            this.ChickenradioButton1.TabIndex = 0;
            this.ChickenradioButton1.TabStop = true;
            this.ChickenradioButton1.Text = "Chicken";
            this.ChickenradioButton1.UseVisualStyleBackColor = true;
            this.ChickenradioButton1.CheckedChanged += new System.EventHandler(this.ChickenradioButton1_CheckedChanged);
            // 
            // Quantitylabel
            // 
            this.Quantitylabel.AutoSize = true;
            this.Quantitylabel.BackColor = System.Drawing.Color.SandyBrown;
            this.Quantitylabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.Quantitylabel.Location = new System.Drawing.Point(43, 114);
            this.Quantitylabel.Name = "Quantitylabel";
            this.Quantitylabel.Size = new System.Drawing.Size(61, 17);
            this.Quantitylabel.TabIndex = 1;
            this.Quantitylabel.Text = "Quantity";
            // 
            // NametextBox1
            // 
            this.NametextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NametextBox1.Location = new System.Drawing.Point(113, 111);
            this.NametextBox1.Name = "NametextBox1";
            this.NametextBox1.Size = new System.Drawing.Size(100, 23);
            this.NametextBox1.TabIndex = 2;
            // 
            // Submitbutton
            // 
            this.Submitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Submitbutton.ForeColor = System.Drawing.Color.DarkBlue;
            this.Submitbutton.Location = new System.Drawing.Point(238, 111);
            this.Submitbutton.Name = "Submitbutton";
            this.Submitbutton.Size = new System.Drawing.Size(168, 23);
            this.Submitbutton.TabIndex = 3;
            this.Submitbutton.Text = "Submit new request";
            this.Submitbutton.UseVisualStyleBackColor = false;
            this.Submitbutton.Click += new System.EventHandler(this.Submitbutton_Click);
            // 
            // Copybutton
            // 
            this.Copybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Copybutton.ForeColor = System.Drawing.Color.DarkBlue;
            this.Copybutton.Location = new System.Drawing.Point(68, 163);
            this.Copybutton.Name = "Copybutton";
            this.Copybutton.Size = new System.Drawing.Size(338, 32);
            this.Copybutton.TabIndex = 4;
            this.Copybutton.Text = "Copy the previous request";
            this.Copybutton.UseVisualStyleBackColor = false;
            this.Copybutton.Click += new System.EventHandler(this.Copybutton_Click);
            // 
            // Egglabel
            // 
            this.Egglabel.AutoSize = true;
            this.Egglabel.BackColor = System.Drawing.Color.SandyBrown;
            this.Egglabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.Egglabel.Location = new System.Drawing.Point(43, 214);
            this.Egglabel.Name = "Egglabel";
            this.Egglabel.Size = new System.Drawing.Size(85, 17);
            this.Egglabel.TabIndex = 5;
            this.Egglabel.Text = "Egg Quality:";
            // 
            // Preparebutton
            // 
            this.Preparebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Preparebutton.ForeColor = System.Drawing.Color.DarkBlue;
            this.Preparebutton.Location = new System.Drawing.Point(68, 249);
            this.Preparebutton.Name = "Preparebutton";
            this.Preparebutton.Size = new System.Drawing.Size(338, 23);
            this.Preparebutton.TabIndex = 6;
            this.Preparebutton.Text = "Prepare food";
            this.Preparebutton.UseVisualStyleBackColor = false;
            this.Preparebutton.Click += new System.EventHandler(this.Preparebutton_Click);
            // 
            // Resultslabel
            // 
            this.Resultslabel.AutoSize = true;
            this.Resultslabel.BackColor = System.Drawing.Color.SandyBrown;
            this.Resultslabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.Resultslabel.Location = new System.Drawing.Point(43, 288);
            this.Resultslabel.Name = "Resultslabel";
            this.Resultslabel.Size = new System.Drawing.Size(55, 17);
            this.Resultslabel.TabIndex = 7;
            this.Resultslabel.Text = "Results";
            // 
            // Food
            // 
            this.Food.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Food.FormattingEnabled = true;
            this.Food.ItemHeight = 16;
            this.Food.Location = new System.Drawing.Point(46, 324);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(360, 100);
            this.Food.TabIndex = 8;
            // 
            // TastyForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(460, 460);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Resultslabel);
            this.Controls.Add(this.Preparebutton);
            this.Controls.Add(this.Egglabel);
            this.Controls.Add(this.Copybutton);
            this.Controls.Add(this.Submitbutton);
            this.Controls.Add(this.NametextBox1);
            this.Controls.Add(this.Quantitylabel);
            this.Controls.Add(this.MenugroupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TastyForm1";
            this.Text = "Tasty Corner";
            this.MenugroupBox1.ResumeLayout(false);
            this.MenugroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MenugroupBox1;
        private System.Windows.Forms.RadioButton EggradioButton2;
        private System.Windows.Forms.RadioButton ChickenradioButton1;
        private System.Windows.Forms.Label Quantitylabel;
        private System.Windows.Forms.TextBox NametextBox1;
        private System.Windows.Forms.Button Submitbutton;
        private System.Windows.Forms.Button Copybutton;
        private System.Windows.Forms.Label Egglabel;
        private System.Windows.Forms.Button Preparebutton;
        private System.Windows.Forms.Label Resultslabel;
        private System.Windows.Forms.ListBox Food;
    }
}

