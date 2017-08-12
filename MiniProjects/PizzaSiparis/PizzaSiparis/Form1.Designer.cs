namespace PizzaSiparis
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
            this.cbPizza = new System.Windows.Forms.ComboBox();
            this.cbBoy = new System.Windows.Forms.ComboBox();
            this.cbKenar = new System.Windows.Forms.ComboBox();
            this.cbHamur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPizza
            // 
            this.cbPizza.FormattingEnabled = true;
            this.cbPizza.Items.AddRange(new object[] {
            "Karışık Pizza",
            "Sosyal Pizza",
            "Mangal Pizza"});
            this.cbPizza.Location = new System.Drawing.Point(197, 67);
            this.cbPizza.Name = "cbPizza";
            this.cbPizza.Size = new System.Drawing.Size(121, 24);
            this.cbPizza.TabIndex = 0;
            this.cbPizza.SelectedIndexChanged += new System.EventHandler(this.cbPizza_SelectedIndexChanged);
            // 
            // cbBoy
            // 
            this.cbBoy.Enabled = false;
            this.cbBoy.FormattingEnabled = true;
            this.cbBoy.Items.AddRange(new object[] {
            "Küçük Boy",
            "Orta Boy",
            "Büyük Boy"});
            this.cbBoy.Location = new System.Drawing.Point(197, 129);
            this.cbBoy.Name = "cbBoy";
            this.cbBoy.Size = new System.Drawing.Size(121, 24);
            this.cbBoy.TabIndex = 1;
            this.cbBoy.SelectedIndexChanged += new System.EventHandler(this.cbBoy_SelectedIndexChanged);
            // 
            // cbKenar
            // 
            this.cbKenar.Enabled = false;
            this.cbKenar.FormattingEnabled = true;
            this.cbKenar.Items.AddRange(new object[] {
            "Normal Kenar",
            "Simit Kenar",
            "Peynir Kenar"});
            this.cbKenar.Location = new System.Drawing.Point(197, 197);
            this.cbKenar.Name = "cbKenar";
            this.cbKenar.Size = new System.Drawing.Size(121, 24);
            this.cbKenar.TabIndex = 2;
            this.cbKenar.SelectedIndexChanged += new System.EventHandler(this.cbKenar_SelectedIndexChanged);
            // 
            // cbHamur
            // 
            this.cbHamur.Enabled = false;
            this.cbHamur.FormattingEnabled = true;
            this.cbHamur.Items.AddRange(new object[] {
            "İnce Hamur",
            "Kalın Hamur"});
            this.cbHamur.Location = new System.Drawing.Point(197, 263);
            this.cbHamur.Name = "cbHamur";
            this.cbHamur.Size = new System.Drawing.Size(121, 24);
            this.cbHamur.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pizza Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Boy Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kenar Tipini Seçiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hamur Tipini Seçiniz";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(495, 112);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Domates";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(634, 112);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 21);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Zeytin";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(495, 159);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 21);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Mantar";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(634, 159);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(54, 21);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Sos";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ekstralar";
            // 
            // btnSiparis
            // 
            this.btnSiparis.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSiparis.Location = new System.Drawing.Point(495, 253);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(208, 42);
            this.btnSiparis.TabIndex = 13;
            this.btnSiparis.Text = "Sipariş Ver";
            this.btnSiparis.UseVisualStyleBackColor = false;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 16;
            this.lstSepet.Location = new System.Drawing.Point(197, 314);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(506, 148);
            this.lstSepet.TabIndex = 14;
            this.lstSepet.Visible = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTemizle.Location = new System.Drawing.Point(495, 200);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(208, 37);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "Siparişi Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(757, 505);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHamur);
            this.Controls.Add(this.cbKenar);
            this.Controls.Add(this.cbBoy);
            this.Controls.Add(this.cbPizza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPizza;
        private System.Windows.Forms.ComboBox cbBoy;
        private System.Windows.Forms.ComboBox cbKenar;
        private System.Windows.Forms.ComboBox cbHamur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Button btnTemizle;
    }
}

