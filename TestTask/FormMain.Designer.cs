namespace TestTask
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAddClient = new System.Windows.Forms.Button();
            this.TbxPatronymic = new System.Windows.Forms.TextBox();
            this.TbxFirstname = new System.Windows.Forms.TextBox();
            this.TbxLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgbClients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAddAdvantedInfo = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnGet = new System.Windows.Forms.Button();
            this.BtnAddPurchase = new System.Windows.Forms.Button();
            this.BtnListPurchase = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnCloseApplication = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbClients)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAddClient);
            this.groupBox1.Controls.Add(this.TbxPatronymic);
            this.groupBox1.Controls.Add(this.TbxFirstname);
            this.groupBox1.Controls.Add(this.TbxLastname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиенты";
            // 
            // BtnAddClient
            // 
            this.BtnAddClient.Location = new System.Drawing.Point(6, 209);
            this.BtnAddClient.Name = "BtnAddClient";
            this.BtnAddClient.Size = new System.Drawing.Size(243, 30);
            this.BtnAddClient.TabIndex = 7;
            this.BtnAddClient.Text = "Добавить";
            this.BtnAddClient.UseVisualStyleBackColor = true;
            this.BtnAddClient.Click += new System.EventHandler(this.BtnAddClient_Click);
            // 
            // TbxPatronymic
            // 
            this.TbxPatronymic.Location = new System.Drawing.Point(10, 161);
            this.TbxPatronymic.Name = "TbxPatronymic";
            this.TbxPatronymic.Size = new System.Drawing.Size(196, 29);
            this.TbxPatronymic.TabIndex = 6;
            // 
            // TbxFirstname
            // 
            this.TbxFirstname.Location = new System.Drawing.Point(10, 105);
            this.TbxFirstname.Name = "TbxFirstname";
            this.TbxFirstname.Size = new System.Drawing.Size(196, 29);
            this.TbxFirstname.TabIndex = 4;
            // 
            // TbxLastname
            // 
            this.TbxLastname.Location = new System.Drawing.Point(10, 49);
            this.TbxLastname.Name = "TbxLastname";
            this.TbxLastname.Size = new System.Drawing.Size(196, 29);
            this.TbxLastname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            // 
            // DgbClients
            // 
            this.DgbClients.AllowUserToAddRows = false;
            this.DgbClients.AllowUserToDeleteRows = false;
            this.DgbClients.AllowUserToResizeColumns = false;
            this.DgbClients.AllowUserToResizeRows = false;
            this.DgbClients.BackgroundColor = System.Drawing.Color.White;
            this.DgbClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DgbClients.GridColor = System.Drawing.Color.White;
            this.DgbClients.Location = new System.Drawing.Point(6, 28);
            this.DgbClients.Name = "DgbClients";
            this.DgbClients.ReadOnly = true;
            this.DgbClients.RowHeadersVisible = false;
            this.DgbClients.RowTemplate.Height = 30;
            this.DgbClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgbClients.Size = new System.Drawing.Size(611, 150);
            this.DgbClients.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Клиент";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.BtnAddAdvantedInfo);
            this.groupBox2.Controls.Add(this.BtnEdit);
            this.groupBox2.Controls.Add(this.BtnDel);
            this.groupBox2.Controls.Add(this.BtnGet);
            this.groupBox2.Controls.Add(this.DgbClients);
            this.groupBox2.Location = new System.Drawing.Point(279, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 263);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список клиентов";
            // 
            // BtnAddAdvantedInfo
            // 
            this.BtnAddAdvantedInfo.Location = new System.Drawing.Point(170, 184);
            this.BtnAddAdvantedInfo.Name = "BtnAddAdvantedInfo";
            this.BtnAddAdvantedInfo.Size = new System.Drawing.Size(357, 30);
            this.BtnAddAdvantedInfo.TabIndex = 5;
            this.BtnAddAdvantedInfo.Text = "Добавить доп. информацию";
            this.BtnAddAdvantedInfo.UseVisualStyleBackColor = true;
            this.BtnAddAdvantedInfo.Click += new System.EventHandler(this.BtnAddAdvantedInfo_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(270, 220);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(257, 30);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "Редактировать выбранный";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(7, 220);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(257, 30);
            this.BtnDel.TabIndex = 3;
            this.BtnDel.Text = "Удалить выбранный";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnGet
            // 
            this.BtnGet.Location = new System.Drawing.Point(7, 184);
            this.BtnGet.Name = "BtnGet";
            this.BtnGet.Size = new System.Drawing.Size(157, 30);
            this.BtnGet.TabIndex = 2;
            this.BtnGet.Text = "Получить";
            this.BtnGet.UseVisualStyleBackColor = true;
            this.BtnGet.Click += new System.EventHandler(this.BtnGet_Click);
            // 
            // BtnAddPurchase
            // 
            this.BtnAddPurchase.Location = new System.Drawing.Point(10, 28);
            this.BtnAddPurchase.Name = "BtnAddPurchase";
            this.BtnAddPurchase.Size = new System.Drawing.Size(221, 30);
            this.BtnAddPurchase.TabIndex = 3;
            this.BtnAddPurchase.Text = "Добавить покупку";
            this.BtnAddPurchase.UseVisualStyleBackColor = true;
            this.BtnAddPurchase.Click += new System.EventHandler(this.BtnAddPurchase_Click);
            // 
            // BtnListPurchase
            // 
            this.BtnListPurchase.Location = new System.Drawing.Point(10, 64);
            this.BtnListPurchase.Name = "BtnListPurchase";
            this.BtnListPurchase.Size = new System.Drawing.Size(221, 30);
            this.BtnListPurchase.TabIndex = 4;
            this.BtnListPurchase.Text = "Список покупок";
            this.BtnListPurchase.UseVisualStyleBackColor = true;
            this.BtnListPurchase.Click += new System.EventHandler(this.BtnListPurchase_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.BtnAddPurchase);
            this.groupBox3.Controls.Add(this.BtnListPurchase);
            this.groupBox3.Location = new System.Drawing.Point(12, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 110);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Работа с покупками";
            // 
            // BtnCloseApplication
            // 
            this.BtnCloseApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCloseApplication.Location = new System.Drawing.Point(681, 369);
            this.BtnCloseApplication.Name = "BtnCloseApplication";
            this.BtnCloseApplication.Size = new System.Drawing.Size(221, 30);
            this.BtnCloseApplication.TabIndex = 5;
            this.BtnCloseApplication.Text = "Закрыть";
            this.BtnCloseApplication.UseVisualStyleBackColor = false;
            this.BtnCloseApplication.Click += new System.EventHandler(this.BtnCloseApplication_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 413);
            this.Controls.Add(this.BtnCloseApplication);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestTask";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbClients)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAddClient;
        private System.Windows.Forms.TextBox TbxPatronymic;
        private System.Windows.Forms.TextBox TbxFirstname;
        private System.Windows.Forms.TextBox TbxLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgbClients;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnGet;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button BtnAddAdvantedInfo;
        private System.Windows.Forms.Button BtnAddPurchase;
        private System.Windows.Forms.Button BtnListPurchase;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnCloseApplication;
    }
}

