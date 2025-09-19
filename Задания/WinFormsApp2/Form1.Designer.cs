namespace WinFormsApp2
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
            panel1ForGridV = new Panel();
            dataGridView1 = new DataGridView();
            panel2ForBTNControl = new Panel();
            button1Recovery = new Button();
            button1DeleteInNameContact = new Button();
            button1AddContact = new Button();
            panel1ForGridV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2ForBTNControl.SuspendLayout();
            SuspendLayout();
            // 
            // panel1ForGridV
            // 
            panel1ForGridV.Controls.Add(dataGridView1);
            panel1ForGridV.Dock = DockStyle.Fill;
            panel1ForGridV.Location = new Point(0, 0);
            panel1ForGridV.Name = "panel1ForGridV";
            panel1ForGridV.Size = new Size(1947, 1008);
            panel1ForGridV.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1947, 1008);
            dataGridView1.TabIndex = 0;
            // 
            // panel2ForBTNControl
            // 
            panel2ForBTNControl.Controls.Add(button1Recovery);
            panel2ForBTNControl.Controls.Add(button1DeleteInNameContact);
            panel2ForBTNControl.Controls.Add(button1AddContact);
            panel2ForBTNControl.Dock = DockStyle.Bottom;
            panel2ForBTNControl.Location = new Point(0, 881);
            panel2ForBTNControl.Name = "panel2ForBTNControl";
            panel2ForBTNControl.Size = new Size(1947, 127);
            panel2ForBTNControl.TabIndex = 1;
            // 
            // button1Recovery
            // 
            button1Recovery.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1Recovery.AutoSize = true;
            button1Recovery.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1Recovery.Location = new Point(1503, 17);
            button1Recovery.Name = "button1Recovery";
            button1Recovery.Size = new Size(435, 98);
            button1Recovery.TabIndex = 2;
            button1Recovery.Text = "Перезапись ячеек";
            button1Recovery.UseVisualStyleBackColor = true;
            button1Recovery.Click += button1Recovery_Click;
            // 
            // button1DeleteInNameContact
            // 
            button1DeleteInNameContact.Anchor = AnchorStyles.Bottom;
            button1DeleteInNameContact.AutoSize = true;
            button1DeleteInNameContact.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1DeleteInNameContact.Location = new Point(672, 17);
            button1DeleteInNameContact.Name = "button1DeleteInNameContact";
            button1DeleteInNameContact.Size = new Size(647, 98);
            button1DeleteInNameContact.TabIndex = 1;
            button1DeleteInNameContact.Text = "Удалить по имени контакта";
            button1DeleteInNameContact.UseVisualStyleBackColor = true;
            button1DeleteInNameContact.Click += button1DeleteInNameContact_Click;
            // 
            // button1AddContact
            // 
            button1AddContact.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1AddContact.AutoSize = true;
            button1AddContact.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1AddContact.Location = new Point(12, 17);
            button1AddContact.Name = "button1AddContact";
            button1AddContact.Size = new Size(429, 98);
            button1AddContact.TabIndex = 0;
            button1AddContact.Text = "Добавить контакт";
            button1AddContact.UseVisualStyleBackColor = true;
            button1AddContact.Click += button1AddContact_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1947, 1008);
            Controls.Add(panel2ForBTNControl);
            Controls.Add(panel1ForGridV);
            Name = "Form1";
            Text = "Form1";
            panel1ForGridV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2ForBTNControl.ResumeLayout(false);
            panel2ForBTNControl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1ForGridV;
        private DataGridView dataGridView1;
        private Panel panel2ForBTNControl;
        private Button button1DeleteInNameContact;
        private Button button1AddContact;
        private Button button1Recovery;
    }
}
