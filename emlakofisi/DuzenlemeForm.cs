using ClassLibrary;
using System;
using System.IO;
using System.Windows.Forms;

namespace emlakofisi
{
    public partial class DuzenlemeForm : Form
    {
        public Ev YeniBilgiler { get; private set; }

        public DuzenlemeForm(Ev seciliEv)
        {
            InitializeComponent();

            // Form yüklenirken, mevcut bilgileri göster
            textBox1.Text = seciliEv.OdaSayisi.ToString();
            textBox3.Text = seciliEv.KatNumarasi.ToString();
            comboBox1.Text = seciliEv.Semt;
            textBox2.Text = seciliEv.Alani.ToString();
            dateTimePicker1.Value = seciliEv.YapimTarihi;
            comboBox2.Text = seciliEv.Tur.ToString();
            textBox6.Text = seciliEv.Fiyat.ToString();

            // "Tamam" butonuna tıklandığında OnTamamButtonClick metodunu çağır
            buttonTamam.Click += new EventHandler(OnTamamButton_Click);
        }

        private void OnTamamButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan yeni bilgileri al
                Ev yeniBilgiler = new Ev
                {
                    OdaSayisi = Convert.ToInt32(textBox1.Text),
                    KatNumarasi = Convert.ToInt32(textBox3.Text),
                    Semt = comboBox1.Text,
                    Alani = Convert.ToDouble(textBox2.Text),
                    YapimTarihi = dateTimePicker1.Value,
                    Tur = (EvTur)Enum.Parse(typeof(EvTur), comboBox2.Text),
                    Fiyat = Convert.ToDecimal(textBox6.Text)
                };

                // Yeni bilgileri dosyaya yaz
                using (StreamWriter writer = new StreamWriter("satilik.txt", true))
                {
                    writer.WriteLine($"{yeniBilgiler.OdaSayisi},{yeniBilgiler.KatNumarasi},{yeniBilgiler.Semt},{yeniBilgiler.Alani},{yeniBilgiler.YapimTarihi},{yeniBilgiler.Tur},{yeniBilgiler.Fiyat}");
                }
                // Yeni bilgileri dışarıya aç
                YeniBilgiler = yeniBilgiler;

                // Formu kapat
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
