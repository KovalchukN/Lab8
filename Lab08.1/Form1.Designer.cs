namespace Lab08._1
{
    partial class fMain
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
            this.btnAddSub = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbSubInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddSub
            // 
            this.btnAddSub.Location = new System.Drawing.Point(795, 139);
            this.btnAddSub.Name = "btnAddSub";
            this.btnAddSub.Size = new System.Drawing.Size(114, 35);
            this.btnAddSub.TabIndex = 1;
            this.btnAddSub.Text = "Добавить";
            this.btnAddSub.UseVisualStyleBackColor = true;
            this.btnAddSub.Click += new System.EventHandler(this.btnAddSub_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(795, 262);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbSubInfo
            // 
            this.lbSubInfo.FormattingEnabled = true;
            this.lbSubInfo.ItemHeight = 16;
            this.lbSubInfo.Location = new System.Drawing.Point(14, 24);
            this.lbSubInfo.Name = "lbSubInfo";
            this.lbSubInfo.Size = new System.Drawing.Size(738, 452);
            this.lbSubInfo.TabIndex = 3;
            this.lbSubInfo.SelectedIndexChanged += new System.EventHandler(this.lbSubInfo_SelectedIndexChanged);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 481);
            this.Controls.Add(this.lbSubInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddSub);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab8";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddSub;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbSubInfo;
    }
}

