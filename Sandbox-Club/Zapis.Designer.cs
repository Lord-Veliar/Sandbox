namespace Sandbox_Club
{
    partial class Zapis
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.oform = new System.Windows.Forms.Button();
            this.la1 = new System.Windows.Forms.Label();
            this.ost1 = new System.Windows.Forms.Label();
            this.la2 = new System.Windows.Forms.Label();
            this.ost2 = new System.Windows.Forms.Label();
            this.la3 = new System.Windows.Forms.Label();
            this.ost3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(266, 95);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(139, 20);
            this.date.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(146, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Нет записи";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(298, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Нет записи";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(458, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Нет записи";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Название Ивента";
            // 
            // oform
            // 
            this.oform.Location = new System.Drawing.Point(298, 286);
            this.oform.Name = "oform";
            this.oform.Size = new System.Drawing.Size(75, 23);
            this.oform.TabIndex = 11;
            this.oform.Text = "Записаться";
            this.oform.UseVisualStyleBackColor = true;
            this.oform.Click += new System.EventHandler(this.oform_Click);
            // 
            // la1
            // 
            this.la1.AutoSize = true;
            this.la1.Location = new System.Drawing.Point(98, 139);
            this.la1.Name = "la1";
            this.la1.Size = new System.Drawing.Size(87, 13);
            this.la1.TabIndex = 12;
            this.la1.Text = "Осталось мест:";
            // 
            // ost1
            // 
            this.ost1.AutoSize = true;
            this.ost1.Location = new System.Drawing.Point(191, 139);
            this.ost1.Name = "ost1";
            this.ost1.Size = new System.Drawing.Size(13, 13);
            this.ost1.TabIndex = 13;
            this.ost1.Text = "0";
            this.ost1.Click += new System.EventHandler(this.ost1_Click);
            // 
            // la2
            // 
            this.la2.AutoSize = true;
            this.la2.Location = new System.Drawing.Point(272, 139);
            this.la2.Name = "la2";
            this.la2.Size = new System.Drawing.Size(87, 13);
            this.la2.TabIndex = 14;
            this.la2.Text = "Осталось мест:";
            // 
            // ost2
            // 
            this.ost2.AutoSize = true;
            this.ost2.Location = new System.Drawing.Point(360, 139);
            this.ost2.Name = "ost2";
            this.ost2.Size = new System.Drawing.Size(13, 13);
            this.ost2.TabIndex = 15;
            this.ost2.Text = "0";
            // 
            // la3
            // 
            this.la3.AutoSize = true;
            this.la3.Location = new System.Drawing.Point(434, 139);
            this.la3.Name = "la3";
            this.la3.Size = new System.Drawing.Size(87, 13);
            this.la3.TabIndex = 16;
            this.la3.Text = "Осталось мест:";
            // 
            // ost3
            // 
            this.ost3.AutoSize = true;
            this.ost3.Location = new System.Drawing.Point(528, 139);
            this.ost3.Name = "ost3";
            this.ost3.Size = new System.Drawing.Size(13, 13);
            this.ost3.TabIndex = 17;
            this.ost3.Text = "0";
            // 
            // Zapis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ost3);
            this.Controls.Add(this.la3);
            this.Controls.Add(this.ost2);
            this.Controls.Add(this.la2);
            this.Controls.Add(this.ost1);
            this.Controls.Add(this.la1);
            this.Controls.Add(this.oform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date);
            this.Name = "Zapis";
            this.Text = "Zapis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DateTimePicker date;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button oform;
        public System.Windows.Forms.Label la1;
        public System.Windows.Forms.Label ost1;
        public System.Windows.Forms.Label la2;
        public System.Windows.Forms.Label ost2;
        public System.Windows.Forms.Label la3;
        public System.Windows.Forms.Label ost3;
    }
}