namespace TestTask
{
    partial class FormPurchases
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
            this.DgbPurchases = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbFieldSort = new System.Windows.Forms.ComboBox();
            this.CmbOrderliness = new System.Windows.Forms.ComboBox();
            this.CbxSort = new System.Windows.Forms.CheckBox();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgbPurchases)).BeginInit();
            this.SuspendLayout();
            // 
            // DgbPurchases
            // 
            this.DgbPurchases.AllowUserToAddRows = false;
            this.DgbPurchases.AllowUserToDeleteRows = false;
            this.DgbPurchases.AllowUserToResizeColumns = false;
            this.DgbPurchases.AllowUserToResizeRows = false;
            this.DgbPurchases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgbPurchases.BackgroundColor = System.Drawing.Color.White;
            this.DgbPurchases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgbPurchases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgbPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbPurchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4});
            this.DgbPurchases.Location = new System.Drawing.Point(12, 103);
            this.DgbPurchases.Name = "DgbPurchases";
            this.DgbPurchases.ReadOnly = true;
            this.DgbPurchases.RowHeadersVisible = false;
            this.DgbPurchases.RowTemplate.Height = 100;
            this.DgbPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgbPurchases.Size = new System.Drawing.Size(903, 339);
            this.DgbPurchases.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата покупки";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Клиент";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Сумма чека";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Фото покупки";
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поле для сортировки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сортировать по:";
            // 
            // CmbFieldSort
            // 
            this.CmbFieldSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFieldSort.FormattingEnabled = true;
            this.CmbFieldSort.Items.AddRange(new object[] {
            "Дата покупки",
            "Сумма чека"});
            this.CmbFieldSort.Location = new System.Drawing.Point(196, 51);
            this.CmbFieldSort.Name = "CmbFieldSort";
            this.CmbFieldSort.Size = new System.Drawing.Size(235, 29);
            this.CmbFieldSort.TabIndex = 3;
            this.CmbFieldSort.SelectedIndexChanged += new System.EventHandler(this.CmbFieldSort_SelectedIndexChanged);
            // 
            // CmbOrderliness
            // 
            this.CmbOrderliness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOrderliness.FormattingEnabled = true;
            this.CmbOrderliness.Items.AddRange(new object[] {
            "Возрастанию",
            "Убыванию"});
            this.CmbOrderliness.Location = new System.Drawing.Point(580, 51);
            this.CmbOrderliness.Name = "CmbOrderliness";
            this.CmbOrderliness.Size = new System.Drawing.Size(207, 29);
            this.CmbOrderliness.TabIndex = 4;
            this.CmbOrderliness.SelectedIndexChanged += new System.EventHandler(this.CmbOrderliness_SelectedIndexChanged);
            // 
            // CbxSort
            // 
            this.CbxSort.AutoSize = true;
            this.CbxSort.Location = new System.Drawing.Point(12, 12);
            this.CbxSort.Name = "CbxSort";
            this.CbxSort.Size = new System.Drawing.Size(121, 25);
            this.CbxSort.TabIndex = 5;
            this.CbxSort.Text = "Сортировка";
            this.CbxSort.UseVisualStyleBackColor = true;
            this.CbxSort.CheckedChanged += new System.EventHandler(this.CbxSort_CheckedChanged);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(748, 448);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(167, 30);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Закрыть";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // FormPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(927, 490);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.CbxSort);
            this.Controls.Add(this.CmbOrderliness);
            this.Controls.Add(this.CmbFieldSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgbPurchases);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(943, 529);
            this.Name = "FormPurchases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список покупок";
            this.Load += new System.EventHandler(this.FormPurchases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgbPurchases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgbPurchases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbFieldSort;
        private System.Windows.Forms.ComboBox CmbOrderliness;
        private System.Windows.Forms.CheckBox CbxSort;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
    }
}