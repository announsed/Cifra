namespace WinFormsApp1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            IdUser = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            SecondName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            RegistrationDate = new DataGridViewTextBoxColumn();
            BirthDate = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(314, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(709, 71);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(20, 781);
            button1.Name = "button1";
            button1.Size = new Size(471, 183);
            button1.TabIndex = 1;
            button1.Text = "Зарегистрировать пользователя";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.Maroon;
            button2.Location = new Point(536, 781);
            button2.Name = "button2";
            button2.Size = new Size(419, 183);
            button2.TabIndex = 2;
            button2.Text = "Выполнить сериализацию";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 119);
            label1.Name = "label1";
            label1.Size = new Size(271, 65);
            label1.TabIndex = 3;
            label1.Text = "NickName :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(23, 35);
            label2.Name = "label2";
            label2.Size = new Size(145, 65);
            label2.TabIndex = 4;
            label2.Text = "Имя :";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(314, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(709, 71);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(23, 295);
            label3.Name = "label3";
            label3.Size = new Size(142, 65);
            label3.TabIndex = 6;
            label3.Text = "Mail :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(23, 387);
            label4.Name = "label4";
            label4.Size = new Size(214, 65);
            label4.TabIndex = 7;
            label4.Text = "Пароль :";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(314, 295);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(709, 71);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(314, 381);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(709, 71);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(20, 208);
            label5.Name = "label5";
            label5.Size = new Size(249, 65);
            label5.TabIndex = 10;
            label5.Text = "Фамилия :";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox5.Location = new Point(314, 208);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(709, 71);
            textBox5.TabIndex = 11;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(23, 472);
            label6.Name = "label6";
            label6.Size = new Size(388, 65);
            label6.TabIndex = 12;
            label6.Text = "Дата рождения :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.LawnGreen;
            dateTimePicker1.CalendarTitleForeColor = Color.Green;
            dateTimePicker1.CalendarTrailingForeColor = Color.FromArgb(0, 64, 0);
            dateTimePicker1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker1.Location = new Point(417, 472);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(606, 71);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Moccasin;
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2803, 976);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Gray;
            button5.Location = new Point(2042, 781);
            button5.Name = "button5";
            button5.Size = new Size(438, 183);
            button5.TabIndex = 17;
            button5.Text = "Выгрузить в CSV";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom;
            button4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.DeepSkyBlue;
            button4.Location = new Point(1565, 781);
            button4.Name = "button4";
            button4.Size = new Size(438, 183);
            button4.TabIndex = 16;
            button4.Text = "Выгрузить в Excel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1010, 781);
            button3.Name = "button3";
            button3.Size = new Size(509, 183);
            button3.TabIndex = 15;
            button3.Text = "Выгрузить в таблицу";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkOrange;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdUser, UserName, FirstName, SecondName, Email, Password, RegistrationDate, BirthDate });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RosyBrown;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Olive;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(1073, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1684, 508);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IdUser
            // 
            IdUser.HeaderText = "Id";
            IdUser.MinimumWidth = 10;
            IdUser.Name = "IdUser";
            IdUser.ReadOnly = true;
            IdUser.Width = 200;
            // 
            // UserName
            // 
            UserName.HeaderText = "Ник";
            UserName.MinimumWidth = 10;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Width = 200;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "Имя";
            FirstName.MinimumWidth = 10;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 200;
            // 
            // SecondName
            // 
            SecondName.HeaderText = "Фамилия";
            SecondName.MinimumWidth = 10;
            SecondName.Name = "SecondName";
            SecondName.ReadOnly = true;
            SecondName.Width = 200;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 10;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 200;
            // 
            // Password
            // 
            Password.HeaderText = "Пароль";
            Password.MinimumWidth = 10;
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Width = 200;
            // 
            // RegistrationDate
            // 
            RegistrationDate.HeaderText = "Дата регистрации";
            RegistrationDate.MinimumWidth = 10;
            RegistrationDate.Name = "RegistrationDate";
            RegistrationDate.ReadOnly = true;
            RegistrationDate.Width = 200;
            // 
            // BirthDate
            // 
            BirthDate.HeaderText = "Дата рождения";
            BirthDate.MinimumWidth = 10;
            BirthDate.Name = "BirthDate";
            BirthDate.ReadOnly = true;
            BirthDate.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2803, 976);
            Controls.Add(groupBox1);
            ForeColor = Color.Teal;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Зарегистрировать, проверить, сериализовать, выгрузить";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdUser;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn SecondName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn RegistrationDate;
        private DataGridViewTextBoxColumn BirthDate;
        private Button button4;
        private Button button5;
    }
}
