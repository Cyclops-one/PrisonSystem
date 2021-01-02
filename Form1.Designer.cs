namespace Prisoner
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcrimedescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpunishment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcellno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbloodgroup = new System.Windows.Forms.ComboBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtprisonerid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.txtmale = new System.Windows.Forms.RadioButton();
            this.txtfemale = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Prisoner Details";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(220, 60);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Birth";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtcrimedescription
            // 
            this.txtcrimedescription.Location = new System.Drawing.Point(220, 176);
            this.txtcrimedescription.Name = "txtcrimedescription";
            this.txtcrimedescription.Size = new System.Drawing.Size(100, 20);
            this.txtcrimedescription.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Crime Description";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtpunishment
            // 
            this.txtpunishment.Location = new System.Drawing.Point(220, 202);
            this.txtpunishment.Name = "txtpunishment";
            this.txtpunishment.Size = new System.Drawing.Size(100, 20);
            this.txtpunishment.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Punishment";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtcellno
            // 
            this.txtcellno.Location = new System.Drawing.Point(220, 228);
            this.txtcellno.Name = "txtcellno";
            this.txtcellno.Size = new System.Drawing.Size(100, 20);
            this.txtcellno.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cell No";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Blood Group";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbloodgroup
            // 
            this.txtbloodgroup.FormattingEnabled = true;
            this.txtbloodgroup.Items.AddRange(new object[] {
            "Ab+",
            "Ab-",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.txtbloodgroup.Location = new System.Drawing.Point(220, 254);
            this.txtbloodgroup.Name = "txtbloodgroup";
            this.txtbloodgroup.Size = new System.Drawing.Size(121, 21);
            this.txtbloodgroup.TabIndex = 3;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(220, 291);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 20);
            this.txtaddress.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Address";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(659, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(79, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtprisonerid
            // 
            this.txtprisonerid.Location = new System.Drawing.Point(220, 86);
            this.txtprisonerid.Name = "txtprisonerid";
            this.txtprisonerid.Size = new System.Drawing.Size(100, 20);
            this.txtprisonerid.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Priosner id";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(220, 150);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 20);
            this.dob.TabIndex = 6;
            // 
            // txtmale
            // 
            this.txtmale.AutoSize = true;
            this.txtmale.Location = new System.Drawing.Point(220, 112);
            this.txtmale.Name = "txtmale";
            this.txtmale.Size = new System.Drawing.Size(48, 17);
            this.txtmale.TabIndex = 7;
            this.txtmale.TabStop = true;
            this.txtmale.Text = "Male";
            this.txtmale.UseVisualStyleBackColor = true;
            // 
            // txtfemale
            // 
            this.txtfemale.AutoSize = true;
            this.txtfemale.Location = new System.Drawing.Point(293, 112);
            this.txtfemale.Name = "txtfemale";
            this.txtfemale.Size = new System.Drawing.Size(59, 17);
            this.txtfemale.TabIndex = 8;
            this.txtfemale.TabStop = true;
            this.txtfemale.Text = "Female";
            this.txtfemale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Gender";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(220, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(152, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Counselor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtfemale);
            this.Controls.Add(this.txtmale);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbloodgroup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtcellno);
            this.Controls.Add(this.txtpunishment);
            this.Controls.Add(this.txtcrimedescription);
            this.Controls.Add(this.txtprisonerid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcrimedescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpunishment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcellno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtbloodgroup;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtprisonerid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.RadioButton txtmale;
        private System.Windows.Forms.RadioButton txtfemale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
    }
}

