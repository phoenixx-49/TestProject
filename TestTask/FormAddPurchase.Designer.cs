namespace TestTask
{
    partial class FormAddPurchase
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbClients = new System.Windows.Forms.ComboBox();
            this.DtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.TbxCost = new System.Windows.Forms.TextBox();
            this.PbxPurchasePhoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPurchasePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(11, 359);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(221, 30);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(253, 359);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(221, 30);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите клиента:";
            // 
            // CmbClients
            // 
            this.CmbClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbClients.FormattingEnabled = true;
            this.CmbClients.Location = new System.Drawing.Point(16, 33);
            this.CmbClients.Name = "CmbClients";
            this.CmbClients.Size = new System.Drawing.Size(338, 29);
            this.CmbClients.TabIndex = 7;
            // 
            // DtpPurchaseDate
            // 
            this.DtpPurchaseDate.Location = new System.Drawing.Point(133, 98);
            this.DtpPurchaseDate.Name = "DtpPurchaseDate";
            this.DtpPurchaseDate.Size = new System.Drawing.Size(200, 29);
            this.DtpPurchaseDate.TabIndex = 8;
            // 
            // TbxCost
            // 
            this.TbxCost.Location = new System.Drawing.Point(133, 153);
            this.TbxCost.Name = "TbxCost";
            this.TbxCost.Size = new System.Drawing.Size(200, 29);
            this.TbxCost.TabIndex = 9;
            // 
            // PbxPurchasePhoto
            // 
            this.PbxPurchasePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPurchasePhoto.Location = new System.Drawing.Point(209, 206);
            this.PbxPurchasePhoto.Name = "PbxPurchasePhoto";
            this.PbxPurchasePhoto.Size = new System.Drawing.Size(124, 113);
            this.PbxPurchasePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxPurchasePhoto.TabIndex = 10;
            this.PbxPurchasePhoto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дата покупки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Сумма чека:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Фото покупки:";
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.BackColor = System.Drawing.Color.Green;
            this.BtnOpenFile.ForeColor = System.Drawing.Color.White;
            this.BtnOpenFile.Location = new System.Drawing.Point(54, 289);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(149, 30);
            this.BtnOpenFile.TabIndex = 14;
            this.BtnOpenFile.Text = "Выбрать файл";
            this.BtnOpenFile.UseVisualStyleBackColor = false;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Filter = "PNG|*.png|JPG|*.jpg";
            // 
            // FormAddPurchase
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 401);
            this.Controls.Add(this.BtnOpenFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PbxPurchasePhoto);
            this.Controls.Add(this.TbxCost);
            this.Controls.Add(this.DtpPurchaseDate);
            this.Controls.Add(this.CmbClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnCancel);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление покупки";
            this.Load += new System.EventHandler(this.FormAddPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxPurchasePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbClients;
        private System.Windows.Forms.DateTimePicker DtpPurchaseDate;
        private System.Windows.Forms.TextBox TbxCost;
        private System.Windows.Forms.PictureBox PbxPurchasePhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.OpenFileDialog OpenFile;
    }
}