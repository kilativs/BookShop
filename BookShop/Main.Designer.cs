
namespace BookShop
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sumLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.countBooksLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userLoginLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.authorSearchTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.genreSearchTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nameSearchTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descountDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 401);
            this.panel1.TabIndex = 2;
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
            this.nameDG,
            this.authorDG,
            this.publisherDG,
            this.genreDG,
            this.yearDG,
            this.saleDG,
            this.descountDG});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(774, 401);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.sumLbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.countBooksLbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.userLoginLbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(782, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 154);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Приветсвую!";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(102, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "грн.";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(132, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 26);
            this.button4.TabIndex = 8;
            this.button4.Text = "Оплатить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Выйти/Сменить пользователя";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sumLbl
            // 
            this.sumLbl.AutoSize = true;
            this.sumLbl.Location = new System.Drawing.Point(67, 80);
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(13, 15);
            this.sumLbl.TabIndex = 5;
            this.sumLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "На суму:";
            // 
            // countBooksLbl
            // 
            this.countBooksLbl.AutoSize = true;
            this.countBooksLbl.Location = new System.Drawing.Point(113, 51);
            this.countBooksLbl.Name = "countBooksLbl";
            this.countBooksLbl.Size = new System.Drawing.Size(13, 15);
            this.countBooksLbl.TabIndex = 3;
            this.countBooksLbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выбрано книг:";
            // 
            // userLoginLbl
            // 
            this.userLoginLbl.AutoSize = true;
            this.userLoginLbl.Location = new System.Drawing.Point(113, 23);
            this.userLoginLbl.Name = "userLoginLbl";
            this.userLoginLbl.Size = new System.Drawing.Size(38, 15);
            this.userLoginLbl.TabIndex = 1;
            this.userLoginLbl.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы вошли как:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.authorSearchTb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.genreSearchTb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nameSearchTb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(782, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 240);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск книг";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(7, 211);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(187, 23);
            this.searchBtn.TabIndex = 11;
            this.searchBtn.Text = "Найти";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // authorSearchTb
            // 
            this.authorSearchTb.Location = new System.Drawing.Point(17, 130);
            this.authorSearchTb.Name = "authorSearchTb";
            this.authorSearchTb.Size = new System.Drawing.Size(177, 23);
            this.authorSearchTb.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Авторы:";
            // 
            // genreSearchTb
            // 
            this.genreSearchTb.Location = new System.Drawing.Point(17, 86);
            this.genreSearchTb.Name = "genreSearchTb";
            this.genreSearchTb.Size = new System.Drawing.Size(177, 23);
            this.genreSearchTb.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Жанры:";
            // 
            // nameSearchTb
            // 
            this.nameSearchTb.Location = new System.Drawing.Point(17, 42);
            this.nameSearchTb.Name = "nameSearchTb";
            this.nameSearchTb.Size = new System.Drawing.Size(177, 23);
            this.nameSearchTb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Название:";
            // 
            // idDG
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idDG.DefaultCellStyle = dataGridViewCellStyle2;
            this.idDG.Frozen = true;
            this.idDG.HeaderText = "Код";
            this.idDG.MaxInputLength = 15;
            this.idDG.Name = "idDG";
            this.idDG.ReadOnly = true;
            this.idDG.Width = 40;
            // 
            // nameDG
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nameDG.DefaultCellStyle = dataGridViewCellStyle3;
            this.nameDG.Frozen = true;
            this.nameDG.HeaderText = "Название книги";
            this.nameDG.Name = "nameDG";
            this.nameDG.ReadOnly = true;
            this.nameDG.Width = 200;
            // 
            // authorDG
            // 
            this.authorDG.HeaderText = "Автор";
            this.authorDG.Name = "authorDG";
            this.authorDG.ReadOnly = true;
            this.authorDG.Width = 120;
            // 
            // publisherDG
            // 
            this.publisherDG.HeaderText = "Издательство";
            this.publisherDG.Name = "publisherDG";
            this.publisherDG.ReadOnly = true;
            // 
            // genreDG
            // 
            this.genreDG.HeaderText = "Жанр";
            this.genreDG.Name = "genreDG";
            this.genreDG.ReadOnly = true;
            // 
            // yearDG
            // 
            this.yearDG.HeaderText = "Год издательства";
            this.yearDG.Name = "yearDG";
            this.yearDG.ReadOnly = true;
            this.yearDG.Width = 90;
            // 
            // saleDG
            // 
            this.saleDG.HeaderText = "Цена, грн";
            this.saleDG.Name = "saleDG";
            this.saleDG.ReadOnly = true;
            this.saleDG.Width = 60;
            // 
            // descountDG
            // 
            this.descountDG.HeaderText = "Скидка";
            this.descountDG.Name = "descountDG";
            this.descountDG.ReadOnly = true;
            this.descountDG.Width = 65;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(996, 408);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Книжний магазин";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label sumLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label countBooksLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userLoginLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox authorSearchTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox genreSearchTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameSearchTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn descountDG;
    }
}