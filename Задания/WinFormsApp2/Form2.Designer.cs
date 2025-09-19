namespace WinFormsApp2
{
    partial class Form2AddContact
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
            labelName = new Label();
            labelAddress = new Label();
            labelNumberPhone = new Label();
            labelEMail = new Label();
            textBoxNameContact = new TextBox();
            textBoxAddress = new TextBox();
            textBoxNumberPhone = new TextBox();
            textBoxEMail = new TextBox();
            buttonContinueOK = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(30, 34);
            labelName.Name = "labelName";
            labelName.Size = new Size(337, 65);
            labelName.TabIndex = 0;
            labelName.Text = "Имя контакта:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddress.Location = new Point(30, 130);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(170, 65);
            labelAddress.TabIndex = 1;
            labelAddress.Text = "Адрес:";
            // 
            // labelNumberPhone
            // 
            labelNumberPhone.AutoSize = true;
            labelNumberPhone.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumberPhone.Location = new Point(30, 240);
            labelNumberPhone.Name = "labelNumberPhone";
            labelNumberPhone.Size = new Size(408, 65);
            labelNumberPhone.TabIndex = 2;
            labelNumberPhone.Text = "Номер телефона:";
            // 
            // labelEMail
            // 
            labelEMail.AutoSize = true;
            labelEMail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEMail.Location = new Point(30, 349);
            labelEMail.Name = "labelEMail";
            labelEMail.Size = new Size(474, 65);
            labelEMail.TabIndex = 3;
            labelEMail.Text = "Электронный адрес:";
            // 
            // textBoxNameContact
            // 
            textBoxNameContact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNameContact.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNameContact.Location = new Point(510, 34);
            textBoxNameContact.Name = "textBoxNameContact";
            textBoxNameContact.Size = new Size(1119, 71);
            textBoxNameContact.TabIndex = 4;
            textBoxNameContact.TextChanged += textBoxNameContact_TextChanged;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAddress.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAddress.Location = new Point(510, 130);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(1119, 71);
            textBoxAddress.TabIndex = 5;
            textBoxAddress.TextChanged += textBoxAddress_TextChanged;
            // 
            // textBoxNumberPhone
            // 
            textBoxNumberPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNumberPhone.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNumberPhone.Location = new Point(510, 240);
            textBoxNumberPhone.Name = "textBoxNumberPhone";
            textBoxNumberPhone.Size = new Size(1119, 71);
            textBoxNumberPhone.TabIndex = 6;
            textBoxNumberPhone.TextChanged += textBoxNumberPhone_TextChanged;
            // 
            // textBoxEMail
            // 
            textBoxEMail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEMail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEMail.Location = new Point(510, 349);
            textBoxEMail.Name = "textBoxEMail";
            textBoxEMail.Size = new Size(1119, 71);
            textBoxEMail.TabIndex = 7;
            textBoxEMail.TextChanged += textBoxEMail_TextChanged;
            // 
            // buttonContinueOK
            // 
            buttonContinueOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonContinueOK.AutoSize = true;
            buttonContinueOK.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonContinueOK.Location = new Point(1381, 470);
            buttonContinueOK.Name = "buttonContinueOK";
            buttonContinueOK.Size = new Size(248, 75);
            buttonContinueOK.TabIndex = 8;
            buttonContinueOK.Text = "Добавить";
            buttonContinueOK.UseVisualStyleBackColor = true;
            buttonContinueOK.Click += buttonContinueOK_Click;
            // 
            // Form2AddContact
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1681, 577);
            Controls.Add(buttonContinueOK);
            Controls.Add(textBoxEMail);
            Controls.Add(textBoxNumberPhone);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxNameContact);
            Controls.Add(labelEMail);
            Controls.Add(labelNumberPhone);
            Controls.Add(labelAddress);
            Controls.Add(labelName);
            Name = "Form2AddContact";
            Text = "Добваление контакта";
            Load += Form2AddContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelAddress;
        private Label labelNumberPhone;
        private Label labelEMail;
        private TextBox textBoxNameContact;
        private TextBox textBoxAddress;
        private TextBox textBoxNumberPhone;
        private TextBox textBoxEMail;
        private Button buttonContinueOK;
    }
}