namespace Code_Lab
{
    partial class TecherRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TecherRegistration));
            this.GendercomboBox = new System.Windows.Forms.ComboBox();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.SubjectcomboBox = new System.Windows.Forms.ComboBox();
            this.SignUpBotton = new System.Windows.Forms.Button();
            this.confirmPass = new System.Windows.Forms.Label();
            this.SalaryBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.USERNAME = new System.Windows.Forms.Label();
            this.DOBdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GENDERlebel = new System.Windows.Forms.Label();
            this.USERNAMEtextBox = new System.Windows.Forms.TextBox();
            this.MOBILElebel = new System.Windows.Forms.Label();
            this.DOBlabel = new System.Windows.Forms.Label();
            this.Addresslabel = new System.Windows.Forms.Label();
            this.InstitutionLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.nameLebel = new System.Windows.Forms.Label();
            this.regLebel = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.AddressBox5 = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Qualifiction = new System.Windows.Forms.Label();
            this.QualificationBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GendercomboBox
            // 
            this.GendercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GendercomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GendercomboBox.FormattingEnabled = true;
            this.GendercomboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.GendercomboBox.Location = new System.Drawing.Point(824, 366);
            this.GendercomboBox.Name = "GendercomboBox";
            this.GendercomboBox.Size = new System.Drawing.Size(383, 37);
            this.GendercomboBox.TabIndex = 57;
            this.GendercomboBox.SelectedIndexChanged += new System.EventHandler(this.GendercomboBox_SelectedIndexChanged);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Cancelbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbutton.ForeColor = System.Drawing.Color.Transparent;
            this.Cancelbutton.Location = new System.Drawing.Point(1001, 592);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(101, 38);
            this.Cancelbutton.TabIndex = 46;
            this.Cancelbutton.Text = "CANCEL";
            this.Cancelbutton.UseVisualStyleBackColor = false;
            this.Cancelbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubjectcomboBox
            // 
            this.SubjectcomboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectcomboBox.FormattingEnabled = true;
            this.SubjectcomboBox.Items.AddRange(new object[] {
            "BASIC PROGRAMMING LANGUAGE ",
            "OBJECT ORIANTED PROGRAMMING ",
            "SOFTTWARE DEVELOPMENT",
            "WEB DEVELOPMENT",
            "DATA SCIENCE",
            "",
            ""});
            this.SubjectcomboBox.Location = new System.Drawing.Point(824, 250);
            this.SubjectcomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SubjectcomboBox.Name = "SubjectcomboBox";
            this.SubjectcomboBox.Size = new System.Drawing.Size(383, 40);
            this.SubjectcomboBox.TabIndex = 34;
            this.SubjectcomboBox.Text = "Subject";
            this.SubjectcomboBox.SelectedIndexChanged += new System.EventHandler(this.SubjectcomboBox_SelectedIndexChanged);
            // 
            // SignUpBotton
            // 
            this.SignUpBotton.BackColor = System.Drawing.Color.SlateBlue;
            this.SignUpBotton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBotton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBotton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignUpBotton.Location = new System.Drawing.Point(1106, 592);
            this.SignUpBotton.Margin = new System.Windows.Forms.Padding(2);
            this.SignUpBotton.Name = "SignUpBotton";
            this.SignUpBotton.Size = new System.Drawing.Size(101, 38);
            this.SignUpBotton.TabIndex = 44;
            this.SignUpBotton.Text = "ADD";
            this.SignUpBotton.UseVisualStyleBackColor = false;
            this.SignUpBotton.Click += new System.EventHandler(this.SignUpBotton_Click);
            // 
            // confirmPass
            // 
            this.confirmPass.AutoSize = true;
            this.confirmPass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPass.Location = new System.Drawing.Point(719, 523);
            this.confirmPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(105, 32);
            this.confirmPass.TabIndex = 54;
            this.confirmPass.Text = "SALARY";
            // 
            // SalaryBox
            // 
            this.SalaryBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryBox.Location = new System.Drawing.Point(824, 519);
            this.SalaryBox.Margin = new System.Windows.Forms.Padding(2);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(383, 39);
            this.SalaryBox.TabIndex = 42;
            this.SalaryBox.TextChanged += new System.EventHandler(this.SalaryBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.Location = new System.Drawing.Point(828, 481);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 38);
            this.label2.TabIndex = 53;
            this.label2.Text = "***Password must be at least 6 characters long \r\n     and must have at least one " +
    "digit (\'0\'-\'9\')";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(690, 447);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(147, 32);
            this.password.TabIndex = 52;
            this.password.Text = "PASSWORD";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(824, 445);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(383, 39);
            this.PasswordBox.TabIndex = 40;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // USERNAME
            // 
            this.USERNAME.AutoSize = true;
            this.USERNAME.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME.Location = new System.Drawing.Point(719, 409);
            this.USERNAME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(106, 32);
            this.USERNAME.TabIndex = 51;
            this.USERNAME.Text = "USER ID";
            this.USERNAME.Click += new System.EventHandler(this.USERNAME_Click);
            // 
            // DOBdateTimePicker
            // 
            this.DOBdateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBdateTimePicker.CalendarTitleBackColor = System.Drawing.Color.MediumAquamarine;
            this.DOBdateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBdateTimePicker.Location = new System.Drawing.Point(824, 290);
            this.DOBdateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DOBdateTimePicker.Name = "DOBdateTimePicker";
            this.DOBdateTimePicker.Size = new System.Drawing.Size(383, 34);
            this.DOBdateTimePicker.TabIndex = 36;
            this.DOBdateTimePicker.ValueChanged += new System.EventHandler(this.DOBdateTimePicker_ValueChanged);
            // 
            // GENDERlebel
            // 
            this.GENDERlebel.AutoSize = true;
            this.GENDERlebel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GENDERlebel.Location = new System.Drawing.Point(716, 368);
            this.GENDERlebel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GENDERlebel.Name = "GENDERlebel";
            this.GENDERlebel.Size = new System.Drawing.Size(110, 32);
            this.GENDERlebel.TabIndex = 50;
            this.GENDERlebel.Text = "GENDER";
            // 
            // USERNAMEtextBox
            // 
            this.USERNAMEtextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAMEtextBox.Location = new System.Drawing.Point(824, 406);
            this.USERNAMEtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.USERNAMEtextBox.Name = "USERNAMEtextBox";
            this.USERNAMEtextBox.Size = new System.Drawing.Size(383, 39);
            this.USERNAMEtextBox.TabIndex = 38;
            this.USERNAMEtextBox.TextChanged += new System.EventHandler(this.USERNAMEtextBox_TextChanged);
            // 
            // MOBILElebel
            // 
            this.MOBILElebel.AutoSize = true;
            this.MOBILElebel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOBILElebel.Location = new System.Drawing.Point(730, 330);
            this.MOBILElebel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MOBILElebel.Name = "MOBILElebel";
            this.MOBILElebel.Size = new System.Drawing.Size(97, 32);
            this.MOBILElebel.TabIndex = 49;
            this.MOBILElebel.Text = "PHONE";
            // 
            // DOBlabel
            // 
            this.DOBlabel.AutoSize = true;
            this.DOBlabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBlabel.Location = new System.Drawing.Point(659, 293);
            this.DOBlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DOBlabel.Name = "DOBlabel";
            this.DOBlabel.Size = new System.Drawing.Size(189, 32);
            this.DOBlabel.TabIndex = 48;
            this.DOBlabel.Text = "DATE OF BIRTH";
            // 
            // Addresslabel
            // 
            this.Addresslabel.AutoSize = true;
            this.Addresslabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresslabel.Location = new System.Drawing.Point(712, 151);
            this.Addresslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Addresslabel.Name = "Addresslabel";
            this.Addresslabel.Size = new System.Drawing.Size(122, 32);
            this.Addresslabel.TabIndex = 47;
            this.Addresslabel.Text = "ADDRESS";
            // 
            // InstitutionLabel
            // 
            this.InstitutionLabel.AutoSize = true;
            this.InstitutionLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstitutionLabel.Location = new System.Drawing.Point(689, 257);
            this.InstitutionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstitutionLabel.Name = "InstitutionLabel";
            this.InstitutionLabel.Size = new System.Drawing.Size(149, 32);
            this.InstitutionLabel.TabIndex = 45;
            this.InstitutionLabel.Text = "SPECIALIST ";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(731, 111);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(97, 32);
            this.EmailLabel.TabIndex = 43;
            this.EmailLabel.Text = "E-MAIL";
            // 
            // nameLebel
            // 
            this.nameLebel.AutoSize = true;
            this.nameLebel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLebel.Location = new System.Drawing.Point(740, 74);
            this.nameLebel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLebel.Name = "nameLebel";
            this.nameLebel.Size = new System.Drawing.Size(86, 32);
            this.nameLebel.TabIndex = 41;
            this.nameLebel.Text = "NAME";
            // 
            // regLebel
            // 
            this.regLebel.AutoSize = true;
            this.regLebel.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLebel.ForeColor = System.Drawing.Color.SlateBlue;
            this.regLebel.Location = new System.Drawing.Point(357, 18);
            this.regLebel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regLebel.Name = "regLebel";
            this.regLebel.Size = new System.Drawing.Size(629, 53);
            this.regLebel.TabIndex = 39;
            this.regLebel.Text = "REGISTER NEW TEACHER";
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(824, 109);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(383, 39);
            this.EmailBox.TabIndex = 33;
            this.EmailBox.Text = "name@example.com";
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // AddressBox5
            // 
            this.AddressBox5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressBox5.Location = new System.Drawing.Point(824, 149);
            this.AddressBox5.Margin = new System.Windows.Forms.Padding(2);
            this.AddressBox5.Multiline = true;
            this.AddressBox5.Name = "AddressBox5";
            this.AddressBox5.Size = new System.Drawing.Size(383, 55);
            this.AddressBox5.TabIndex = 35;
            this.AddressBox5.TextChanged += new System.EventHandler(this.AddressBox5_TextChanged);
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneBox.Location = new System.Drawing.Point(824, 328);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(383, 39);
            this.PhoneBox.TabIndex = 37;
            this.PhoneBox.TextChanged += new System.EventHandler(this.PhoneBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(824, 72);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(383, 39);
            this.NameBox.TabIndex = 31;
            this.NameBox.Text = "Enter the name";
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // Qualifiction
            // 
            this.Qualifiction.AutoSize = true;
            this.Qualifiction.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qualifiction.Location = new System.Drawing.Point(653, 212);
            this.Qualifiction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Qualifiction.Name = "Qualifiction";
            this.Qualifiction.Size = new System.Drawing.Size(194, 32);
            this.Qualifiction.TabIndex = 59;
            this.Qualifiction.Text = "QUALIFICATION";
            // 
            // QualificationBox
            // 
            this.QualificationBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QualificationBox.Location = new System.Drawing.Point(824, 210);
            this.QualificationBox.Margin = new System.Windows.Forms.Padding(2);
            this.QualificationBox.Name = "QualificationBox";
            this.QualificationBox.Size = new System.Drawing.Size(383, 39);
            this.QualificationBox.TabIndex = 58;
            this.QualificationBox.TextChanged += new System.EventHandler(this.QualificationBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-136, 76);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(893, 577);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // TecherRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1220, 677);
            this.Controls.Add(this.Qualifiction);
            this.Controls.Add(this.QualificationBox);
            this.Controls.Add(this.GendercomboBox);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.SubjectcomboBox);
            this.Controls.Add(this.SignUpBotton);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.SalaryBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.USERNAME);
            this.Controls.Add(this.DOBdateTimePicker);
            this.Controls.Add(this.GENDERlebel);
            this.Controls.Add(this.USERNAMEtextBox);
            this.Controls.Add(this.MOBILElebel);
            this.Controls.Add(this.DOBlabel);
            this.Controls.Add(this.Addresslabel);
            this.Controls.Add(this.InstitutionLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.nameLebel);
            this.Controls.Add(this.regLebel);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.AddressBox5);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TecherRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Registration";
            this.Load += new System.EventHandler(this.TecherRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GendercomboBox;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.ComboBox SubjectcomboBox;
        private System.Windows.Forms.Button SignUpBotton;
        private System.Windows.Forms.Label confirmPass;
        private System.Windows.Forms.TextBox SalaryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label USERNAME;
        private System.Windows.Forms.DateTimePicker DOBdateTimePicker;
        private System.Windows.Forms.Label GENDERlebel;
        private System.Windows.Forms.TextBox USERNAMEtextBox;
        private System.Windows.Forms.Label MOBILElebel;
        private System.Windows.Forms.Label DOBlabel;
        private System.Windows.Forms.Label Addresslabel;
        private System.Windows.Forms.Label InstitutionLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label nameLebel;
        private System.Windows.Forms.Label regLebel;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox AddressBox5;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Qualifiction;
        private System.Windows.Forms.TextBox QualificationBox;
    }
}