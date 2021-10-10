
namespace BookShop
{
    partial class RegForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pasStatusLbl = new System.Windows.Forms.Label();
            this.repeatPassTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.phoneTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.adressTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lastNameTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.firstNameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.regBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pasStatusLbl);
            this.groupBox1.Controls.Add(this.repeatPassTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.passTb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.logTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Обязательные данные";
            // 
            // pasStatusLbl
            // 
            this.pasStatusLbl.AutoSize = true;
            this.pasStatusLbl.Location = new System.Drawing.Point(7, 123);
            this.pasStatusLbl.Name = "pasStatusLbl";
            this.pasStatusLbl.Size = new System.Drawing.Size(0, 15);
            this.pasStatusLbl.TabIndex = 6;
            // 
            // repeatPassTb
            // 
            this.repeatPassTb.Location = new System.Drawing.Point(118, 81);
            this.repeatPassTb.Name = "repeatPassTb";
            this.repeatPassTb.PasswordChar = '*';
            this.repeatPassTb.Size = new System.Drawing.Size(159, 23);
            this.repeatPassTb.TabIndex = 5;
            this.repeatPassTb.TextChanged += new System.EventHandler(this.passBtn_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Повторить пароль:";
            // 
            // passTb
            // 
            this.passTb.Location = new System.Drawing.Point(118, 52);
            this.passTb.Name = "passTb";
            this.passTb.PasswordChar = '*';
            this.passTb.Size = new System.Drawing.Size(159, 23);
            this.passTb.TabIndex = 3;
            this.passTb.TextChanged += new System.EventHandler(this.passBtn_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // logTb
            // 
            this.logTb.Location = new System.Drawing.Point(118, 23);
            this.logTb.Name = "logTb";
            this.logTb.Size = new System.Drawing.Size(159, 23);
            this.logTb.TabIndex = 1;
            this.logTb.TextChanged += new System.EventHandler(this.logBtn_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Логин:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Форма регистрации";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.phoneTb);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.adressTb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.emailTb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lastNameTb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.firstNameTb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 174);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Личная информация";
            // 
            // phoneTb
            // 
            this.phoneTb.Location = new System.Drawing.Point(71, 136);
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.Size = new System.Drawing.Size(206, 23);
            this.phoneTb.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Телефон:";
            // 
            // adressTb
            // 
            this.adressTb.Location = new System.Drawing.Point(71, 107);
            this.adressTb.Name = "adressTb";
            this.adressTb.Size = new System.Drawing.Size(206, 23);
            this.adressTb.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Адрес:";
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(71, 78);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(206, 23);
            this.emailTb.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "E-mail:";
            // 
            // lastNameTb
            // 
            this.lastNameTb.Location = new System.Drawing.Point(71, 52);
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.Size = new System.Drawing.Size(206, 23);
            this.lastNameTb.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Фамилия:";
            // 
            // firstNameTb
            // 
            this.firstNameTb.Location = new System.Drawing.Point(71, 22);
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.Size = new System.Drawing.Size(206, 23);
            this.firstNameTb.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Имя:";
            // 
            // regBtn
            // 
            this.regBtn.Enabled = false;
            this.regBtn.Location = new System.Drawing.Point(12, 376);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(283, 23);
            this.regBtn.TabIndex = 3;
            this.regBtn.Text = "Подтвердить";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(13, 406);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(282, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 435);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegForm";
            this.Text = "Регистрация";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label pasStatusLbl;
        private System.Windows.Forms.TextBox repeatPassTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox logTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox phoneTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox adressTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lastNameTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstNameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}