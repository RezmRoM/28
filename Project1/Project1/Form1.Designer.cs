namespace Project1
{
    partial class Form1
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
            this.authButton = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authButton
            // 
            this.authButton.Location = new System.Drawing.Point(74, 75);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(128, 23);
            this.authButton.TabIndex = 0;
            this.authButton.Text = "Авторизоваться";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(74, 113);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(128, 23);
            this.regButton.TabIndex = 1;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Главное меню";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 184);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.authButton);
            this.Name = "Form1";
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Label label1;
    }
}

