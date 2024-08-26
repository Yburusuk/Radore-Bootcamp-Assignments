namespace AttributeForm
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
            label_ad = new Label();
            label_soyad = new Label();
            label_bolum = new Label();
            label_sonuc = new Label();
            button_kaydet = new Button();
            textBox_ad = new TextBox();
            textBox_soyad = new TextBox();
            textBox_bolum = new TextBox();
            SuspendLayout();
            // 
            // label_ad
            // 
            label_ad.AutoSize = true;
            label_ad.Location = new Point(130, 47);
            label_ad.Name = "label_ad";
            label_ad.Size = new Size(70, 15);
            label_ad.TabIndex = 0;
            label_ad.Text = "Öğrenci Adı";
            // 
            // label_soyad
            // 
            label_soyad.AutoSize = true;
            label_soyad.Location = new Point(130, 90);
            label_soyad.Name = "label_soyad";
            label_soyad.Size = new Size(87, 15);
            label_soyad.TabIndex = 1;
            label_soyad.Text = "Öğrenci Soyadı";
            // 
            // label_bolum
            // 
            label_bolum.AutoSize = true;
            label_bolum.Location = new Point(130, 139);
            label_bolum.Name = "label_bolum";
            label_bolum.Size = new Size(94, 15);
            label_bolum.TabIndex = 2;
            label_bolum.Text = "Öğrenci Bölümü";
            // 
            // label_sonuc
            // 
            label_sonuc.AutoSize = true;
            label_sonuc.Location = new Point(130, 226);
            label_sonuc.Name = "label_sonuc";
            label_sonuc.Size = new Size(0, 15);
            label_sonuc.TabIndex = 3;
            // 
            // button_kaydet
            // 
            button_kaydet.Location = new Point(361, 191);
            button_kaydet.Name = "button_kaydet";
            button_kaydet.Size = new Size(75, 23);
            button_kaydet.TabIndex = 4;
            button_kaydet.Text = "Kaydet";
            button_kaydet.UseVisualStyleBackColor = true;
            button_kaydet.Click += button_kaydet_Click;
            // 
            // textBox_ad
            // 
            textBox_ad.Location = new Point(284, 44);
            textBox_ad.Name = "textBox_ad";
            textBox_ad.Size = new Size(152, 23);
            textBox_ad.TabIndex = 5;
            // 
            // textBox_soyad
            // 
            textBox_soyad.Location = new Point(284, 87);
            textBox_soyad.Name = "textBox_soyad";
            textBox_soyad.Size = new Size(152, 23);
            textBox_soyad.TabIndex = 6;
            // 
            // textBox_bolum
            // 
            textBox_bolum.Location = new Point(284, 136);
            textBox_bolum.Name = "textBox_bolum";
            textBox_bolum.Size = new Size(152, 23);
            textBox_bolum.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 276);
            Controls.Add(textBox_bolum);
            Controls.Add(textBox_soyad);
            Controls.Add(textBox_ad);
            Controls.Add(button_kaydet);
            Controls.Add(label_sonuc);
            Controls.Add(label_bolum);
            Controls.Add(label_soyad);
            Controls.Add(label_ad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_ad;
        private Label label_soyad;
        private Label label_bolum;
        private Label label_sonuc;
        private Button button_kaydet;
        private TextBox textBox_ad;
        private TextBox textBox_soyad;
        private TextBox textBox_bolum;
    }
}
