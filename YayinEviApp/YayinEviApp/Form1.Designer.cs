namespace YayinEviApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.YayinEvleriComboBox = new System.Windows.Forms.ComboBox();
            this.YayinEviEkleButton = new System.Windows.Forms.Button();
            this.KitapEkleButton = new System.Windows.Forms.Button();
            this.KitapCikarButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.EditorEkleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.KitapAdiTextBox = new System.Windows.Forms.TextBox();
            this.KitapListesiListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KitapYazariTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.YayinEviAdiTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EditorAdiTextBox = new System.Windows.Forms.TextBox();
            this.EditorListesiListBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YayinEvleriComboBox
            // 
            this.YayinEvleriComboBox.FormattingEnabled = true;
            this.YayinEvleriComboBox.Location = new System.Drawing.Point(404, 303);
            this.YayinEvleriComboBox.Name = "YayinEvleriComboBox";
            this.YayinEvleriComboBox.Size = new System.Drawing.Size(203, 24);
            this.YayinEvleriComboBox.TabIndex = 0;
            this.YayinEvleriComboBox.SelectedIndexChanged += new System.EventHandler(this.YayinEvleriComboBox_SelectedIndexChanged);
            // 
            // YayinEviEkleButton
            // 
            this.YayinEviEkleButton.Location = new System.Drawing.Point(99, 139);
            this.YayinEviEkleButton.Name = "YayinEviEkleButton";
            this.YayinEviEkleButton.Size = new System.Drawing.Size(206, 34);
            this.YayinEviEkleButton.TabIndex = 1;
            this.YayinEviEkleButton.Text = "EKLE";
            this.YayinEviEkleButton.UseVisualStyleBackColor = true;
            this.YayinEviEkleButton.Click += new System.EventHandler(this.YayinEviEkleButton_Click);
            // 
            // KitapEkleButton
            // 
            this.KitapEkleButton.Location = new System.Drawing.Point(763, 135);
            this.KitapEkleButton.Name = "KitapEkleButton";
            this.KitapEkleButton.Size = new System.Drawing.Size(171, 38);
            this.KitapEkleButton.TabIndex = 2;
            this.KitapEkleButton.Text = "EKLE";
            this.KitapEkleButton.UseVisualStyleBackColor = true;
            this.KitapEkleButton.Click += new System.EventHandler(this.KitapEkleButton_Click);
            // 
            // KitapCikarButton
            // 
            this.KitapCikarButton.Location = new System.Drawing.Point(107, 409);
            this.KitapCikarButton.Name = "KitapCikarButton";
            this.KitapCikarButton.Size = new System.Drawing.Size(171, 28);
            this.KitapCikarButton.TabIndex = 3;
            this.KitapCikarButton.Text = "ÇIKAR";
            this.KitapCikarButton.UseVisualStyleBackColor = true;
            this.KitapCikarButton.Click += new System.EventHandler(this.KitapCikarButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(735, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "ÇIKAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EditorEkleButton
            // 
            this.EditorEkleButton.Location = new System.Drawing.Point(424, 139);
            this.EditorEkleButton.Name = "EditorEkleButton";
            this.EditorEkleButton.Size = new System.Drawing.Size(153, 34);
            this.EditorEkleButton.TabIndex = 5;
            this.EditorEkleButton.Text = "EKLE";
            this.EditorEkleButton.UseVisualStyleBackColor = true;
            this.EditorEkleButton.Click += new System.EventHandler(this.EditorEkleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "YAYIN EVİ İŞLEMLERİ";
            // 
            // KitapAdiTextBox
            // 
            this.KitapAdiTextBox.Location = new System.Drawing.Point(763, 72);
            this.KitapAdiTextBox.Name = "KitapAdiTextBox";
            this.KitapAdiTextBox.Size = new System.Drawing.Size(171, 22);
            this.KitapAdiTextBox.TabIndex = 7;
            // 
            // KitapListesiListBox
            // 
            this.KitapListesiListBox.FormattingEnabled = true;
            this.KitapListesiListBox.ItemHeight = 16;
            this.KitapListesiListBox.Location = new System.Drawing.Point(107, 303);
            this.KitapListesiListBox.Name = "KitapListesiListBox";
            this.KitapListesiListBox.Size = new System.Drawing.Size(171, 100);
            this.KitapListesiListBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(784, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "KİTAP İŞLEMLERİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(666, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kitap Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(661, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yazar Adı:";
            // 
            // KitapYazariTextBox
            // 
            this.KitapYazariTextBox.Location = new System.Drawing.Point(763, 107);
            this.KitapYazariTextBox.Name = "KitapYazariTextBox";
            this.KitapYazariTextBox.Size = new System.Drawing.Size(171, 22);
            this.KitapYazariTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Yayın Evi Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kitap Listesi:";
            // 
            // YayinEviAdiTextBox
            // 
            this.YayinEviAdiTextBox.Location = new System.Drawing.Point(99, 84);
            this.YayinEviAdiTextBox.Name = "YayinEviAdiTextBox";
            this.YayinEviAdiTextBox.Size = new System.Drawing.Size(206, 22);
            this.YayinEviAdiTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Çıkarılacak Kitabı Listeden Seçiniz.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "EDİTÖR İŞLEMLERİ";
            // 
            // EditorAdiTextBox
            // 
            this.EditorAdiTextBox.Location = new System.Drawing.Point(424, 82);
            this.EditorAdiTextBox.Name = "EditorAdiTextBox";
            this.EditorAdiTextBox.Size = new System.Drawing.Size(153, 22);
            this.EditorAdiTextBox.TabIndex = 18;
            // 
            // EditorListesiListBox
            // 
            this.EditorListesiListBox.FormattingEnabled = true;
            this.EditorListesiListBox.ItemHeight = 16;
            this.EditorListesiListBox.Location = new System.Drawing.Point(735, 304);
            this.EditorListesiListBox.Name = "EditorListesiListBox";
            this.EditorListesiListBox.Size = new System.Drawing.Size(199, 100);
            this.EditorListesiListBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Editör Adı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(646, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Editör Listesi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(698, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(274, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Çıkarmak İstediğiniz Editörü Listeden Seçiniz.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(401, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "LİSTELEME VE SİLME İŞLEMLERİ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(451, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Yayınevi Seçiniz:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 51);
            this.button1.TabIndex = 25;
            this.button1.Text = "Bilgi Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(796, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 51);
            this.button2.TabIndex = 26;
            this.button2.Text = "Bilgi Göster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(92, 453);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 48);
            this.label14.TabIndex = 27;
            this.label14.Text = "     *Yukarıda seçilen Kitabın\r\n bilgilerini görmek için aşağıdaki\r\n             " +
    "   Butona tıklayınız\r\n";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(736, 453);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 48);
            this.label15.TabIndex = 28;
            this.label15.Text = "     *Yukarıda seçilen Editörün\r\n bilgilerini görmek için aşağıdaki\r\n            " +
    "    Butona tıklayınız";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(401, 345);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(188, 32);
            this.label16.TabIndex = 29;
            this.label16.Text = "     Yayınevi Adını Görmek İçin \r\n  Yukarıdan Yayınevini Seçiniz.\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 582);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EditorListesiListBox);
            this.Controls.Add(this.EditorAdiTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.YayinEviAdiTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KitapYazariTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KitapListesiListBox);
            this.Controls.Add(this.KitapAdiTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditorEkleButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.KitapCikarButton);
            this.Controls.Add(this.KitapEkleButton);
            this.Controls.Add(this.YayinEviEkleButton);
            this.Controls.Add(this.YayinEvleriComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox YayinEvleriComboBox;
        private System.Windows.Forms.Button YayinEviEkleButton;
        private System.Windows.Forms.Button KitapEkleButton;
        private System.Windows.Forms.Button KitapCikarButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button EditorEkleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KitapAdiTextBox;
        private System.Windows.Forms.ListBox KitapListesiListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox KitapYazariTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox YayinEviAdiTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EditorAdiTextBox;
        private System.Windows.Forms.ListBox EditorListesiListBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

