namespace InterfaceOdev
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
            this.cbPozisyon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.pbOyuncu = new System.Windows.Forms.PictureBox();
            this.pbKaleci = new System.Windows.Forms.PictureBox();
            this.lblYazi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOyuncu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKaleci)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPozisyon
            // 
            this.cbPozisyon.FormattingEnabled = true;
            this.cbPozisyon.Items.AddRange(new object[] {
            "Kaleci",
            "Oyuncu"});
            this.cbPozisyon.Location = new System.Drawing.Point(108, 29);
            this.cbPozisyon.Name = "cbPozisyon";
            this.cbPozisyon.Size = new System.Drawing.Size(189, 24);
            this.cbPozisyon.TabIndex = 0;
            this.cbPozisyon.SelectedIndexChanged += new System.EventHandler(this.cbPozisyon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mevki";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(108, 76);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(189, 22);
            this.txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(108, 111);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(189, 22);
            this.txtSoyad.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(26, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pozisyon";
            this.groupBox1.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(149, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ceza Sahası İçinde";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(178, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(159, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Ceza Sahası Dışında";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 63);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(107, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Geri pas var";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(178, 63);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(112, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Geri Pas Yok";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // pbOyuncu
            // 
            this.pbOyuncu.Image = global::InterfaceOdev.Properties.Resources.futbolcu;
            this.pbOyuncu.Location = new System.Drawing.Point(450, 29);
            this.pbOyuncu.Name = "pbOyuncu";
            this.pbOyuncu.Size = new System.Drawing.Size(227, 249);
            this.pbOyuncu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOyuncu.TabIndex = 8;
            this.pbOyuncu.TabStop = false;
            this.pbOyuncu.Visible = false;
            // 
            // pbKaleci
            // 
            this.pbKaleci.Image = global::InterfaceOdev.Properties.Resources.kaleci;
            this.pbKaleci.Location = new System.Drawing.Point(450, 29);
            this.pbKaleci.Name = "pbKaleci";
            this.pbKaleci.Size = new System.Drawing.Size(227, 249);
            this.pbKaleci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKaleci.TabIndex = 7;
            this.pbKaleci.TabStop = false;
            this.pbKaleci.Visible = false;
            // 
            // lblYazi
            // 
            this.lblYazi.AutoSize = true;
            this.lblYazi.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazi.Location = new System.Drawing.Point(12, 354);
            this.lblYazi.Name = "lblYazi";
            this.lblYazi.Size = new System.Drawing.Size(0, 23);
            this.lblYazi.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "El ile dokunabilirmi ?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(737, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblYazi);
            this.Controls.Add(this.pbOyuncu);
            this.Controls.Add(this.pbKaleci);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPozisyon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOyuncu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKaleci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPozisyon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pbKaleci;
        private System.Windows.Forms.PictureBox pbOyuncu;
        private System.Windows.Forms.Label lblYazi;
        private System.Windows.Forms.Button button1;
    }
}

