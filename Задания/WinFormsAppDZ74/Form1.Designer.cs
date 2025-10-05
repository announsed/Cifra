namespace WinFormsAppDZ74
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
            label1 = new Label();
            textBoxPlan = new TextBox();
            label2 = new Label();
            textBoxPath = new TextBox();
            buttonLoad = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 56);
            label1.Name = "label1";
            label1.Size = new Size(409, 59);
            label1.TabIndex = 0;
            label1.Text = "Список элементов :";
            // 
            // textBoxPlan
            // 
            textBoxPlan.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPlan.Location = new Point(35, 118);
            textBoxPlan.Multiline = true;
            textBoxPlan.Name = "textBoxPlan";
            textBoxPlan.Size = new Size(1845, 597);
            textBoxPlan.TabIndex = 1;
            textBoxPlan.TextChanged += textBoxPlan_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 756);
            label2.Name = "label2";
            label2.Size = new Size(474, 59);
            label2.TabIndex = 2;
            label2.Text = "Укажите путь к файлу: ";
            // 
            // textBoxPath
            // 
            textBoxPath.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPath.Location = new Point(35, 830);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(1556, 65);
            textBoxPath.TabIndex = 3;
            textBoxPath.TextChanged += textBoxPath_TextChanged;
            // 
            // buttonLoad
            // 
            buttonLoad.AutoSize = true;
            buttonLoad.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLoad.Location = new Point(1694, 826);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(186, 69);
            buttonLoad.TabIndex = 4;
            buttonLoad.Text = "Запись";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1914, 907);
            Controls.Add(buttonLoad);
            Controls.Add(textBoxPath);
            Controls.Add(label2);
            Controls.Add(textBoxPlan);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Тема 28. Windows Forms. Методы и свойства. ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPlan;
        private Label label2;
        private TextBox textBoxPath;
        private Button buttonLoad;
    }
}
