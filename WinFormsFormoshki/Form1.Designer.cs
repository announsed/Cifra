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
            dataGridView1 = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            UserSurname = new DataGridViewTextBoxColumn();
            UserAge = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            UploadListToGridBTN = new Button();
            textBoxUserSurname = new TextBox();
            label3 = new Label();
            textBoxUserAge = new TextBox();
            label2 = new Label();
            textBoxUserName = new TextBox();
            label1 = new Label();
            AddDataBtn = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UserName, UserSurname, UserAge });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.PapayaWhip;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(458, 428);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            // 
            // UserName
            // 
            UserName.HeaderText = "Имена пользователей";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // UserSurname
            // 
            UserSurname.HeaderText = "Фамилии пользователей";
            UserSurname.Name = "UserSurname";
            UserSurname.ReadOnly = true;
            // 
            // UserAge
            // 
            UserAge.HeaderText = "Возраст пользователей";
            UserAge.Name = "UserAge";
            UserAge.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Azure;
            groupBox1.Controls.Add(UploadListToGridBTN);
            groupBox1.Controls.Add(textBoxUserSurname);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxUserAge);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(AddDataBtn);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 450);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // UploadListToGridBTN
            // 
            UploadListToGridBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UploadListToGridBTN.AutoSize = true;
            UploadListToGridBTN.Location = new Point(171, 409);
            UploadListToGridBTN.Name = "UploadListToGridBTN";
            UploadListToGridBTN.Size = new Size(159, 35);
            UploadListToGridBTN.TabIndex = 7;
            UploadListToGridBTN.Text = "Выгрузить список";
            UploadListToGridBTN.UseVisualStyleBackColor = true;
            UploadListToGridBTN.Click += UploadListToGridBTN_Click;
            // 
            // textBoxUserSurname
            // 
            textBoxUserSurname.Anchor = AnchorStyles.Right;
            textBoxUserSurname.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxUserSurname.Location = new Point(131, 274);
            textBoxUserSurname.Name = "textBoxUserSurname";
            textBoxUserSurname.Size = new Size(199, 39);
            textBoxUserSurname.TabIndex = 6;
            textBoxUserSurname.TextChanged += textBoxUserSurname_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 277);
            label3.Name = "label3";
            label3.Size = new Size(113, 32);
            label3.TabIndex = 5;
            label3.Text = "Фамилия";
            // 
            // textBoxUserAge
            // 
            textBoxUserAge.Anchor = AnchorStyles.Right;
            textBoxUserAge.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxUserAge.Location = new Point(131, 351);
            textBoxUserAge.Name = "textBoxUserAge";
            textBoxUserAge.Size = new Size(199, 39);
            textBoxUserAge.TabIndex = 4;
            textBoxUserAge.TextChanged += textBoxUserAge_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 351);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 3;
            label2.Text = "Отчество";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Anchor = AnchorStyles.Right;
            textBoxUserName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxUserName.Location = new Point(131, 197);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(199, 39);
            textBoxUserName.TabIndex = 2;
            textBoxUserName.TextChanged += textBoxUserName_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 200);
            label1.Name = "label1";
            label1.Size = new Size(61, 32);
            label1.TabIndex = 1;
            label1.Text = "Имя";
            label1.Click += label1_Click;
            // 
            // AddDataBtn
            // 
            AddDataBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddDataBtn.AutoSize = true;
            AddDataBtn.Location = new Point(0, 409);
            AddDataBtn.Name = "AddDataBtn";
            AddDataBtn.Size = new Size(159, 35);
            AddDataBtn.TabIndex = 0;
            AddDataBtn.Text = "Добавить";
            AddDataBtn.UseVisualStyleBackColor = true;
            AddDataBtn.Click += AddDataBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(336, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(464, 450);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Первая Форма";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button AddDataBtn;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserSurname;
        private DataGridViewTextBoxColumn UserAge;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox textBoxUserName;
        private TextBox textBoxUserSurname;
        private Label label3;
        private TextBox textBoxUserAge;
        private Label label2;
        private Button UploadListToGridBTN;
    }
}
