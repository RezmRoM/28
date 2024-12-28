namespace Project1
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.familyBox = new System.Windows.Forms.TextBox();
            this.otchestvoBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(187, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Пароль:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(108, 93);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 6;
            // 
            // familyBox
            // 
            this.familyBox.Location = new System.Drawing.Point(108, 128);
            this.familyBox.Name = "familyBox";
            this.familyBox.Size = new System.Drawing.Size(100, 20);
            this.familyBox.TabIndex = 7;
            // 
            // otchestvoBox
            // 
            this.otchestvoBox.Location = new System.Drawing.Point(108, 163);
            this.otchestvoBox.Name = "otchestvoBox";
            this.otchestvoBox.Size = new System.Drawing.Size(100, 20);
            this.otchestvoBox.TabIndex = 8;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(337, 125);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 10;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(337, 90);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 20);
            this.emailBox.TabIndex = 11;
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(177, 219);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(140, 23);
            this.regButton.TabIndex = 12;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(484, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 290);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.otchestvoBox);
            this.Controls.Add(this.familyBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox familyBox;
        private System.Windows.Forms.TextBox otchestvoBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Button backButton;
    }
}