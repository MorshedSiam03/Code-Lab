namespace Code_Lab
{
    partial class TeachersPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachersPayment));
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SubjectcomboBox = new System.Windows.Forms.ComboBox();
            this.confirmPass = new System.Windows.Forms.Label();
            this.SalaryBox = new System.Windows.Forms.TextBox();
            this.InstitutionLabel = new System.Windows.Forms.Label();
            this.nameLebel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.USERNAMEtextBox = new System.Windows.Forms.TextBox();
            this.USERNAME = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Teacher\'s Payment information";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(245, 480);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 40);
            this.button5.TabIndex = 91;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(345, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 37);
            this.button4.TabIndex = 86;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(139, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 40);
            this.button3.TabIndex = 85;
            this.button3.Text = "View";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SubjectcomboBox
            // 
            this.SubjectcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectcomboBox.FormattingEnabled = true;
            this.SubjectcomboBox.Items.AddRange(new object[] {
            "BASIC PROGRAMMING LANGUAGE ",
            "OBJECT ORIANTED PROGRAMMING ",
            "SOFTTWARE DEVELOPMENT",
            "WEB DEVELOPMENT",
            "DATA SCIENCE",
            "",
            ""});
            this.SubjectcomboBox.Location = new System.Drawing.Point(32, 228);
            this.SubjectcomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SubjectcomboBox.Name = "SubjectcomboBox";
            this.SubjectcomboBox.Size = new System.Drawing.Size(411, 37);
            this.SubjectcomboBox.TabIndex = 62;
            // 
            // confirmPass
            // 
            this.confirmPass.AutoSize = true;
            this.confirmPass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPass.ForeColor = System.Drawing.Color.SlateBlue;
            this.confirmPass.Location = new System.Drawing.Point(27, 286);
            this.confirmPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(105, 32);
            this.confirmPass.TabIndex = 79;
            this.confirmPass.Text = "SALARY";
            // 
            // SalaryBox
            // 
            this.SalaryBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryBox.Location = new System.Drawing.Point(32, 313);
            this.SalaryBox.Margin = new System.Windows.Forms.Padding(2);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(411, 38);
            this.SalaryBox.TabIndex = 69;
            // 
            // InstitutionLabel
            // 
            this.InstitutionLabel.AutoSize = true;
            this.InstitutionLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstitutionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.InstitutionLabel.Location = new System.Drawing.Point(27, 195);
            this.InstitutionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstitutionLabel.Name = "InstitutionLabel";
            this.InstitutionLabel.Size = new System.Drawing.Size(149, 32);
            this.InstitutionLabel.TabIndex = 71;
            this.InstitutionLabel.Text = "SPECIALIST ";
            // 
            // nameLebel
            // 
            this.nameLebel.AutoSize = true;
            this.nameLebel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLebel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.nameLebel.Location = new System.Drawing.Point(20, 110);
            this.nameLebel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLebel.Name = "nameLebel";
            this.nameLebel.Size = new System.Drawing.Size(86, 32);
            this.nameLebel.TabIndex = 68;
            this.nameLebel.Text = "NAME";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(32, 137);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(411, 39);
            this.NameBox.TabIndex = 60;
            // 
            // USERNAMEtextBox
            // 
            this.USERNAMEtextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAMEtextBox.Location = new System.Drawing.Point(128, 30);
            this.USERNAMEtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.USERNAMEtextBox.Name = "USERNAMEtextBox";
            this.USERNAMEtextBox.Size = new System.Drawing.Size(211, 38);
            this.USERNAMEtextBox.TabIndex = 53;
            // 
            // USERNAME
            // 
            this.USERNAME.AutoSize = true;
            this.USERNAME.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.USERNAME.Location = new System.Drawing.Point(20, 32);
            this.USERNAME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(134, 32);
            this.USERNAME.TabIndex = 52;
            this.USERNAME.Text = "Teacher ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.SubjectcomboBox);
            this.panel1.Controls.Add(this.confirmPass);
            this.panel1.Controls.Add(this.SalaryBox);
            this.panel1.Controls.Add(this.InstitutionLabel);
            this.panel1.Controls.Add(this.nameLebel);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.USERNAMEtextBox);
            this.panel1.Controls.Add(this.USERNAME);
            this.panel1.Location = new System.Drawing.Point(-2, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 597);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(27, 378);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 32);
            this.label2.TabIndex = 95;
            this.label2.Text = "WORKING DAYS";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(32, 405);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 38);
            this.textBox1.TabIndex = 94;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(617, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 478);
            this.panel2.TabIndex = 93;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(48, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(506, 361);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(881, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 40);
            this.button1.TabIndex = 92;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // TeachersPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1224, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeachersPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher\'s Payment";
            this.Load += new System.EventHandler(this.TeachersPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox SubjectcomboBox;
        private System.Windows.Forms.Label confirmPass;
        private System.Windows.Forms.TextBox SalaryBox;
        private System.Windows.Forms.Label InstitutionLabel;
        private System.Windows.Forms.Label nameLebel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox USERNAMEtextBox;
        private System.Windows.Forms.Label USERNAME;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}