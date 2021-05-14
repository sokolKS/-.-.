
namespace lab_4
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
            this.btnAddTab = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbTabsInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddTab
            // 
            this.btnAddTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTab.Location = new System.Drawing.Point(413, 12);
            this.btnAddTab.Name = "btnAddTab";
            this.btnAddTab.Size = new System.Drawing.Size(150, 30);
            this.btnAddTab.TabIndex = 0;
            this.btnAddTab.Text = "Додати планшет";
            this.btnAddTab.UseVisualStyleBackColor = true;
            this.btnAddTab.Click += new System.EventHandler(this.btnAddCPU_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(413, 48);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbTabsInfo
            // 
            this.tbTabsInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbTabsInfo.Location = new System.Drawing.Point(0, 0);
            this.tbTabsInfo.Multiline = true;
            this.tbTabsInfo.Name = "tbTabsInfo";
            this.tbTabsInfo.ReadOnly = true;
            this.tbTabsInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTabsInfo.Size = new System.Drawing.Size(400, 453);
            this.tbTabsInfo.TabIndex = 2;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(575, 453);
            this.Controls.Add(this.tbTabsInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddTab);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTab;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbTabsInfo;
    }
}

