namespace TestApp
{
    partial class LoginForm
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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RegiserLink = new System.Windows.Forms.LinkLabel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(12, 9);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(41, 13);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Логин:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 40);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // RegiserLink
            // 
            this.RegiserLink.AutoSize = true;
            this.RegiserLink.Location = new System.Drawing.Point(32, 67);
            this.RegiserLink.Name = "RegiserLink";
            this.RegiserLink.Size = new System.Drawing.Size(113, 13);
            this.RegiserLink.TabIndex = 2;
            this.RegiserLink.TabStop = true;
            this.RegiserLink.Text = "Зарегистрироваться";
            this.RegiserLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegiserLink_LinkClicked);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(12, 83);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(93, 83);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginText
            // 
            this.LoginText.Location = new System.Drawing.Point(59, 6);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(100, 20);
            this.LoginText.TabIndex = 5;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(59, 37);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(100, 20);
            this.PasswordText.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 118);
            this.ControlBox = false;
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RegiserLink);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.LinkLabel RegiserLink;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.TextBox PasswordText;
    }
}

