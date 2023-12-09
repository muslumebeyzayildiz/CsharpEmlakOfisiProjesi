using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using System.IO;

namespace emlakofisi
{
    public partial class SorgulamaForm : Form
    {
        private Ev[] kayitlar;
        public SorgulamaForm(Ev[] evKayitlar)
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Kullanıcının girdiği kriterleri al
            int odaSayisi = Convert.ToInt32(textBoxoda.Text);
            int katNumarasi = Convert.ToInt32(textBoxKat.Text);
            string semt = comboBoxSemt.Text;
            double alani = Convert.ToDouble(textBoxAlan.Text);
            EvTur tur = (EvTur)Enum.Parse(typeof(EvTur), comboBoxEvturu.Text);
            decimal maxFiyat = Convert.ToDecimal(textBoxfiyat.Text);


            string[] satirlar = File.ReadAllLines("satilik.txt");
            foreach (string satir in satirlar)
            {
                string[] satirParcalari = satir.Split(',');

                if (satirParcalari.Length >= 7) // Dizinin boyutunu kontrol et
                {
                    int odaSayisiSatir = Convert.ToInt32(satirParcalari[0]);
                    int katNumarasiSatir = Convert.ToInt32(satirParcalari[1]);
                    string semtSatir = satirParcalari[2];
                    double alaniSatir = Convert.ToDouble(satirParcalari[3]);
                    EvTur turSatir = (EvTur)Enum.Parse(typeof(EvTur), satirParcalari[5]);

                    decimal fiyatSatir;
                    if (Decimal.TryParse(satirParcalari[6], out fiyatSatir))
                    {
                        // Fiyatı başarıyla parse edebiliyorsak, kriterlere uyan satırları ListBox'a ekle
                        bool odaKriteri = odaSayisiSatir == odaSayisi;
                        bool katKriteri = katNumarasiSatir == katNumarasi;
                        bool semtKriteri = semtSatir == semt;
                        bool alanKriteri = alaniSatir == alani;
                        bool turKriteri = turSatir == tur;
                        bool fiyatKriteri = fiyatSatir <= maxFiyat;

                        if (odaKriteri && katKriteri && semtKriteri && alanKriteri && turKriteri && fiyatKriteri)
                        {
                            listBox1.Items.Add(satir);
                        }
                    }
                    else
                    {
                        // Fiyatı parse edemiyorsak, uygun bir hata işleme stratejisi seçebilirsiniz.
                    }
                }
                else
                {
                    // Dizinin beklenen boyutta olmadığını işleyebilirsiniz.
                }
            }
        }

        private void buttonduzenleme_Click(object sender, EventArgs e)
        {
            string seciliEvBilgisi = listBox1.SelectedItem as string;
            if (seciliEvBilgisi != null)
            {
                // Seçili evin bilgilerini al
                string[] evBilgileri = seciliEvBilgisi.Split(',');

                // DetaylarForm'u açmadan düzenleme yap
                Ev seciliEv = new Ev
                {
                    OdaSayisi = Convert.ToInt32(evBilgileri[0]),
                    KatNumarasi = Convert.ToInt32(evBilgileri[1]),
                    Semt = evBilgileri[2],
                    Alani = Convert.ToDouble(evBilgileri[3]),
                    YapimTarihi = DateTime.Parse(evBilgileri[4]),
                    Tur = (EvTur)Enum.Parse(typeof(EvTur), evBilgileri[5]),
                    Fiyat = Convert.ToDecimal(evBilgileri[6]),
                };

                // Yeni formu aç
                DuzenlemeForm duzenlemeForm = new DuzenlemeForm(seciliEv);
                duzenlemeForm.Show();
            }
        }

        private void buttonsilme_Click(object sender, EventArgs e)
        {
            string seciliEvBilgisi = listBox1.SelectedItem as string;
            if (seciliEvBilgisi != null)
            {
                // Seçili evi satilik.txt dosyasından sil
                listBox1.Items.Remove(seciliEvBilgisi);

                // satilik.txt dosyasını güncelle
                KayitlariGuncelle();
            }

        }

        private void buttonarsiv_Click(object sender, EventArgs e)
        {

        }
        private void KayitlariGuncelle()
        {
            // ListBox'taki kayıtları satilik.txt dosyasına yaz
            File.AppendAllLines("satilik.txt", listBox1.Items.Cast<string>());
        }
    }
}
