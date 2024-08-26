namespace LoggerForm
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
            label_logType = new Label();
            cmb_logType = new ComboBox();
            label_status = new Label();
            textBox_status = new TextBox();
            button_save = new Button();
            label_result = new Label();
            SuspendLayout();
            // 
            // label_logType
            // 
            label_logType.AutoSize = true;
            label_logType.Location = new Point(247, 50);
            label_logType.Name = "label_logType";
            label_logType.Size = new Size(49, 15);
            label_logType.TabIndex = 0;
            label_logType.Text = "Log Tipi";
            // 
            // cmb_logType
            // 
            cmb_logType.FormattingEnabled = true;
            cmb_logType.Items.AddRange(new object[] { "DbLogger", "JsonLogger", "XmlLogger" });
            cmb_logType.Location = new Point(422, 47);
            cmb_logType.Name = "cmb_logType";
            cmb_logType.Size = new Size(155, 23);
            cmb_logType.TabIndex = 1;
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Location = new Point(247, 135);
            label_status.Name = "label_status";
            label_status.Size = new Size(44, 15);
            label_status.TabIndex = 2;
            label_status.Text = "Durum";
            // 
            // textBox_status
            // 
            textBox_status.Location = new Point(422, 132);
            textBox_status.Name = "textBox_status";
            textBox_status.Size = new Size(154, 23);
            textBox_status.TabIndex = 3;
            textBox_status.Text = "Lütfen durum giriniz";
            textBox_status.TextAlign = HorizontalAlignment.Center;
            // 
            // button_save
            // 
            button_save.Location = new Point(502, 222);
            button_save.Name = "button_save";
            button_save.Size = new Size(75, 23);
            button_save.TabIndex = 4;
            button_save.Text = "Kaydet";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // label_result
            // 
            label_result.AutoSize = true;
            label_result.Location = new Point(247, 271);
            label_result.Name = "label_result";
            label_result.Size = new Size(0, 15);
            label_result.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_result);
            Controls.Add(button_save);
            Controls.Add(textBox_status);
            Controls.Add(label_status);
            Controls.Add(cmb_logType);
            Controls.Add(label_logType);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_logType;
        private ComboBox cmb_logType;
        private Label label_status;
        private TextBox textBox_status;
        private Button button_save;
        private Label label_result;
    }
}
