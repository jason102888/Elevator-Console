namespace ParkALot
{
    partial class Reservation_App_V2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation_App_V2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpTimeOut = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeIn = new System.Windows.Forms.DateTimePicker();
            this.chkBorrowedOrRented = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radRes2 = new System.Windows.Forms.RadioButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radRes1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRes3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.btnLookUpRes = new System.Windows.Forms.Button();
            this.btnChangeRes = new System.Windows.Forms.Button();
            this.btnNewRes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, -82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 647);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dtpTimeOut
            // 
            this.dtpTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeOut.Location = new System.Drawing.Point(205, 333);
            this.dtpTimeOut.Name = "dtpTimeOut";
            this.dtpTimeOut.ShowUpDown = true;
            this.dtpTimeOut.Size = new System.Drawing.Size(122, 20);
            this.dtpTimeOut.TabIndex = 44;
            this.dtpTimeOut.ValueChanged += new System.EventHandler(this.dtpTimeOut_ValueChanged);
            // 
            // dtpTimeIn
            // 
            this.dtpTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeIn.Location = new System.Drawing.Point(205, 294);
            this.dtpTimeIn.Name = "dtpTimeIn";
            this.dtpTimeIn.ShowUpDown = true;
            this.dtpTimeIn.Size = new System.Drawing.Size(122, 20);
            this.dtpTimeIn.TabIndex = 43;
            this.dtpTimeIn.ValueChanged += new System.EventHandler(this.dtpTimeIn_ValueChanged);
            // 
            // chkBorrowedOrRented
            // 
            this.chkBorrowedOrRented.AutoSize = true;
            this.chkBorrowedOrRented.Location = new System.Drawing.Point(209, 359);
            this.chkBorrowedOrRented.Name = "chkBorrowedOrRented";
            this.chkBorrowedOrRented.Size = new System.Drawing.Size(121, 17);
            this.chkBorrowedOrRented.TabIndex = 41;
            this.chkBorrowedOrRented.Text = "Borrowed or Rented";
            this.chkBorrowedOrRented.UseVisualStyleBackColor = true;
            this.chkBorrowedOrRented.CheckedChanged += new System.EventHandler(this.chkBorrowedOrRented_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(242, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Time out";
            // 
            // radRes2
            // 
            this.radRes2.AutoSize = true;
            this.radRes2.Location = new System.Drawing.Point(7, 44);
            this.radRes2.Name = "radRes2";
            this.radRes2.Size = new System.Drawing.Size(91, 17);
            this.radRes2.TabIndex = 1;
            this.radRes2.TabStop = true;
            this.radRes2.Text = "Reservation 2";
            this.radRes2.UseVisualStyleBackColor = true;
            this.radRes2.CheckedChanged += new System.EventHandler(this.radRes2_CheckedChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(205, 256);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(122, 20);
            this.dtpDate.TabIndex = 45;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "New Reservation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(251, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Date";
            // 
            // radRes1
            // 
            this.radRes1.AutoSize = true;
            this.radRes1.Location = new System.Drawing.Point(7, 20);
            this.radRes1.Name = "radRes1";
            this.radRes1.Size = new System.Drawing.Size(91, 17);
            this.radRes1.TabIndex = 0;
            this.radRes1.TabStop = true;
            this.radRes1.Text = "Reservation 1";
            this.radRes1.UseVisualStyleBackColor = true;
            this.radRes1.CheckedChanged += new System.EventHandler(this.radRes1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRes3);
            this.groupBox1.Controls.Add(this.radRes2);
            this.groupBox1.Controls.Add(this.radRes1);
            this.groupBox1.Location = new System.Drawing.Point(50, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 100);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a reservation";
            // 
            // radRes3
            // 
            this.radRes3.AutoSize = true;
            this.radRes3.Location = new System.Drawing.Point(7, 68);
            this.radRes3.Name = "radRes3";
            this.radRes3.Size = new System.Drawing.Size(91, 17);
            this.radRes3.TabIndex = 2;
            this.radRes3.TabStop = true;
            this.radRes3.Text = "Reservation 3";
            this.radRes3.UseVisualStyleBackColor = true;
            this.radRes3.CheckedChanged += new System.EventHandler(this.radRes3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Memeber ID";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(138, 79);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 20);
            this.txtMemberID.TabIndex = 36;
            // 
            // btnLookUpRes
            // 
            this.btnLookUpRes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLookUpRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookUpRes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLookUpRes.Location = new System.Drawing.Point(120, 105);
            this.btnLookUpRes.Name = "btnLookUpRes";
            this.btnLookUpRes.Size = new System.Drawing.Size(132, 23);
            this.btnLookUpRes.TabIndex = 35;
            this.btnLookUpRes.Text = "Look Up Reservation(s)\r\n";
            this.btnLookUpRes.UseVisualStyleBackColor = false;
            this.btnLookUpRes.Click += new System.EventHandler(this.btnLookUpRes_Click);
            // 
            // btnChangeRes
            // 
            this.btnChangeRes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnChangeRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeRes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangeRes.Location = new System.Drawing.Point(120, 134);
            this.btnChangeRes.Name = "btnChangeRes";
            this.btnChangeRes.Size = new System.Drawing.Size(132, 23);
            this.btnChangeRes.TabIndex = 34;
            this.btnChangeRes.Text = "Change Reservation(s)";
            this.btnChangeRes.UseVisualStyleBackColor = false;
            this.btnChangeRes.Click += new System.EventHandler(this.btnChangeRes_Click);
            // 
            // btnNewRes
            // 
            this.btnNewRes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNewRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewRes.Location = new System.Drawing.Point(120, 163);
            this.btnNewRes.Name = "btnNewRes";
            this.btnNewRes.Size = new System.Drawing.Size(132, 23);
            this.btnNewRes.TabIndex = 33;
            this.btnNewRes.Text = "New Reservation";
            this.btnNewRes.UseVisualStyleBackColor = false;
            this.btnNewRes.Click += new System.EventHandler(this.btnNewRes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(47, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Prices";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(246, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Time in";
            // 
            // Reservation_App_V2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 549);
            this.Controls.Add(this.dtpTimeOut);
            this.Controls.Add(this.dtpTimeIn);
            this.Controls.Add(this.chkBorrowedOrRented);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.btnLookUpRes);
            this.Controls.Add(this.btnChangeRes);
            this.Controls.Add(this.btnNewRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Reservation_App_V2";
            this.Text = "Reservation_App_V2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpTimeOut;
        private System.Windows.Forms.DateTimePicker dtpTimeIn;
        private System.Windows.Forms.CheckBox chkBorrowedOrRented;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radRes2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radRes1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radRes3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Button btnLookUpRes;
        private System.Windows.Forms.Button btnChangeRes;
        private System.Windows.Forms.Button btnNewRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}