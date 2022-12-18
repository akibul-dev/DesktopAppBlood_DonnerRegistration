namespace SimpleCrud_dotnet_desktopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_bloodGroup = new System.Windows.Forms.ComboBox();
            this.txt_gender = new System.Windows.Forms.ComboBox();
            this.gv_datalist = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_datalist)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DimGray;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_save.Location = new System.Drawing.Point(21, 382);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(146, 39);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Name.Location = new System.Drawing.Point(243, 101);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(182, 27);
            this.txt_Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(21, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(21, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(21, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(21, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Menu;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(460, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "BLOOD DONOR DATABASE";
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_phoneNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_phoneNumber.Location = new System.Drawing.Point(244, 213);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(182, 27);
            this.txt_phoneNumber.TabIndex = 1;
            // 
            // txt_address
            // 
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_address.Location = new System.Drawing.Point(244, 248);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(182, 27);
            this.txt_address.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(21, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Blood Group";
            // 
            // txt_Date
            // 
            this.txt_Date.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Date.Location = new System.Drawing.Point(244, 329);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(200, 25);
            this.txt_Date.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(21, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Last Blood Donation Date";
            // 
            // txt_bloodGroup
            // 
            this.txt_bloodGroup.FormattingEnabled = true;
            this.txt_bloodGroup.Items.AddRange(new object[] {
            "A RhD positive (A+)",
            "A RhD negative (A-)",
            "B RhD positive (B+)",
            "B RhD negative (B-)",
            "O RhD positive (O+)",
            "O RhD negative (O-)",
            "AB RhD positive (AB+)",
            "AB RhD negative (AB-)"});
            this.txt_bloodGroup.Location = new System.Drawing.Point(244, 290);
            this.txt_bloodGroup.Name = "txt_bloodGroup";
            this.txt_bloodGroup.Size = new System.Drawing.Size(121, 23);
            this.txt_bloodGroup.TabIndex = 7;
            // 
            // txt_gender
            // 
            this.txt_gender.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_gender.FormattingEnabled = true;
            this.txt_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.txt_gender.Location = new System.Drawing.Point(244, 141);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(121, 28);
            this.txt_gender.TabIndex = 8;
            // 
            // gv_datalist
            // 
            this.gv_datalist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gv_datalist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_datalist.Location = new System.Drawing.Point(478, 86);
            this.gv_datalist.Name = "gv_datalist";
            this.gv_datalist.RowTemplate.Height = 25;
            this.gv_datalist.Size = new System.Drawing.Size(774, 407);
            this.gv_datalist.TabIndex = 9;
            this.gv_datalist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_datalist_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Menu;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(21, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(338, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "NEW BLOOD DONOR REGISTRATION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Menu;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(834, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "DONOR DATABASE";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.IndianRed;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clear.Location = new System.Drawing.Point(21, 427);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(146, 39);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(21, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "AGE";
            this.label10.UseMnemonic = false;
            // 
            // txt_age
            // 
            this.txt_age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_age.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_age.Location = new System.Drawing.Point(244, 178);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(182, 27);
            this.txt_age.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1135, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gv_datalist);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_bloodGroup);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gv_datalist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_save;
        private TextBox txt_Name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_phoneNumber;
        private TextBox txt_address;
        private Label label6;
        private DateTimePicker txt_Date;
        private Label label7;
        private ComboBox txt_bloodGroup;
        private ComboBox txt_gender;
        private DataGridView gv_datalist;
        private Label label8;
        private Label label9;
        private Button btn_clear;
        private Label label10;
        private TextBox txt_age;
        private Button button1;
    }
}