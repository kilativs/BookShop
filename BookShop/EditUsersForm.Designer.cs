
namespace BookShop
{
    partial class EditUsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.delUserBtn = new System.Windows.Forms.Button();
            this.editUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDG,
            this.loginDG,
            this.pasDG,
            this.firstNameDG,
            this.lastNameDG,
            this.addressDG,
            this.emailDG,
            this.phoneDG,
            this.roleDG});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(772, 196);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDG
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idDG.DefaultCellStyle = dataGridViewCellStyle2;
            this.idDG.Frozen = true;
            this.idDG.HeaderText = "Id";
            this.idDG.MaxInputLength = 15;
            this.idDG.Name = "idDG";
            this.idDG.ReadOnly = true;
            this.idDG.Width = 40;
            // 
            // loginDG
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.loginDG.DefaultCellStyle = dataGridViewCellStyle3;
            this.loginDG.Frozen = true;
            this.loginDG.HeaderText = "Логин";
            this.loginDG.Name = "loginDG";
            this.loginDG.ReadOnly = true;
            this.loginDG.Width = 75;
            // 
            // pasDG
            // 
            this.pasDG.Frozen = true;
            this.pasDG.HeaderText = "Пароль";
            this.pasDG.Name = "pasDG";
            this.pasDG.ReadOnly = true;
            this.pasDG.Width = 75;
            // 
            // firstNameDG
            // 
            this.firstNameDG.Frozen = true;
            this.firstNameDG.HeaderText = "Имя";
            this.firstNameDG.Name = "firstNameDG";
            this.firstNameDG.ReadOnly = true;
            this.firstNameDG.Width = 70;
            // 
            // lastNameDG
            // 
            this.lastNameDG.Frozen = true;
            this.lastNameDG.HeaderText = "Фамилия";
            this.lastNameDG.Name = "lastNameDG";
            this.lastNameDG.ReadOnly = true;
            this.lastNameDG.Width = 70;
            // 
            // addressDG
            // 
            this.addressDG.Frozen = true;
            this.addressDG.HeaderText = "Адрес";
            this.addressDG.Name = "addressDG";
            this.addressDG.ReadOnly = true;
            this.addressDG.Width = 120;
            // 
            // emailDG
            // 
            this.emailDG.HeaderText = "Email";
            this.emailDG.Name = "emailDG";
            this.emailDG.ReadOnly = true;
            this.emailDG.Width = 135;
            // 
            // phoneDG
            // 
            this.phoneDG.HeaderText = "Телефон";
            this.phoneDG.Name = "phoneDG";
            this.phoneDG.ReadOnly = true;
            this.phoneDG.Width = 115;
            // 
            // roleDG
            // 
            this.roleDG.HeaderText = "Роль";
            this.roleDG.Name = "roleDG";
            this.roleDG.ReadOnly = true;
            this.roleDG.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exitBtn);
            this.groupBox1.Controls.Add(this.delUserBtn);
            this.groupBox1.Controls.Add(this.editUserBtn);
            this.groupBox1.Location = new System.Drawing.Point(1, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактировать базу";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(568, 22);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(184, 42);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Выйти";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // delUserBtn
            // 
            this.delUserBtn.Location = new System.Drawing.Point(279, 22);
            this.delUserBtn.Name = "delUserBtn";
            this.delUserBtn.Size = new System.Drawing.Size(230, 42);
            this.delUserBtn.TabIndex = 1;
            this.delUserBtn.Text = "Удалить";
            this.delUserBtn.UseVisualStyleBackColor = true;
            this.delUserBtn.Click += new System.EventHandler(this.delUserBtn_Click);
            // 
            // editUserBtn
            // 
            this.editUserBtn.Location = new System.Drawing.Point(23, 22);
            this.editUserBtn.Name = "editUserBtn";
            this.editUserBtn.Size = new System.Drawing.Size(195, 42);
            this.editUserBtn.TabIndex = 0;
            this.editUserBtn.Text = "Редактировать";
            this.editUserBtn.UseVisualStyleBackColor = true;
            this.editUserBtn.Click += new System.EventHandler(this.editUserBtn_Click);
            // 
            // EditUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 294);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditUsersForm";
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.EditUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delUserBtn;
        private System.Windows.Forms.Button editUserBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDG;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}