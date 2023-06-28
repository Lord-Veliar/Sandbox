namespace Sandbox_Club
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.FFF = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Pass2 = new System.Windows.Forms.TextBox();
            this.Reg = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.DataRozd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(516, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // NameText
            // 
            this.NameText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(479, 118);
            this.NameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(381, 31);
            this.NameText.TabIndex = 1;
            this.NameText.Text = "Имя";
            this.NameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameText.Enter += new System.EventHandler(this.Name_TextEnter);
            this.NameText.Leave += new System.EventHandler(this.Name_TextLeave);
            // 
            // FFF
            // 
            this.FFF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FFF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FFF.Location = new System.Drawing.Point(479, 180);
            this.FFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FFF.Name = "FFF";
            this.FFF.Size = new System.Drawing.Size(381, 31);
            this.FFF.TabIndex = 2;
            this.FFF.Text = "Фамилия";
            this.FFF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FFF.TextChanged += new System.EventHandler(this.FFF_TextChanged);
            this.FFF.Enter += new System.EventHandler(this.FFF_TextEnter);
            this.FFF.Leave += new System.EventHandler(this.FFF_TextLeave);
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(479, 346);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(381, 31);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Enter += new System.EventHandler(this.Email_TextEnter);
            this.Email.Leave += new System.EventHandler(this.Email_TextLeave);
            // 
            // Pass
            // 
            this.Pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass.Location = new System.Drawing.Point(479, 407);
            this.Pass.Margin = new System.Windows.Forms.Padding(4);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(381, 31);
            this.Pass.TabIndex = 5;
            this.Pass.Text = "Пароль";
            this.Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pass.TextChanged += new System.EventHandler(this.Pass_TextChanged);
            this.Pass.Enter += new System.EventHandler(this.Pass_TextEnter);
            this.Pass.Leave += new System.EventHandler(this.Pass_TextLeave);
            // 
            // Pass2
            // 
            this.Pass2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pass2.BackColor = System.Drawing.Color.White;
            this.Pass2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass2.Location = new System.Drawing.Point(479, 542);
            this.Pass2.Margin = new System.Windows.Forms.Padding(4);
            this.Pass2.Name = "Pass2";
            this.Pass2.Size = new System.Drawing.Size(381, 31);
            this.Pass2.TabIndex = 6;
            this.Pass2.Text = "Повторите пароль";
            this.Pass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pass2.TextChanged += new System.EventHandler(this.Pass2_TextChanged);
            this.Pass2.Enter += new System.EventHandler(this.Pass2_TextEnter);
            this.Pass2.Leave += new System.EventHandler(this.Pass2_TextLeave);
            // 
            // Reg
            // 
            this.Reg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(219)))), ((int)(((byte)(58)))));
            this.Reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reg.FlatAppearance.BorderSize = 0;
            this.Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reg.ForeColor = System.Drawing.Color.Black;
            this.Reg.Location = new System.Drawing.Point(479, 614);
            this.Reg.Margin = new System.Windows.Forms.Padding(4);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(381, 64);
            this.Reg.TabIndex = 7;
            this.Reg.Text = "Зарегистрироваться";
            this.Reg.UseMnemonic = false;
            this.Reg.UseVisualStyleBackColor = false;
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(564, 682);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(225, 29);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Уже есть аккаунт?";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DataRozd
            // 
            this.DataRozd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DataRozd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataRozd.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataRozd.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(88)))));
            this.DataRozd.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(40)))));
            this.DataRozd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataRozd.Location = new System.Drawing.Point(479, 288);
            this.DataRozd.Name = "DataRozd";
            this.DataRozd.Size = new System.Drawing.Size(381, 38);
            this.DataRozd.TabIndex = 9;
            this.DataRozd.Value = new System.DateTime(2023, 6, 10, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(570, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(475, 442);
            this.label3.MaximumSize = new System.Drawing.Size(400, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 60);
            this.label3.TabIndex = 11;
            this.label3.Text = "Пароль должен содержать не менее 6 символов, 1 заглавный символ, 1 прописной симв" +
    "ол, 1 цифра и специальный символ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(245)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(1363, 718);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataRozd);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.Pass2);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.FFF);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox FFF;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox Pass2;
        private System.Windows.Forms.Button Reg;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DateTimePicker DataRozd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

