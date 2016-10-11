namespace DBImport
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlConsole = new System.Windows.Forms.Panel();
            this.pnlWorkArea = new System.Windows.Forms.Panel();
            this.bbRun = new System.Windows.Forms.Button();
            this.bbCancel = new System.Windows.Forms.Button();
            this.pnlConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConsole
            // 
            this.pnlConsole.Controls.Add(this.bbCancel);
            this.pnlConsole.Controls.Add(this.bbRun);
            this.pnlConsole.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConsole.ForeColor = System.Drawing.Color.Black;
            this.pnlConsole.Location = new System.Drawing.Point(0, 0);
            this.pnlConsole.Name = "pnlConsole";
            this.pnlConsole.Size = new System.Drawing.Size(585, 54);
            this.pnlConsole.TabIndex = 0;
            // 
            // pnlWorkArea
            // 
            this.pnlWorkArea.Location = new System.Drawing.Point(26, 143);
            this.pnlWorkArea.Name = "pnlWorkArea";
            this.pnlWorkArea.Size = new System.Drawing.Size(200, 100);
            this.pnlWorkArea.TabIndex = 1;
            // 
            // bbRun
            // 
            this.bbRun.ForeColor = System.Drawing.Color.Black;
            this.bbRun.Location = new System.Drawing.Point(12, 12);
            this.bbRun.Name = "bbRun";
            this.bbRun.Size = new System.Drawing.Size(75, 30);
            this.bbRun.TabIndex = 0;
            this.bbRun.Text = "Выполнить";
            this.bbRun.UseVisualStyleBackColor = true;
            this.bbRun.Click += new System.EventHandler(this.bbRun_Click);
            // 
            // bbCancel
            // 
            this.bbCancel.Location = new System.Drawing.Point(93, 12);
            this.bbCancel.Name = "bbCancel";
            this.bbCancel.Size = new System.Drawing.Size(75, 30);
            this.bbCancel.TabIndex = 1;
            this.bbCancel.Text = "Отмена";
            this.bbCancel.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 262);
            this.Controls.Add(this.pnlWorkArea);
            this.Controls.Add(this.pnlConsole);
            this.Name = "MainForm";
            this.Text = "DBImport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlConsole.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConsole;
        private System.Windows.Forms.Panel pnlWorkArea;
        private System.Windows.Forms.Button bbCancel;
        private System.Windows.Forms.Button bbRun;
    }
}

