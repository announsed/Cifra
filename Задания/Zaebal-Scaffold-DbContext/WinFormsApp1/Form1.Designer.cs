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
            panelForDataGridView = new Panel();
            panelForButton = new Panel();
            dataGridViewForDataBase = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            buttonLinkUser = new Button();
            labelForServerDB = new Label();
            labelForServer = new Label();
            textBoxServerLink = new TextBox();
            labelForNameDB = new Label();
            textBoxNameDB = new TextBox();
            labelUserID = new Label();
            textBoxUserID = new TextBox();
            panelForDataGridView.SuspendLayout();
            panelForButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForDataBase).BeginInit();
            SuspendLayout();
            // 
            // panelForDataGridView
            // 
            panelForDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelForDataGridView.Controls.Add(dataGridViewForDataBase);
            panelForDataGridView.Location = new Point(418, 12);
            panelForDataGridView.Name = "panelForDataGridView";
            panelForDataGridView.Size = new Size(1314, 1001);
            panelForDataGridView.TabIndex = 0;
            // 
            // panelForButton
            // 
            panelForButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelForButton.Controls.Add(textBoxUserID);
            panelForButton.Controls.Add(labelUserID);
            panelForButton.Controls.Add(textBoxNameDB);
            panelForButton.Controls.Add(labelForNameDB);
            panelForButton.Controls.Add(textBoxServerLink);
            panelForButton.Controls.Add(labelForServer);
            panelForButton.Controls.Add(labelForServerDB);
            panelForButton.Controls.Add(buttonLinkUser);
            panelForButton.Controls.Add(textBox1);
            panelForButton.Controls.Add(label1);
            panelForButton.Location = new Point(12, 12);
            panelForButton.Name = "panelForButton";
            panelForButton.Size = new Size(400, 1001);
            panelForButton.TabIndex = 1;
            // 
            // dataGridViewForDataBase
            // 
            dataGridViewForDataBase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewForDataBase.Dock = DockStyle.Fill;
            dataGridViewForDataBase.Location = new Point(0, 0);
            dataGridViewForDataBase.Name = "dataGridViewForDataBase";
            dataGridViewForDataBase.RowHeadersWidth = 82;
            dataGridViewForDataBase.Size = new Size(1314, 1001);
            dataGridViewForDataBase.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(337, 65);
            label1.TabIndex = 0;
            label1.Text = "Ссылка на DB:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 57);
            textBox1.TabIndex = 1;
            // 
            // buttonLinkUser
            // 
            buttonLinkUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonLinkUser.AutoSize = true;
            buttonLinkUser.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLinkUser.Location = new Point(84, 143);
            buttonLinkUser.Name = "buttonLinkUser";
            buttonLinkUser.Size = new Size(198, 60);
            buttonLinkUser.TabIndex = 2;
            buttonLinkUser.Text = "Загрузить";
            buttonLinkUser.UseVisualStyleBackColor = true;
            // 
            // labelForServerDB
            // 
            labelForServerDB.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelForServerDB.Location = new Point(6, 242);
            labelForServerDB.Name = "labelForServerDB";
            labelForServerDB.Size = new Size(394, 127);
            labelForServerDB.TabIndex = 3;
            labelForServerDB.Text = "Подключение к серверверу";
            labelForServerDB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelForServer
            // 
            labelForServer.AutoSize = true;
            labelForServer.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelForServer.Location = new Point(19, 389);
            labelForServer.Name = "labelForServer";
            labelForServer.Size = new Size(324, 59);
            labelForServer.TabIndex = 4;
            labelForServer.Text = "Адрес сервера:";
            // 
            // textBoxServerLink
            // 
            textBoxServerLink.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxServerLink.Location = new Point(6, 451);
            textBoxServerLink.Name = "textBoxServerLink";
            textBoxServerLink.Size = new Size(394, 57);
            textBoxServerLink.TabIndex = 5;
            // 
            // labelForNameDB
            // 
            labelForNameDB.AutoSize = true;
            labelForNameDB.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelForNameDB.Location = new Point(19, 511);
            labelForNameDB.Name = "labelForNameDB";
            labelForNameDB.Size = new Size(185, 59);
            labelForNameDB.TabIndex = 6;
            labelForNameDB.Text = "Имя DB:";
            // 
            // textBoxNameDB
            // 
            textBoxNameDB.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNameDB.Location = new Point(0, 573);
            textBoxNameDB.Name = "textBoxNameDB";
            textBoxNameDB.Size = new Size(394, 57);
            textBoxNameDB.TabIndex = 7;
            // 
            // labelUserID
            // 
            labelUserID.AutoSize = true;
            labelUserID.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUserID.Location = new Point(19, 633);
            labelUserID.Name = "labelUserID";
            labelUserID.Size = new Size(362, 59);
            labelUserID.TabIndex = 8;
            labelUserID.Text = "ID Пользователя:";
            // 
            // textBoxUserID
            // 
            textBoxUserID.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserID.Location = new Point(0, 695);
            textBoxUserID.Name = "textBoxUserID";
            textBoxUserID.Size = new Size(394, 57);
            textBoxUserID.TabIndex = 9;
            textBoxUserID.TextChanged += textBoxUserID_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1744, 1025);
            Controls.Add(panelForButton);
            Controls.Add(panelForDataGridView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelForDataGridView.ResumeLayout(false);
            panelForButton.ResumeLayout(false);
            panelForButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForDataBase).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForDataGridView;
        private Panel panelForButton;
        private DataGridView dataGridViewForDataBase;
        private Label label1;
        private Button buttonLinkUser;
        private TextBox textBox1;
        private Label labelForServerDB;
        private Label labelForServer;
        private Label labelForNameDB;
        private TextBox textBoxServerLink;
        private TextBox textBoxNameDB;
        private Label labelUserID;
        private TextBox textBoxUserID;
    }
}
