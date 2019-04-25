namespace TestApp
{
    partial class RegisterForm
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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RepeatPasswordLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.RepeatPasswordText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.LoadPictureButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ShowPasswordCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
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
            this.PasswordLabel.Location = new System.Drawing.Point(12, 38);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.AutoSize = true;
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(12, 64);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(86, 13);
            this.RepeatPasswordLabel.TabIndex = 2;
            this.RepeatPasswordLabel.Text = "Повтор пароля:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(12, 91);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(40, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Почта:";
            // 
            // LoginText
            // 
            this.LoginText.Location = new System.Drawing.Point(104, 6);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(100, 20);
            this.LoginText.TabIndex = 4;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(104, 35);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(100, 20);
            this.PasswordText.TabIndex = 5;
            // 
            // RepeatPasswordText
            // 
            this.RepeatPasswordText.Location = new System.Drawing.Point(104, 61);
            this.RepeatPasswordText.Name = "RepeatPasswordText";
            this.RepeatPasswordText.Size = new System.Drawing.Size(100, 20);
            this.RepeatPasswordText.TabIndex = 6;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(104, 88);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(100, 20);
            this.EmailText.TabIndex = 7;
            // 
            // UserPicture
            // 
            this.UserPicture.Location = new System.Drawing.Point(15, 114);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(100, 100);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPicture.TabIndex = 8;
            this.UserPicture.TabStop = false;
            // 
            // LoadPictureButton
            // 
            this.LoadPictureButton.Location = new System.Drawing.Point(129, 114);
            this.LoadPictureButton.Name = "LoadPictureButton";
            this.LoadPictureButton.Size = new System.Drawing.Size(75, 23);
            this.LoadPictureButton.TabIndex = 9;
            this.LoadPictureButton.Text = "Обзор...";
            this.LoadPictureButton.UseVisualStyleBackColor = true;
            this.LoadPictureButton.Click += new System.EventHandler(this.LoadPictureButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(142, 220);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(62, 23);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(15, 220);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(121, 23);
            this.RegisterButton.TabIndex = 11;
            this.RegisterButton.Text = "Зарегистрироваться";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ShowPasswordCheck
            // 
            this.ShowPasswordCheck.AutoSize = true;
            this.ShowPasswordCheck.Location = new System.Drawing.Point(210, 38);
            this.ShowPasswordCheck.Name = "ShowPasswordCheck";
            this.ShowPasswordCheck.Size = new System.Drawing.Size(15, 14);
            this.ShowPasswordCheck.TabIndex = 12;
            this.ShowPasswordCheck.UseVisualStyleBackColor = true;
            this.ShowPasswordCheck.CheckedChanged += new System.EventHandler(this.ShowPasswordCheck_CheckedChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 251);
            this.ControlBox = false;
            this.Controls.Add(this.ShowPasswordCheck);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.LoadPictureButton);
            this.Controls.Add(this.UserPicture);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.RepeatPasswordText);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegisterForm";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label RepeatPasswordLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox RepeatPasswordText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.PictureBox UserPicture;
        private System.Windows.Forms.Button LoadPictureButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.CheckBox ShowPasswordCheck;
    }
}