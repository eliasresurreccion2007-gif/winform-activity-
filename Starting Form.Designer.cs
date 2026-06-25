namespace WinFormsApp2
{
    partial class Starting_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Starting_Form));
            NAMETB = new TextBox();
            AGETB = new TextBox();
            GENDERTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            INFOTB = new TextBox();
            label4 = new Label();
            SHOWGENCB = new CheckBox();
            PasswordTB = new TextBox();
            UsernameTB = new TextBox();
            b = new Button();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // NAMETB
            // 
            NAMETB.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NAMETB.Location = new Point(157, 27);
            NAMETB.Name = "NAMETB";
            NAMETB.Size = new Size(125, 26);
            NAMETB.TabIndex = 0;
            // 
            // AGETB
            // 
            AGETB.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AGETB.Location = new Point(157, 74);
            AGETB.Name = "AGETB";
            AGETB.Size = new Size(125, 26);
            AGETB.TabIndex = 1;
            // 
            // GENDERTB
            // 
            GENDERTB.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GENDERTB.Location = new Point(157, 131);
            GENDERTB.Name = "GENDERTB";
            GENDERTB.Size = new Size(125, 26);
            GENDERTB.TabIndex = 2;
            GENDERTB.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 27);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 74);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 4;
            label2.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 134);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 5;
            label3.Text = "Gender:";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(172, 196);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // INFOTB
            // 
            INFOTB.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            INFOTB.Location = new Point(157, 243);
            INFOTB.Name = "INFOTB";
            INFOTB.Size = new Size(125, 26);
            INFOTB.TabIndex = 7;
            INFOTB.TextChanged += INFOTB_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(44, 246);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 8;
            label4.Text = "Info:";
            // 
            // SHOWGENCB
            // 
            SHOWGENCB.AutoSize = true;
            SHOWGENCB.BackColor = Color.Transparent;
            SHOWGENCB.Checked = true;
            SHOWGENCB.CheckState = CheckState.Checked;
            SHOWGENCB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SHOWGENCB.ForeColor = Color.White;
            SHOWGENCB.Location = new Point(165, 166);
            SHOWGENCB.Name = "SHOWGENCB";
            SHOWGENCB.Size = new Size(124, 24);
            SHOWGENCB.TabIndex = 9;
            SHOWGENCB.Text = "Show Gender";
            SHOWGENCB.UseVisualStyleBackColor = false;
            SHOWGENCB.CheckedChanged += SHOWGENCB_CheckedChanged;
            // 
            // PasswordTB
            // 
            PasswordTB.BackColor = Color.White;
            PasswordTB.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordTB.Location = new Point(611, 166);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(125, 26);
            PasswordTB.TabIndex = 10;
            PasswordTB.UseSystemPasswordChar = true;
            // 
            // UsernameTB
            // 
            UsernameTB.BackColor = Color.White;
            UsernameTB.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameTB.Location = new Point(611, 40);
            UsernameTB.Name = "UsernameTB";
            UsernameTB.Size = new Size(125, 26);
            UsernameTB.TabIndex = 11;
            // 
            // b
            // 
            b.BackColor = Color.Lime;
            b.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b.Location = new Point(621, 218);
            b.Name = "b";
            b.Size = new Size(94, 29);
            b.TabIndex = 12;
            b.Text = "LOG IN !!";
            b.UseVisualStyleBackColor = false;
            b.Click += b_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(522, 43);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 13;
            label5.Text = "Username:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(522, 169);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 14;
            label6.Text = "Password:";
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(654, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "OUT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Starting_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(b);
            Controls.Add(UsernameTB);
            Controls.Add(PasswordTB);
            Controls.Add(SHOWGENCB);
            Controls.Add(label4);
            Controls.Add(INFOTB);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GENDERTB);
            Controls.Add(AGETB);
            Controls.Add(NAMETB);
            Name = "Starting_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Starting_Form";
            Load += Starting_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NAMETB;
        private TextBox AGETB;
        private TextBox GENDERTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox INFOTB;
        private Label label4;
        private CheckBox SHOWGENCB;
        private TextBox PasswordTB;
        private TextBox UsernameTB;
        private Button b;
        private Label label5;
        private Label label6;
        private Button button2;
    }
}