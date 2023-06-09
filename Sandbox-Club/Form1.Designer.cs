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
            this.DataRozd = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Pass2 = new System.Windows.Forms.TextBox();
            this.Reg = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(263, 71);
            this.NameText.Margin = new System.Windows.Forms.Padding(2);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(76, 20);
            this.NameText.TabIndex = 1;
            this.NameText.Text = "Имя";
            this.NameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameText.Enter += new System.EventHandler(this.Name_TextEnter);
            this.NameText.Leave += new System.EventHandler(this.Name_TextLeave);
            // 
            // FFF
            // 
            this.FFF.Location = new System.Drawing.Point(263, 120);
            this.FFF.Margin = new System.Windows.Forms.Padding(2);
            this.FFF.Name = "FFF";
            this.FFF.Size = new System.Drawing.Size(76, 20);
            this.FFF.TabIndex = 2;
            this.FFF.Text = "Фамилия";
            this.FFF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FFF.TextChanged += new System.EventHandler(this.FFF_TextChanged);
            this.FFF.Enter += new System.EventHandler(this.FFF_TextEnter);
            this.FFF.Leave += new System.EventHandler(this.FFF_TextLeave);
            // 
            // DataRozd
            // 
            this.DataRozd.Location = new System.Drawing.Point(264, 161);
            this.DataRozd.Margin = new System.Windows.Forms.Padding(2);
            this.DataRozd.Name = "DataRozd";
            this.DataRozd.Size = new System.Drawing.Size(91, 20);
            this.DataRozd.TabIndex = 3;
            this.DataRozd.Text = "Дата рождения";
            this.DataRozd.TextChanged += new System.EventHandler(this.DataRozd_TextChanged);
            this.DataRozd.Enter += new System.EventHandler(this.DR_TextEnter);
            this.DataRozd.Leave += new System.EventHandler(this.DR_TextLeave);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(269, 210);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(70, 20);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            this.Email.Enter += new System.EventHandler(this.Email_TextEnter);
            this.Email.Leave += new System.EventHandler(this.Email_TextLeave);
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(255, 250);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(100, 20);
            this.Pass.TabIndex = 5;
            this.Pass.Text = "Пароль";
            this.Pass.TextChanged += new System.EventHandler(this.Pass_TextChanged);
            this.Pass.Enter += new System.EventHandler(this.Pass_TextEnter);
            this.Pass.Leave += new System.EventHandler(this.Pass_TextLeave);
            // 
            // Pass2
            // 
            this.Pass2.Location = new System.Drawing.Point(255, 276);
            this.Pass2.Name = "Pass2";
            this.Pass2.Size = new System.Drawing.Size(115, 20);
            this.Pass2.TabIndex = 6;
            this.Pass2.Text = "Повторите пароль";
            this.Pass2.TextChanged += new System.EventHandler(this.Pass2_TextChanged);
            this.Pass2.Enter += new System.EventHandler(this.Pass2_TextEnter);
            this.Pass2.Leave += new System.EventHandler(this.Pass2_TextLeave);
            // 
            // Reg
            // 
            this.Reg.Location = new System.Drawing.Point(376, 311);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(98, 23);
            this.Reg.TabIndex = 7;
            this.Reg.Text = "Регистрация";
            this.Reg.UseVisualStyleBackColor = true;
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(260, 335);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Уже есть аккаунт?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.Pass2);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.DataRozd);
            this.Controls.Add(this.FFF);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox DataRozd;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox Pass2;
        private System.Windows.Forms.Button Reg;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

