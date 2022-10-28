namespace Avia_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 97);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(150, 44);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Авторизация";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(12, 147);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(150, 44);
            this.buttonReg.TabIndex = 1;
            this.buttonReg.Text = "Регистрация";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textPassword.Location = new System.Drawing.Point(12, 56);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(150, 35);
            this.textPassword.TabIndex = 2;
            this.textPassword.Text = "Пароль";
            this.textPassword.Click += new System.EventHandler(this.textPassword_Click);
            // 
            // textLogin
            // 
            this.textLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textLogin.Location = new System.Drawing.Point(12, 15);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(150, 35);
            this.textLogin.TabIndex = 3;
            this.textLogin.Text = "Логин";
            this.textLogin.Click += new System.EventHandler(this.textLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Avia_2.Properties.Resources._SVQrbUs;
            this.ClientSize = new System.Drawing.Size(173, 200);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonLogin;
        private Button buttonReg;
        private TextBox textPassword;
        private TextBox textLogin;
    }
}