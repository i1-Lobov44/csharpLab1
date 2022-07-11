namespace Lab_1
{
    partial class FormUsers
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
            this.UserData = new System.Windows.Forms.DataGridView();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Pagenumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserData)).BeginInit();
            this.SuspendLayout();
            // 
            // UserData
            // 
            this.UserData.AllowUserToAddRows = false;
            this.UserData.AllowUserToDeleteRows = false;
            this.UserData.AllowUserToResizeColumns = false;
            this.UserData.AllowUserToResizeRows = false;
            this.UserData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UserData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.UserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.UserName,
            this.Surname,
            this.PhoneNumber,
            this.Email});
            this.UserData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UserData.Location = new System.Drawing.Point(12, 21);
            this.UserData.Name = "UserData";
            this.UserData.ReadOnly = true;
            this.UserData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UserData.RowHeadersVisible = false;
            this.UserData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UserData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.UserData.Size = new System.Drawing.Size(776, 305);
            this.UserData.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "login";
            this.Login.HeaderText = "Логин";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "name";
            this.UserName.HeaderText = "Имя";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "surname";
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "phoneNumber";
            this.PhoneNumber.HeaderText = "Телефон";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // UserAdd
            // 
            this.UserAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserAdd.Location = new System.Drawing.Point(433, 374);
            this.UserAdd.Name = "UserAdd";
            this.UserAdd.Size = new System.Drawing.Size(108, 28);
            this.UserAdd.TabIndex = 1;
            this.UserAdd.Text = "Добавить пользователя";
            this.UserAdd.UseVisualStyleBackColor = true;
            this.UserAdd.Click += new System.EventHandler(this.UserAdd_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(547, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить пользователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 21);
            this.button2.TabIndex = 3;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 21);
            this.button3.TabIndex = 4;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Pagenumber
            // 
            this.Pagenumber.AutoSize = true;
            this.Pagenumber.Location = new System.Drawing.Point(150, 383);
            this.Pagenumber.Name = "Pagenumber";
            this.Pagenumber.Size = new System.Drawing.Size(24, 13);
            this.Pagenumber.TabIndex = 5;
            this.Pagenumber.Text = "0/0";
            this.Pagenumber.Click += new System.EventHandler(this.Pagenumber_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pagenumber);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserAdd);
            this.Controls.Add(this.UserData);
            this.Name = "FormUsers";
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserData;
        private System.Windows.Forms.Button UserAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Pagenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

