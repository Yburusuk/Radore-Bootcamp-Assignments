namespace DbFirstOdemeForm
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
            label_paymentType = new Label();
            textBox_amount = new TextBox();
            cmb_paymentType = new ComboBox();
            button_pay = new Button();
            label_amount = new Label();
            label_result = new Label();
            SuspendLayout();
            // 
            // label_paymentType
            // 
            label_paymentType.AutoSize = true;
            label_paymentType.Location = new Point(114, 53);
            label_paymentType.Name = "label_paymentType";
            label_paymentType.Size = new Size(68, 15);
            label_paymentType.TabIndex = 0;
            label_paymentType.Text = "Ödeme Tipi";
            // 
            // textBox_amount
            // 
            textBox_amount.Location = new Point(274, 113);
            textBox_amount.Name = "textBox_amount";
            textBox_amount.Size = new Size(142, 23);
            textBox_amount.TabIndex = 1;
            // 
            // cmb_paymentType
            // 
            cmb_paymentType.FormattingEnabled = true;
            cmb_paymentType.Location = new Point(274, 50);
            cmb_paymentType.Name = "cmb_paymentType";
            cmb_paymentType.Size = new Size(142, 23);
            cmb_paymentType.TabIndex = 2;
            // 
            // button_pay
            // 
            button_pay.Location = new Point(332, 179);
            button_pay.Name = "button_pay";
            button_pay.Size = new Size(84, 23);
            button_pay.TabIndex = 3;
            button_pay.Text = "Ödeme Yap";
            button_pay.UseVisualStyleBackColor = true;
            button_pay.Click += button_pay_Click;
            // 
            // label_amount
            // 
            label_amount.AutoSize = true;
            label_amount.Location = new Point(114, 116);
            label_amount.Name = "label_amount";
            label_amount.Size = new Size(34, 15);
            label_amount.TabIndex = 4;
            label_amount.Text = "Tutar";
            // 
            // label_result
            // 
            label_result.AutoSize = true;
            label_result.Location = new Point(114, 223);
            label_result.Name = "label_result";
            label_result.Size = new Size(46, 15);
            label_result.TabIndex = 5;
            label_result.Text = "Sonuç: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 291);
            Controls.Add(label_result);
            Controls.Add(label_amount);
            Controls.Add(button_pay);
            Controls.Add(cmb_paymentType);
            Controls.Add(textBox_amount);
            Controls.Add(label_paymentType);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_paymentType;
        private TextBox textBox_amount;
        private ComboBox cmb_paymentType;
        private Button button_pay;
        private Label label_amount;
        private Label label_result;
    }
}
