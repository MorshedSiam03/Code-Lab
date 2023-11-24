namespace Code_Lab
{
    partial class StudentReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentReg));
            this.GendercomboBox = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.INSTITUTIONcomboBox1 = new System.Windows.Forms.ComboBox();
            this.SignUpBotton = new System.Windows.Forms.Button();
            this.confirmPass = new System.Windows.Forms.Label();
            this.ConPasswordBox = new System.Windows.Forms.TextBox();
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
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
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
            this.GendercomboBox.Location = new System.Drawing.Point(824, 356);
            this.GendercomboBox.Name = "GendercomboBox";
            this.GendercomboBox.Size = new System.Drawing.Size(383, 32);
            this.GendercomboBox.TabIndex = 57;
            this.GendercomboBox.SelectedIndexChanged += new System.EventHandler(this.GendercomboBox_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(921, 557);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(143, 19);
            this.linkLabel1.TabIndex = 56;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Terms and Conditions";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(824, 556);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 23);
            this.checkBox1.TabIndex = 55;
            this.checkBox1.Text = "Agree all the";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Transparent;
            this.CancelButton.Location = new System.Drawing.Point(1001, 592);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(101, 38);
            this.CancelButton.TabIndex = 46;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // INSTITUTIONcomboBox1
            // 
            this.INSTITUTIONcomboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSTITUTIONcomboBox1.FormattingEnabled = true;
            this.INSTITUTIONcomboBox1.Items.AddRange(new object[] {
            "American International University Bangladesh",
            "Ahsanullah University of Science and Technology",
            "Bangladesh University of Engineering and Tecghnology",
            "BRAC University",
            "Daffodill International University",
            "Dhaka University",
            "Chittagong University of Engineering and Tecghnology",
            "Independent University Bangladesh",
            "North South University",
            "Rajshahi University of Engineering and Tecghnology",
            "Khulna University of Engineering and Tecghnology",
            "Shahjalal University of Science and Technology",
            "Moulana Bhasani University of Science and Technology",
            "Bangabandhu Sheikh Mujibur Rahman University of Science and Technology",
            "Islamic University of  Technology",
            "Jahangirnagar University",
            "Jagannath University",
            "Khulna university",
            "Rajshahi University",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.INSTITUTIONcomboBox1.Location = new System.Drawing.Point(824, 155);
            this.INSTITUTIONcomboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.INSTITUTIONcomboBox1.Name = "INSTITUTIONcomboBox1";
            this.INSTITUTIONcomboBox1.Size = new System.Drawing.Size(383, 32);
            this.INSTITUTIONcomboBox1.TabIndex = 34;
            this.INSTITUTIONcomboBox1.Text = "Add Institution";
            this.INSTITUTIONcomboBox1.SelectedIndexChanged += new System.EventHandler(this.INSTITUTIONcomboBox1_SelectedIndexChanged);
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
            this.SignUpBotton.Text = "Sign Up";
            this.SignUpBotton.UseVisualStyleBackColor = false;
            this.SignUpBotton.Click += new System.EventHandler(this.SignUpBotton_Click);
            // 
            // confirmPass
            // 
            this.confirmPass.AutoSize = true;
            this.confirmPass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPass.Location = new System.Drawing.Point(600, 521);
            this.confirmPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(209, 25);
            this.confirmPass.TabIndex = 54;
            this.confirmPass.Text = "CONFIRM PASSWORD";
            this.confirmPass.Click += new System.EventHandler(this.confirmPass_Click);
            // 
            // ConPasswordBox
            // 
            this.ConPasswordBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConPasswordBox.Location = new System.Drawing.Point(824, 519);
            this.ConPasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.ConPasswordBox.Name = "ConPasswordBox";
            this.ConPasswordBox.Size = new System.Drawing.Size(383, 33);
            this.ConPasswordBox.TabIndex = 42;
            this.ConPasswordBox.TextChanged += new System.EventHandler(this.ConPasswordBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.Location = new System.Drawing.Point(828, 481);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 26);
            this.label2.TabIndex = 53;
            this.label2.Text = "***Password must be at least 6 characters long \r\n     and must have at least one " +
    "digit (\'0\'-\'9\')";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(691, 447);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(117, 25);
            this.password.TabIndex = 52;
            this.password.Text = "PASSWORD";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(824, 445);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(383, 33);
            this.PasswordBox.TabIndex = 40;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // USERNAME
            // 
            this.USERNAME.AutoSize = true;
            this.USERNAME.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME.Location = new System.Drawing.Point(694, 402);
            this.USERNAME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(115, 25);
            this.USERNAME.TabIndex = 51;
            this.USERNAME.Text = "USERNAME";
            this.USERNAME.Click += new System.EventHandler(this.USERNAME_Click);
            // 
            // DOBdateTimePicker
            // 
            this.DOBdateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBdateTimePicker.CalendarTitleBackColor = System.Drawing.Color.MediumAquamarine;
            this.DOBdateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBdateTimePicker.Location = new System.Drawing.Point(824, 273);
            this.DOBdateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DOBdateTimePicker.Name = "DOBdateTimePicker";
            this.DOBdateTimePicker.Size = new System.Drawing.Size(383, 29);
            this.DOBdateTimePicker.TabIndex = 36;
            this.DOBdateTimePicker.ValueChanged += new System.EventHandler(this.DOBdateTimePicker_ValueChanged);
            // 
            // GENDERlebel
            // 
            this.GENDERlebel.AutoSize = true;
            this.GENDERlebel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GENDERlebel.Location = new System.Drawing.Point(722, 358);
            this.GENDERlebel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GENDERlebel.Name = "GENDERlebel";
            this.GENDERlebel.Size = new System.Drawing.Size(87, 25);
            this.GENDERlebel.TabIndex = 50;
            this.GENDERlebel.Text = "GENDER";
            this.GENDERlebel.Click += new System.EventHandler(this.GENDERlebel_Click);
            // 
            // USERNAMEtextBox
            // 
            this.USERNAMEtextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAMEtextBox.Location = new System.Drawing.Point(824, 400);
            this.USERNAMEtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.USERNAMEtextBox.Name = "USERNAMEtextBox";
            this.USERNAMEtextBox.Size = new System.Drawing.Size(383, 33);
            this.USERNAMEtextBox.TabIndex = 38;
            this.USERNAMEtextBox.TextChanged += new System.EventHandler(this.USERNAMEtextBox_TextChanged);
            // 
            // MOBILElebel
            // 
            this.MOBILElebel.AutoSize = true;
            this.MOBILElebel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOBILElebel.Location = new System.Drawing.Point(730, 317);
            this.MOBILElebel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MOBILElebel.Name = "MOBILElebel";
            this.MOBILElebel.Size = new System.Drawing.Size(78, 25);
            this.MOBILElebel.TabIndex = 49;
            this.MOBILElebel.Text = "PHONE";
            this.MOBILElebel.Click += new System.EventHandler(this.MOBILElebel_Click);
            // 
            // DOBlabel
            // 
            this.DOBlabel.AutoSize = true;
            this.DOBlabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBlabel.Location = new System.Drawing.Point(659, 276);
            this.DOBlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DOBlabel.Name = "DOBlabel";
            this.DOBlabel.Size = new System.Drawing.Size(149, 25);
            this.DOBlabel.TabIndex = 48;
            this.DOBlabel.Text = "DATE OF BIRTH";
            this.DOBlabel.Click += new System.EventHandler(this.DOBlabel_Click);
            // 
            // Addresslabel
            // 
            this.Addresslabel.AutoSize = true;
            this.Addresslabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresslabel.Location = new System.Drawing.Point(711, 205);
            this.Addresslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Addresslabel.Name = "Addresslabel";
            this.Addresslabel.Size = new System.Drawing.Size(97, 25);
            this.Addresslabel.TabIndex = 47;
            this.Addresslabel.Text = "ADDRESS";
            this.Addresslabel.Click += new System.EventHandler(this.Addresslabel_Click);
            // 
            // InstitutionLabel
            // 
            this.InstitutionLabel.AutoSize = true;
            this.InstitutionLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstitutionLabel.Location = new System.Drawing.Point(677, 157);
            this.InstitutionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstitutionLabel.Name = "InstitutionLabel";
            this.InstitutionLabel.Size = new System.Drawing.Size(132, 25);
            this.InstitutionLabel.TabIndex = 45;
            this.InstitutionLabel.Text = "INSTITUTION";
            this.InstitutionLabel.Click += new System.EventHandler(this.InstitutionLabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(732, 118);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(77, 25);
            this.EmailLabel.TabIndex = 43;
            this.EmailLabel.Text = "E-MAIL";
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // nameLebel
            // 
            this.nameLebel.AutoSize = true;
            this.nameLebel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLebel.Location = new System.Drawing.Point(740, 74);
            this.nameLebel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLebel.Name = "nameLebel";
            this.nameLebel.Size = new System.Drawing.Size(68, 25);
            this.nameLebel.TabIndex = 41;
            this.nameLebel.Text = "NAME";
            this.nameLebel.Click += new System.EventHandler(this.nameLebel_Click);
            // 
            // regLebel
            // 
            this.regLebel.AutoSize = true;
            this.regLebel.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLebel.ForeColor = System.Drawing.Color.SlateBlue;
            this.regLebel.Location = new System.Drawing.Point(472, 19);
            this.regLebel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regLebel.Name = "regLebel";
            this.regLebel.Size = new System.Drawing.Size(309, 43);
            this.regLebel.TabIndex = 39;
            this.regLebel.Text = "REGISTRATION";
            this.regLebel.Click += new System.EventHandler(this.regLebel_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(824, 114);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(383, 33);
            this.EmailBox.TabIndex = 33;
            this.EmailBox.Text = "name@example.com";
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // AddressBox
            // 
            this.AddressBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressBox.Location = new System.Drawing.Point(824, 203);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(383, 64);
            this.AddressBox.TabIndex = 35;
            this.AddressBox.TextChanged += new System.EventHandler(this.AddressBox_TextChanged);
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneBox.Location = new System.Drawing.Point(824, 315);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(383, 33);
            this.PhoneBox.TabIndex = 37;
            this.PhoneBox.TextChanged += new System.EventHandler(this.PhoneBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(824, 72);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(383, 33);
            this.NameBox.TabIndex = 31;
            this.NameBox.Text = "Enter your name";
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 68);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(594, 601);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // StudentReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1224, 681);
            this.Controls.Add(this.GendercomboBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.INSTITUTIONcomboBox1);
            this.Controls.Add(this.SignUpBotton);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.ConPasswordBox);
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
            this.Controls.Add(this.AddressBox);
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
            this.Name = "StudentReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.StudentReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GendercomboBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox INSTITUTIONcomboBox1;
        private System.Windows.Forms.Button SignUpBotton;
        private System.Windows.Forms.Label confirmPass;
        private System.Windows.Forms.TextBox ConPasswordBox;
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
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}