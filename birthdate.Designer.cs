namespace Birth_date_string
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtweek = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtdayofthemonth = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.dateOutputLabel = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the day of week";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the name of the month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the numeric day of the month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter the year";
            // 
            // txtweek
            // 
            this.txtweek.Location = new System.Drawing.Point(417, 53);
            this.txtweek.Multiline = true;
            this.txtweek.Name = "txtweek";
            this.txtweek.Size = new System.Drawing.Size(327, 26);
            this.txtweek.TabIndex = 4;
            this.txtweek.TextChanged += new System.EventHandler(this.txtweek_TextChanged);
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(417, 111);
            this.txtmonth.Multiline = true;
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(327, 26);
            this.txtmonth.TabIndex = 5;
            // 
            // txtdayofthemonth
            // 
            this.txtdayofthemonth.Location = new System.Drawing.Point(417, 162);
            this.txtdayofthemonth.Multiline = true;
            this.txtdayofthemonth.Name = "txtdayofthemonth";
            this.txtdayofthemonth.Size = new System.Drawing.Size(327, 26);
            this.txtdayofthemonth.TabIndex = 6;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(417, 208);
            this.txtyear.Multiline = true;
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(327, 26);
            this.txtyear.TabIndex = 7;
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.Location = new System.Drawing.Point(39, 265);
            this.dateOutputLabel.Multiline = true;
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(749, 86);
            this.dateOutputLabel.TabIndex = 8;
            this.dateOutputLabel.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(103, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(345, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 62);
            this.button2.TabIndex = 10;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(592, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 62);
            this.button3.TabIndex = 11;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtdayofthemonth);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtweek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Birth Date String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtweek;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtdayofthemonth;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox dateOutputLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

