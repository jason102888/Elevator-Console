namespace ParkALot
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.plateBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.cardBox = new System.Windows.Forms.TextBox();
            this.dbInput = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneNumBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "License Plate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(8, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Credit Card Number:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(144, 15);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(110, 20);
            this.nameBox.TabIndex = 6;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // plateBox
            // 
            this.plateBox.Location = new System.Drawing.Point(144, 82);
            this.plateBox.Name = "plateBox";
            this.plateBox.Size = new System.Drawing.Size(110, 20);
            this.plateBox.TabIndex = 8;
            this.plateBox.TextChanged += new System.EventHandler(this.plateBox_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(144, 117);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(110, 20);
            this.emailBox.TabIndex = 9;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // cardBox
            // 
            this.cardBox.Location = new System.Drawing.Point(144, 187);
            this.cardBox.Name = "cardBox";
            this.cardBox.Size = new System.Drawing.Size(110, 20);
            this.cardBox.TabIndex = 11;
            this.cardBox.TextChanged += new System.EventHandler(this.cardBox_TextChanged);
            // 
            // dbInput
            // 
            this.dbInput.BackColor = System.Drawing.Color.Gray;
            this.dbInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dbInput.Location = new System.Drawing.Point(152, 230);
            this.dbInput.Name = "dbInput";
            this.dbInput.Size = new System.Drawing.Size(94, 30);
            this.dbInput.TabIndex = 12;
            this.dbInput.Text = "Register";
            this.dbInput.UseVisualStyleBackColor = false;
            this.dbInput.Click += new System.EventHandler(this.dbInput_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(208, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Make an appointment";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(262, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(144, 49);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(110, 20);
            this.lastNameBox.TabIndex = 16;
            this.lastNameBox.TextChanged += new System.EventHandler(this.lastNameBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(7, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Phone Number:";
            // 
            // phoneNumBox
            // 
            this.phoneNumBox.Location = new System.Drawing.Point(144, 152);
            this.phoneNumBox.Name = "phoneNumBox";
            this.phoneNumBox.Size = new System.Drawing.Size(110, 20);
            this.phoneNumBox.TabIndex = 19;
            this.phoneNumBox.TextChanged += new System.EventHandler(this.phoneNumBox_TextChanged);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(398, 321);
            this.Controls.Add(this.phoneNumBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dbInput);
            this.Controls.Add(this.cardBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.plateBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox plateBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox cardBox;
        private System.Windows.Forms.Button dbInput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneNumBox;
    }
}