namespace Sandbox_Club
{
    partial class Menu
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
            this.Prof = new System.Windows.Forms.LinkLabel();
            this.Zap = new System.Windows.Forms.LinkLabel();
            this.Exx = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prof
            // 
            this.Prof.AutoSize = true;
            this.Prof.Location = new System.Drawing.Point(369, 68);
            this.Prof.Name = "Prof";
            this.Prof.Size = new System.Drawing.Size(53, 13);
            this.Prof.TabIndex = 0;
            this.Prof.TabStop = true;
            this.Prof.Text = "Профиль";
            this.Prof.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Prof_LinkClicked);
            // 
            // Zap
            // 
            this.Zap.AutoSize = true;
            this.Zap.Location = new System.Drawing.Point(369, 136);
            this.Zap.Name = "Zap";
            this.Zap.Size = new System.Drawing.Size(67, 13);
            this.Zap.TabIndex = 1;
            this.Zap.TabStop = true;
            this.Zap.Text = "Мои записи";
            this.Zap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Zap_LinkClicked);
            // 
            // Exx
            // 
            this.Exx.Location = new System.Drawing.Point(349, 197);
            this.Exx.Name = "Exx";
            this.Exx.Size = new System.Drawing.Size(117, 34);
            this.Exx.TabIndex = 2;
            this.Exx.Text = "Выйти из аккаунта";
            this.Exx.UseVisualStyleBackColor = true;
            this.Exx.Click += new System.EventHandler(this.Exx_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "На главную";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exx);
            this.Controls.Add(this.Zap);
            this.Controls.Add(this.Prof);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Prof;
        private System.Windows.Forms.LinkLabel Zap;
        private System.Windows.Forms.Button Exx;
        private System.Windows.Forms.Button button1;
    }
}