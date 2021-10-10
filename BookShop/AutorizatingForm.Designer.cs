
namespace BookShop
{
    partial class AutorizatingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.logLbl = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.paswwordTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.newUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // logLbl
            // 
            this.logLbl.AutoSize = true;
            this.logLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logLbl.Location = new System.Drawing.Point(12, 49);
            this.logLbl.Name = "logLbl";
            this.logLbl.Size = new System.Drawing.Size(44, 15);
            this.logLbl.TabIndex = 1;
            this.logLbl.Text = "Логин:";
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(62, 46);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.PlaceholderText = "Login";
            this.LoginTB.Size = new System.Drawing.Size(158, 23);
            this.LoginTB.TabIndex = 2;
            // 
            // paswwordTB
            // 
            this.paswwordTB.Location = new System.Drawing.Point(63, 88);
            this.paswwordTB.Name = "paswwordTB";
            this.paswwordTB.PasswordChar = '*';
            this.paswwordTB.PlaceholderText = "Password";
            this.paswwordTB.Size = new System.Drawing.Size(157, 23);
            this.paswwordTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(12, 136);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(208, 23);
            this.EnterBtn.TabIndex = 5;
            this.EnterBtn.Text = "Войти";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // newUserBtn
            // 
            this.newUserBtn.Location = new System.Drawing.Point(12, 165);
            this.newUserBtn.Name = "newUserBtn";
            this.newUserBtn.Size = new System.Drawing.Size(208, 23);
            this.newUserBtn.TabIndex = 6;
            this.newUserBtn.Text = "Новый пользователь";
            this.newUserBtn.UseVisualStyleBackColor = true;
            this.newUserBtn.Click += new System.EventHandler(this.newUserBtn_Click);
            // 
            // AutorizatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 197);
            this.Controls.Add(this.newUserBtn);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.paswwordTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.logLbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AutorizatingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label logLbl;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox paswwordTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Button newUserBtn;
    }
}

