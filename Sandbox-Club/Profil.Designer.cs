namespace Sandbox_Club
{
    partial class Profil
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
            this.RedIm = new System.Windows.Forms.TextBox();
            this.RedFm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.RedEm = new System.Windows.Forms.TextBox();
            this.RedPass = new System.Windows.Forms.TextBox();
            this.Rednpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RedIm
            // 
            this.RedIm.Location = new System.Drawing.Point(80, 49);
            this.RedIm.Name = "RedIm";
            this.RedIm.Size = new System.Drawing.Size(100, 20);
            this.RedIm.TabIndex = 0;
            // 
            // RedFm
            // 
            this.RedFm.Location = new System.Drawing.Point(283, 49);
            this.RedFm.Name = "RedFm";
            this.RedFm.Size = new System.Drawing.Size(100, 20);
            this.RedFm.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(505, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(505, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RedEm
            // 
            this.RedEm.Location = new System.Drawing.Point(212, 166);
            this.RedEm.Name = "RedEm";
            this.RedEm.Size = new System.Drawing.Size(100, 20);
            this.RedEm.TabIndex = 5;
            // 
            // RedPass
            // 
            this.RedPass.Location = new System.Drawing.Point(80, 280);
            this.RedPass.Name = "RedPass";
            this.RedPass.PasswordChar = '*';
            this.RedPass.Size = new System.Drawing.Size(100, 20);
            this.RedPass.TabIndex = 6;
            this.RedPass.UseSystemPasswordChar = true;
            // 
            // Rednpass
            // 
            this.Rednpass.Location = new System.Drawing.Point(342, 280);
            this.Rednpass.Name = "Rednpass";
            this.Rednpass.Size = new System.Drawing.Size(100, 20);
            this.Rednpass.TabIndex = 7;
            this.Rednpass.UseSystemPasswordChar = true;
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rednpass);
            this.Controls.Add(this.RedPass);
            this.Controls.Add(this.RedEm);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RedFm);
            this.Controls.Add(this.RedIm);
            this.Name = "Profil";
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.Profil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RedIm;
        private System.Windows.Forms.TextBox RedFm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox RedEm;
        private System.Windows.Forms.TextBox RedPass;
        private System.Windows.Forms.TextBox Rednpass;
    }
}