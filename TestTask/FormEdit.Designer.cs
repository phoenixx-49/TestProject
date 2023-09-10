namespace TestTask
{
    partial class FormEdit
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
            this.BtnSaveChanges = new System.Windows.Forms.Button();
            this.TbxPatronymic = new System.Windows.Forms.TextBox();
            this.TbxFirstname = new System.Windows.Forms.TextBox();
            this.TbxLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSaveChanges
            // 
            this.BtnSaveChanges.Location = new System.Drawing.Point(12, 193);
            this.BtnSaveChanges.Name = "BtnSaveChanges";
            this.BtnSaveChanges.Size = new System.Drawing.Size(243, 30);
            this.BtnSaveChanges.TabIndex = 7;
            this.BtnSaveChanges.Text = "Сохранить";
            this.BtnSaveChanges.UseVisualStyleBackColor = true;
            this.BtnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // TbxPatronymic
            // 
            this.TbxPatronymic.Location = new System.Drawing.Point(16, 145);
            this.TbxPatronymic.Name = "TbxPatronymic";
            this.TbxPatronymic.Size = new System.Drawing.Size(196, 29);
            this.TbxPatronymic.TabIndex = 6;
            // 
            // TbxFirstname
            // 
            this.TbxFirstname.Location = new System.Drawing.Point(16, 89);
            this.TbxFirstname.Name = "TbxFirstname";
            this.TbxFirstname.Size = new System.Drawing.Size(196, 29);
            this.TbxFirstname.TabIndex = 4;
            // 
            // TbxLastname
            // 
            this.TbxLastname.Location = new System.Drawing.Point(16, 33);
            this.TbxLastname.Name = "TbxLastname";
            this.TbxLastname.Size = new System.Drawing.Size(196, 29);
            this.TbxLastname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            // 
            // FormEdit
            // 
            this.AcceptButton = this.BtnSaveChanges;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(279, 237);
            this.Controls.Add(this.BtnSaveChanges);
            this.Controls.Add(this.TbxPatronymic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxFirstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxLastname);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование клиента";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSaveChanges;
        private System.Windows.Forms.TextBox TbxPatronymic;
        private System.Windows.Forms.TextBox TbxFirstname;
        private System.Windows.Forms.TextBox TbxLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}