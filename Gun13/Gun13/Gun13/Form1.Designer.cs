namespace Gun13
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
            this.cbUrunKategori = new System.Windows.Forms.ComboBox();
            this.cbUrunAdi = new System.Windows.Forms.ComboBox();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.txtAylıkTaksit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTaksit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPesinat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbUrunKategori
            // 
            this.cbUrunKategori.FormattingEnabled = true;
            this.cbUrunKategori.Items.AddRange(new object[] {
            "Telefon",
            "Bilgisayar",
            "Araba"});
            this.cbUrunKategori.Location = new System.Drawing.Point(199, 117);
            this.cbUrunKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUrunKategori.Name = "cbUrunKategori";
            this.cbUrunKategori.Size = new System.Drawing.Size(160, 24);
            this.cbUrunKategori.TabIndex = 0;
            this.cbUrunKategori.SelectedIndexChanged += new System.EventHandler(this.cbUrunKategori_SelectedIndexChanged);
            // 
            // cbUrunAdi
            // 
            this.cbUrunAdi.FormattingEnabled = true;
            this.cbUrunAdi.Location = new System.Drawing.Point(199, 156);
            this.cbUrunAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUrunAdi.Name = "cbUrunAdi";
            this.cbUrunAdi.Size = new System.Drawing.Size(160, 24);
            this.cbUrunAdi.TabIndex = 1;
            this.cbUrunAdi.SelectedIndexChanged += new System.EventHandler(this.cbUrunAdi_SelectedIndexChanged);
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(199, 196);
            this.txtUrunFiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.ReadOnly = true;
            this.txtUrunFiyat.Size = new System.Drawing.Size(132, 22);
            this.txtUrunFiyat.TabIndex = 2;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(199, 239);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(132, 22);
            this.txtAdet.TabIndex = 3;
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(199, 377);
            this.txtToplam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.ReadOnly = true;
            this.txtToplam.Size = new System.Drawing.Size(132, 22);
            this.txtToplam.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 117);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(548, 154);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Satın Al";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(548, 191);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Sepete Koy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(548, 228);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "Çıkış";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ürün Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 385);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Toplam Tutar";
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 16;
            this.lstSepet.Location = new System.Drawing.Point(548, 345);
            this.lstSepet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(404, 116);
            this.lstSepet.TabIndex = 14;
            this.lstSepet.Visible = false;
            // 
            // txtAylıkTaksit
            // 
            this.txtAylıkTaksit.Enabled = false;
            this.txtAylıkTaksit.Location = new System.Drawing.Point(199, 345);
            this.txtAylıkTaksit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAylıkTaksit.Name = "txtAylıkTaksit";
            this.txtAylıkTaksit.Size = new System.Drawing.Size(132, 22);
            this.txtAylıkTaksit.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Aylık Taksit";
            // 
            // cbTaksit
            // 
            this.cbTaksit.FormattingEnabled = true;
            this.cbTaksit.Items.AddRange(new object[] {
            "1",
            "3",
            "5"});
            this.cbTaksit.Location = new System.Drawing.Point(199, 311);
            this.cbTaksit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTaksit.Name = "cbTaksit";
            this.cbTaksit.Size = new System.Drawing.Size(160, 24);
            this.cbTaksit.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 320);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Taksit Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 284);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Peşinat";
            // 
            // txtPesinat
            // 
            this.txtPesinat.Location = new System.Drawing.Point(199, 279);
            this.txtPesinat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesinat.Name = "txtPesinat";
            this.txtPesinat.Size = new System.Drawing.Size(132, 22);
            this.txtPesinat.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(544, 283);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Stok Sayısı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(608, 284);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 585);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPesinat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTaksit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAylıkTaksit);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtUrunFiyat);
            this.Controls.Add(this.cbUrunAdi);
            this.Controls.Add(this.cbUrunKategori);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUrunKategori;
        private System.Windows.Forms.ComboBox cbUrunAdi;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.TextBox txtAylıkTaksit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTaksit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPesinat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

