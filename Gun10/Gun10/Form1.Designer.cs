namespace Gun10
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
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rBind1 = new System.Windows.Forms.RadioButton();
            this.rBind2 = new System.Windows.Forms.RadioButton();
            this.rBind3 = new System.Windows.Forms.RadioButton();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.lstTumSiparisler = new System.Windows.Forms.ListBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KATEGORİ SEÇİNİZ";
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Items.AddRange(new object[] {
            "Telefon",
            "Bilgisayar",
            "Beyaz Eşya"});
            this.cbKategoriler.Location = new System.Drawing.Point(41, 71);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(121, 21);
            this.cbKategoriler.TabIndex = 1;
            this.cbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cbKategoriler_SelectedIndexChanged);
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(41, 112);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstUrunler.Size = new System.Drawing.Size(120, 186);
            this.lstUrunler.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "İndirim miktarı seçiniz";
            // 
            // rBind1
            // 
            this.rBind1.AutoSize = true;
            this.rBind1.Location = new System.Drawing.Point(41, 334);
            this.rBind1.Name = "rBind1";
            this.rBind1.Size = new System.Drawing.Size(39, 17);
            this.rBind1.TabIndex = 4;
            this.rBind1.TabStop = true;
            this.rBind1.Text = "%5";
            this.rBind1.UseVisualStyleBackColor = true;
            // 
            // rBind2
            // 
            this.rBind2.AutoSize = true;
            this.rBind2.Location = new System.Drawing.Point(41, 358);
            this.rBind2.Name = "rBind2";
            this.rBind2.Size = new System.Drawing.Size(45, 17);
            this.rBind2.TabIndex = 5;
            this.rBind2.TabStop = true;
            this.rBind2.Text = "%10";
            this.rBind2.UseVisualStyleBackColor = true;
            // 
            // rBind3
            // 
            this.rBind3.AutoSize = true;
            this.rBind3.Location = new System.Drawing.Point(41, 382);
            this.rBind3.Name = "rBind3";
            this.rBind3.Size = new System.Drawing.Size(45, 17);
            this.rBind3.TabIndex = 6;
            this.rBind3.TabStop = true;
            this.rBind3.Text = "%15";
            this.rBind3.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(221, 151);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 7;
            this.btn1.Text = ">";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(221, 181);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "<";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(221, 211);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 9;
            this.btn3.Text = ">>";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(221, 241);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "<<";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Müşteri Adı Giriniz";
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(375, 112);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSepet.Size = new System.Drawing.Size(120, 186);
            this.lstSepet.TabIndex = 12;
            // 
            // lstTumSiparisler
            // 
            this.lstTumSiparisler.FormattingEnabled = true;
            this.lstTumSiparisler.Location = new System.Drawing.Point(511, 112);
            this.lstTumSiparisler.Name = "lstTumSiparisler";
            this.lstTumSiparisler.Size = new System.Drawing.Size(301, 186);
            this.lstTumSiparisler.TabIndex = 13;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(375, 71);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(384, 20);
            this.txtAd.TabIndex = 14;
            // 
            // btnTamamla
            // 
            this.btnTamamla.Location = new System.Drawing.Point(616, 382);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(142, 42);
            this.btnTamamla.TabIndex = 15;
            this.btnTamamla.Text = "Siparişi Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = true;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(494, 382);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 42);
            this.btnCikis.TabIndex = 16;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(375, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "-------------------------------------";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(221, 93);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 17);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "TekliSeçim";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(221, 117);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 17);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ÇokluSeçim";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 489);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lstTumSiparisler);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.rBind3);
            this.Controls.Add(this.rBind2);
            this.Controls.Add(this.rBind1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.cbKategoriler);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rBind1;
        private System.Windows.Forms.RadioButton rBind2;
        private System.Windows.Forms.RadioButton rBind3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.ListBox lstTumSiparisler;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

