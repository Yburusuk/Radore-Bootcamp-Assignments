using LoggerForm.Classes;
using LoggerForm.Interfaces;

namespace LoggerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (cmb_logType.SelectedItem == null)
            {
                MessageBox.Show("Hata: Lütfen bir logger tipi seçiniz.");
                label_result.Text = "Hata: Lütfen bir logger tipi seçiniz."
            }
            else if (textBox_status.Text == "Lütfen durum giriniz" || textBox_status.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hata: Lütfen durum giriniz.");
                label_result.Text = "Hata: Lütfen durum giriniz.";
            }
            else
            {
                string selectedLogType = cmb_logType.SelectedItem.ToString();
                
                string status = textBox_status.Text.Trim();
                
                string response;

                LoggerFactory loggerFactory = new LoggerFactory();

                ILogger logger = loggerFactory.createLogger(selectedLogType);

                response = logger.log(status);
                
                label_result.Text = response;
            }
        }
    }
}
