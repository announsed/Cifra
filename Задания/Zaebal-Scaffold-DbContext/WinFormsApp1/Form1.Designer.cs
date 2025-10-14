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
            dataGridViewForDataBase = new DataGridView();
            panelForButton = new Panel();
            buttonUserInputDBServer = new Button();
            textBoxPassUser = new TextBox();
            labelPassUser = new Label();
            textBoxUserID = new TextBox();
            labelUserID = new Label();
            textBoxNameDB = new TextBox();
            labelForNameDB = new Label();
            textBoxServerLink = new TextBox();
            labelForServer = new Label();
            labelForServerDB = new Label();
            buttonLinkUser = new Button();
            textBoxSourseUser = new TextBox();
            label1 = new Label();
            panelForDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForDataBase).BeginInit();
            panelForButton.SuspendLayout();
            SuspendLayout();
            // 
            // panelForDataGridView
            // 
            panelForDataGridView.Controls.Add(dataGridViewForDataBase);
            panelForDataGridView.Location = new Point(418, 0);
            panelForDataGridView.Name = "panelForDataGridView";
            panelForDataGridView.Size = new Size(1326, 1025);
            panelForDataGridView.TabIndex = 0;
            // 
            // dataGridViewForDataBase
            // 
            dataGridViewForDataBase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewForDataBase.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewForDataBase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewForDataBase.Location = new Point(3, 0);
            dataGridViewForDataBase.Name = "dataGridViewForDataBase";
            dataGridViewForDataBase.RowHeadersWidth = 82;
            dataGridViewForDataBase.Size = new Size(1323, 1025);
            dataGridViewForDataBase.TabIndex = 0;
            dataGridViewForDataBase.CellContentClick += dataGridViewForDataBase_CellContentClick;
            // 
            // panelForButton
            // 
            panelForButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelForButton.Controls.Add(buttonUserInputDBServer);
            panelForButton.Controls.Add(textBoxPassUser);
            panelForButton.Controls.Add(labelPassUser);
            panelForButton.Controls.Add(textBoxUserID);
            panelForButton.Controls.Add(labelUserID);
            panelForButton.Controls.Add(textBoxNameDB);
            panelForButton.Controls.Add(labelForNameDB);
            panelForButton.Controls.Add(textBoxServerLink);
            panelForButton.Controls.Add(labelForServer);
            panelForButton.Controls.Add(labelForServerDB);
            panelForButton.Controls.Add(buttonLinkUser);
            panelForButton.Controls.Add(textBoxSourseUser);
            panelForButton.Controls.Add(label1);
            panelForButton.Location = new Point(12, 12);
            panelForButton.Name = "panelForButton";
            panelForButton.Size = new Size(400, 1001);
            panelForButton.TabIndex = 1;
            // 
            // buttonUserInputDBServer
            // 
            buttonUserInputDBServer.AutoSize = true;
            buttonUserInputDBServer.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUserInputDBServer.Location = new Point(19, 910);
            buttonUserInputDBServer.Name = "buttonUserInputDBServer";
            buttonUserInputDBServer.Size = new Size(359, 75);
            buttonUserInputDBServer.TabIndex = 12;
            buttonUserInputDBServer.Text = "Подключиться";
            buttonUserInputDBServer.UseVisualStyleBackColor = true;
            buttonUserInputDBServer.Click += buttonUserInputDBServer_Click;
            // 
            // textBoxPassUser
            // 
            textBoxPassUser.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassUser.Location = new Point(0, 829);
            textBoxPassUser.Name = "textBoxPassUser";
            textBoxPassUser.Size = new Size(394, 57);
            textBoxPassUser.TabIndex = 11;
            textBoxPassUser.TextChanged += textBoxPassUser_TextChanged;
            // 
            // labelPassUser
            // 
            labelPassUser.AutoSize = true;
            labelPassUser.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassUser.Location = new Point(19, 767);
            labelPassUser.Name = "labelPassUser";
            labelPassUser.Size = new Size(182, 59);
            labelPassUser.TabIndex = 10;
            labelPassUser.Text = "Пароль:";
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
            // textBoxNameDB
            // 
            textBoxNameDB.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNameDB.Location = new Point(0, 573);
            textBoxNameDB.Name = "textBoxNameDB";
            textBoxNameDB.Size = new Size(394, 57);
            textBoxNameDB.TabIndex = 7;
            textBoxNameDB.TextChanged += textBoxNameDB_TextChanged;
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
            // textBoxServerLink
            // 
            textBoxServerLink.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxServerLink.Location = new Point(6, 451);
            textBoxServerLink.Name = "textBoxServerLink";
            textBoxServerLink.Size = new Size(394, 57);
            textBoxServerLink.TabIndex = 5;
            textBoxServerLink.TextChanged += textBoxServerLink_TextChanged;
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
            // buttonLinkUser
            // 
            buttonLinkUser.AutoSize = true;
            buttonLinkUser.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLinkUser.Location = new Point(67, 143);
            buttonLinkUser.Name = "buttonLinkUser";
            buttonLinkUser.Size = new Size(250, 75);
            buttonLinkUser.TabIndex = 2;
            buttonLinkUser.Text = "Загрузить";
            buttonLinkUser.UseVisualStyleBackColor = true;
            buttonLinkUser.Click += buttonLinkUser_Click;
            // 
            // textBoxSourseUser
            // 
            textBoxSourseUser.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSourseUser.Location = new Point(3, 80);
            textBoxSourseUser.Name = "textBoxSourseUser";
            textBoxSourseUser.Size = new Size(394, 57);
            textBoxSourseUser.TabIndex = 1;
            textBoxSourseUser.TextChanged += textBoxSourseUser_TextChanged;
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewForDataBase).EndInit();
            panelForButton.ResumeLayout(false);
            panelForButton.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForDataGridView;
        private Panel panelForButton;
        private DataGridView dataGridViewForDataBase;
        private Label label1;
        private Button buttonLinkUser;
        private TextBox textBoxSourseUser;
        private Label labelForServerDB;
        private Label labelForServer;
        private Label labelForNameDB;
        private TextBox textBoxServerLink;
        private TextBox textBoxNameDB;
        private Label labelUserID;
        private TextBox textBoxUserID;
        private Label labelPassUser;
        private TextBox textBoxPassUser;
        private Button buttonUserInputDBServer;
    }
}
