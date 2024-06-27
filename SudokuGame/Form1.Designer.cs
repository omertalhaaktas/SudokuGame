namespace SudokuGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonZor = new System.Windows.Forms.RadioButton();
            this.radioButtonOrta = new System.Windows.Forms.RadioButton();
            this.radioButtonKolay = new System.Windows.Forms.RadioButton();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 361);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonZor);
            this.groupBox1.Controls.Add(this.radioButtonOrta);
            this.groupBox1.Controls.Add(this.radioButtonKolay);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(383, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seviye";
            // 
            // radioButtonZor
            // 
            this.radioButtonZor.AutoSize = true;
            this.radioButtonZor.Location = new System.Drawing.Point(11, 75);
            this.radioButtonZor.Name = "radioButtonZor";
            this.radioButtonZor.Size = new System.Drawing.Size(44, 19);
            this.radioButtonZor.TabIndex = 2;
            this.radioButtonZor.TabStop = true;
            this.radioButtonZor.Text = "Zor";
            this.radioButtonZor.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrta
            // 
            this.radioButtonOrta.AutoSize = true;
            this.radioButtonOrta.Location = new System.Drawing.Point(11, 50);
            this.radioButtonOrta.Name = "radioButtonOrta";
            this.radioButtonOrta.Size = new System.Drawing.Size(50, 19);
            this.radioButtonOrta.TabIndex = 1;
            this.radioButtonOrta.TabStop = true;
            this.radioButtonOrta.Text = "Orta";
            this.radioButtonOrta.UseVisualStyleBackColor = true;
            // 
            // radioButtonKolay
            // 
            this.radioButtonKolay.AutoSize = true;
            this.radioButtonKolay.Location = new System.Drawing.Point(11, 25);
            this.radioButtonKolay.Name = "radioButtonKolay";
            this.radioButtonKolay.Size = new System.Drawing.Size(55, 19);
            this.radioButtonKolay.TabIndex = 0;
            this.radioButtonKolay.TabStop = true;
            this.radioButtonKolay.Text = "Kolay";
            this.radioButtonKolay.UseVisualStyleBackColor = true;
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.Location = new System.Drawing.Point(383, 292);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(177, 84);
            this.btnYeniOyun.TabIndex = 3;
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = true;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(383, 12);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(177, 83);
            this.btnKontrol.TabIndex = 4;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(383, 101);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(177, 76);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 388);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Sudoku";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private RadioButton radioButtonZor;
        private RadioButton radioButtonOrta;
        private RadioButton radioButtonKolay;
        private Button btnYeniOyun;
        private Button btnKontrol;
        private Button btnTemizle;
    }
}