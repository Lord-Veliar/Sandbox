namespace Sandbox_Club
{
    partial class Avtoriz
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
            this.label1 = new System.Windows.Forms.Label();
            this.GEmail = new System.Windows.Forms.TextBox();
            this.GPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // GEmail
            // 
            this.GEmail.Location = new System.Drawing.Point(334, 94);
            this.GEmail.Name = "GEmail";
            this.GEmail.Size = new System.Drawing.Size(100, 20);
            this.GEmail.TabIndex = 1;
            this.GEmail.Text = "Email";
            this.GEmail.Enter += new System.EventHandler(this.GEmail_TextEnter);
            this.GEmail.Leave += new System.EventHandler(this.GEmail_TextLeave);
            // 
            // GPass
            // 
            this.GPass.Location = new System.Drawing.Point(364, 163);
            this.GPass.Name = "GPass";
            this.GPass.Size = new System.Drawing.Size(100, 20);
            this.GPass.TabIndex = 2;
            this.GPass.Text = "Пароль";
            this.GPass.TextChanged += new System.EventHandler(this.GPass_TextChanged);
            this.GPass.Enter += new System.EventHandler(this.GPass_TextEnter);
            this.GPass.Leave += new System.EventHandler(this.GPass_TextLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Avtoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GPass);
            this.Controls.Add(this.GEmail);
            this.Controls.Add(this.label1);
            this.Name = "Avtoriz";
            this.Text = "Avtoriz";
            this.Load += new System.EventHandler(this.Avtoriz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GEmail;
        private System.Windows.Forms.TextBox GPass;
        private System.Windows.Forms.Button button1;
    }
}