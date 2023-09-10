namespace TestTask
{
    partial class FormAdvancedInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.TbxMaskPhone = new System.Windows.Forms.MaskedTextBox();
            this.DtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.BtnAddAdvancedInfo = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент:";
            // 
            // LblFullName
            // 
            this.LblFullName.AutoSize = true;
            this.LblFullName.Location = new System.Drawing.Point(85, 9);
            this.LblFullName.Name = "LblFullName";
            this.LblFullName.Size = new System.Drawing.Size(54, 21);
            this.LblFullName.TabIndex = 1;
            this.LblFullName.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Телефон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата рождения:";
            // 
            // TbxEmail
            // 
            this.TbxEmail.Location = new System.Drawing.Point(86, 58);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(215, 29);
            this.TbxEmail.TabIndex = 5;
            // 
            // TbxMaskPhone
            // 
            this.TbxMaskPhone.Location = new System.Drawing.Point(116, 101);
            this.TbxMaskPhone.Mask = "(999) 000-0000";
            this.TbxMaskPhone.Name = "TbxMaskPhone";
            this.TbxMaskPhone.Size = new System.Drawing.Size(185, 29);
            this.TbxMaskPhone.TabIndex = 6;
            // 
            // DtpBirthday
            // 
            this.DtpBirthday.Location = new System.Drawing.Point(164, 141);
            this.DtpBirthday.Name = "DtpBirthday";
            this.DtpBirthday.Size = new System.Drawing.Size(200, 29);
            this.DtpBirthday.TabIndex = 7;
            // 
            // BtnAddAdvancedInfo
            // 
            this.BtnAddAdvancedInfo.Location = new System.Drawing.Point(217, 215);
            this.BtnAddAdvancedInfo.Name = "BtnAddAdvancedInfo";
            this.BtnAddAdvancedInfo.Size = new System.Drawing.Size(146, 30);
            this.BtnAddAdvancedInfo.TabIndex = 8;
            this.BtnAddAdvancedInfo.Text = "Добавить";
            this.BtnAddAdvancedInfo.UseVisualStyleBackColor = true;
            this.BtnAddAdvancedInfo.Click += new System.EventHandler(this.BtnAddAdvancedInfo_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(12, 215);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(146, 30);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Отменить";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // FormAdvancedInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 257);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddAdvancedInfo);
            this.Controls.Add(this.DtpBirthday);
            this.Controls.Add(this.TbxMaskPhone);
            this.Controls.Add(this.TbxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblFullName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdvancedInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Дополнительная информация о клиенте";
            this.Load += new System.EventHandler(this.FormAdvancedInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxEmail;
        private System.Windows.Forms.MaskedTextBox TbxMaskPhone;
        private System.Windows.Forms.DateTimePicker DtpBirthday;
        private System.Windows.Forms.Button BtnAddAdvancedInfo;
        private System.Windows.Forms.Button BtnCancel;
    }
}