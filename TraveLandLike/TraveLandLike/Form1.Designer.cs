namespace TraveLandLike
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Giris_Btn = new Button();
            uyeol_btn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(460, 206);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(460, 264);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 27);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 206);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 267);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 3;
            label2.Text = "Parola:";
            // 
            // Giris_Btn
            // 
            Giris_Btn.Location = new Point(460, 327);
            Giris_Btn.Name = "Giris_Btn";
            Giris_Btn.Size = new Size(94, 29);
            Giris_Btn.TabIndex = 4;
            Giris_Btn.Text = "Giriş Yap";
            Giris_Btn.UseVisualStyleBackColor = true;
            Giris_Btn.Click += Giris_Btn_Click;
            // 
            // uyeol_btn
            // 
            uyeol_btn.Location = new Point(597, 327);
            uyeol_btn.Name = "uyeol_btn";
            uyeol_btn.Size = new Size(94, 29);
            uyeol_btn.TabIndex = 5;
            uyeol_btn.Text = "Kayıt Ol";
            uyeol_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(332, 124);
            label3.Name = "label3";
            label3.Size = new Size(478, 35);
            label3.TabIndex = 6;
            label3.Text = "GEZİ REHBERİ VE KULLANICI PLATFORMU";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 737);
            Controls.Add(label3);
            Controls.Add(uyeol_btn);
            Controls.Add(Giris_Btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "GEZİ REHBERİ VE KULLANICI PLATFORMU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button Giris_Btn;
        private Button uyeol_btn;
        private Label label3;
    }
}