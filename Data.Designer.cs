namespace Activity_4
{
    partial class Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data));
            NameTB = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ContactTB = new TextBox();
            AgeTB = new TextBox();
            TimeInTB = new TextBox();
            TimeOutTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            ColName = new DataGridViewTextBoxColumn();
            ColAge = new DataGridViewTextBoxColumn();
            ColYear = new DataGridViewTextBoxColumn();
            ColCourse = new DataGridViewTextBoxColumn();
            ColContact = new DataGridViewTextBoxColumn();
            ColBusNum = new DataGridViewTextBoxColumn();
            ColAddress = new DataGridViewTextBoxColumn();
            ColTimeIn = new DataGridViewTextBoxColumn();
            ColTimeOut = new DataGridViewTextBoxColumn();
            YearCB = new ComboBox();
            SectionCB = new ComboBox();
            CourseCB = new ComboBox();
            BusNumCB = new ComboBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // NameTB
            // 
            NameTB.Location = new Point(132, 21);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(125, 27);
            NameTB.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(132, 298);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(345, 298);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(562, 298);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ContactTB
            // 
            ContactTB.Location = new Point(328, 105);
            ContactTB.Name = "ContactTB";
            ContactTB.Size = new Size(125, 27);
            ContactTB.TabIndex = 6;
            // 
            // AgeTB
            // 
            AgeTB.Location = new Point(328, 21);
            AgeTB.Name = "AgeTB";
            AgeTB.Size = new Size(125, 27);
            AgeTB.TabIndex = 8;
            // 
            // TimeInTB
            // 
            TimeInTB.Location = new Point(328, 188);
            TimeInTB.Name = "TimeInTB";
            TimeInTB.Size = new Size(125, 27);
            TimeInTB.TabIndex = 10;
            // 
            // TimeOutTB
            // 
            TimeOutTB.Location = new Point(540, 187);
            TimeOutTB.Name = "TimeOutTB";
            TimeOutTB.Size = new Size(125, 27);
            TimeOutTB.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(162, 60);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(355, 60);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 13;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(579, 60);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 14;
            label3.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(162, 136);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 15;
            label4.Text = "Course";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(355, 136);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 16;
            label5.Text = "Contact no.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(579, 136);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 17;
            label6.Text = "Section";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(136, 218);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 18;
            label7.Text = "Bus Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(355, 218);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 19;
            label8.Text = "Time in ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(571, 218);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 20;
            label9.Text = "Time Out";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColName, ColAge, ColYear, ColCourse, ColContact, ColBusNum, ColAddress, ColTimeIn, ColTimeOut });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 346);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 628);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ColName
            // 
            ColName.HeaderText = "Name";
            ColName.MinimumWidth = 6;
            ColName.Name = "ColName";
            ColName.Width = 125;
            // 
            // ColAge
            // 
            ColAge.HeaderText = "Age";
            ColAge.MinimumWidth = 6;
            ColAge.Name = "ColAge";
            ColAge.Width = 125;
            // 
            // ColYear
            // 
            ColYear.HeaderText = "Year";
            ColYear.MinimumWidth = 6;
            ColYear.Name = "ColYear";
            ColYear.Width = 125;
            // 
            // ColCourse
            // 
            ColCourse.HeaderText = "Course";
            ColCourse.MinimumWidth = 6;
            ColCourse.Name = "ColCourse";
            ColCourse.Width = 125;
            // 
            // ColContact
            // 
            ColContact.HeaderText = "Contact No.";
            ColContact.MinimumWidth = 6;
            ColContact.Name = "ColContact";
            ColContact.Width = 125;
            // 
            // ColBusNum
            // 
            ColBusNum.HeaderText = "Bus Number";
            ColBusNum.MinimumWidth = 6;
            ColBusNum.Name = "ColBusNum";
            ColBusNum.Width = 125;
            // 
            // ColAddress
            // 
            ColAddress.HeaderText = "Address";
            ColAddress.MinimumWidth = 6;
            ColAddress.Name = "ColAddress";
            ColAddress.Width = 125;
            // 
            // ColTimeIn
            // 
            ColTimeIn.HeaderText = "Time In";
            ColTimeIn.MinimumWidth = 6;
            ColTimeIn.Name = "ColTimeIn";
            ColTimeIn.Width = 125;
            // 
            // ColTimeOut
            // 
            ColTimeOut.HeaderText = "Time Out";
            ColTimeOut.MinimumWidth = 6;
            ColTimeOut.Name = "ColTimeOut";
            ColTimeOut.Width = 125;
            // 
            // YearCB
            // 
            YearCB.FormattingEnabled = true;
            YearCB.Location = new Point(540, 21);
            YearCB.Name = "YearCB";
            YearCB.Size = new Size(151, 28);
            YearCB.TabIndex = 22;
            // 
            // SectionCB
            // 
            SectionCB.FormattingEnabled = true;
            SectionCB.Location = new Point(531, 105);
            SectionCB.Name = "SectionCB";
            SectionCB.Size = new Size(151, 28);
            SectionCB.TabIndex = 23;
            // 
            // CourseCB
            // 
            CourseCB.FormattingEnabled = true;
            CourseCB.Location = new Point(106, 105);
            CourseCB.Name = "CourseCB";
            CourseCB.Size = new Size(151, 28);
            CourseCB.TabIndex = 24;
            // 
            // BusNumCB
            // 
            BusNumCB.FormattingEnabled = true;
            BusNumCB.Location = new Point(106, 187);
            BusNumCB.Name = "BusNumCB";
            BusNumCB.Size = new Size(151, 28);
            BusNumCB.TabIndex = 25;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 192);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 26;
            button4.Text = "Out";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Data
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 974);
            Controls.Add(button4);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(TimeOutTB);
            Controls.Add(TimeInTB);
            Controls.Add(ContactTB);
            Controls.Add(AgeTB);
            Controls.Add(NameTB);
            Controls.Add(BusNumCB);
            Controls.Add(CourseCB);
            Controls.Add(SectionCB);
            Controls.Add(YearCB);
            Controls.Add(dataGridView1);
            Name = "Data";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox NameTB;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox ContactTB;
        private TextBox AgeTB;
        private TextBox TimeInTB;
        private TextBox TimeOutTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColAge;
        private DataGridViewTextBoxColumn ColYear;
        private DataGridViewTextBoxColumn ColCourse;
        private DataGridViewTextBoxColumn ColContact;
        private DataGridViewTextBoxColumn ColBusNum;
        private DataGridViewTextBoxColumn ColAddress;
        private DataGridViewTextBoxColumn ColTimeIn;
        private DataGridViewTextBoxColumn ColTimeOut;
        private ComboBox YearCB;
        private ComboBox SectionCB;
        private ComboBox CourseCB;
        private ComboBox BusNumCB;
        private Button button4;
    }
}
