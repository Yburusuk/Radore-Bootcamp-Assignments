using ZorunlulukAttribute;

namespace AttributeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci
            {
                ad = textBox_ad.Text.Trim(),
                soyad = textBox_soyad.Text.Trim(),
                bolum = textBox_bolum.Text.Trim()
            };

            if (!ZorunlulukKontrolu.Dogrula(ogrenci))
            {
                MessageBox.Show("Hata: Öğrenci bilgileri eksik.");
                label_sonuc.Text = "Hata: Eksik bilgileri doldurun.";
            }
            else
            {
                label_sonuc.Text = $"Öğrenci kaydı başarılı: {ogrenci.ad} {ogrenci.soyad}, {ogrenci.bolum}.";
            }
        }
    }
}
