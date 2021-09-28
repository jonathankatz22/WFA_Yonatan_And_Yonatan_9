namespace WFA_Yonatan_And_Yonatan_9
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
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nudesbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(624, 231);
            this.textBox13.MaxLength = 10;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(150, 26);
            this.textBox13.TabIndex = 41;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            this.textBox13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(624, 129);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(401, 26);
            this.textBox_LastName.TabIndex = 40;
            this.textBox_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLastName_KeyPress);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(304, 231);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(281, 26);
            this.textBox10.TabIndex = 38;
            this.textBox10.Text = "Please enter your id:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(304, 182);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(281, 26);
            this.textBox9.TabIndex = 37;
            this.textBox9.Text = "Please enter your phone number:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(304, 84);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(281, 26);
            this.textBox8.TabIndex = 36;
            this.textBox8.Text = "Please enter your first name:";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(624, 84);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(401, 26);
            this.textBox_FirstName.TabIndex = 35;
            this.textBox_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress_1);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(304, 129);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(281, 26);
            this.textBox6.TabIndex = 34;
            this.textBox6.Text = "Please enter your last name:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(751, 184);
            this.textBox3.MaxLength = 7;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 26);
            this.textBox3.TabIndex = 31;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "050",
            "051",
            "052",
            "053",
            "054",
            "055",
            "056",
            "057",
            "058",
            "059"});
            this.comboBox1.Location = new System.Drawing.Point(624, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nudesbutton
            // 
            this.nudesbutton.Location = new System.Drawing.Point(551, 287);
            this.nudesbutton.Name = "nudesbutton";
            this.nudesbutton.Size = new System.Drawing.Size(137, 40);
            this.nudesbutton.TabIndex = 43;
            this.nudesbutton.Text = "save";
            this.nudesbutton.UseVisualStyleBackColor = true;
            this.nudesbutton.Click += new System.EventHandler(this.nudesbutton_Click);
            this.nudesbutton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 450);
            this.Controls.Add(this.nudesbutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button nudesbutton;
    }
}

