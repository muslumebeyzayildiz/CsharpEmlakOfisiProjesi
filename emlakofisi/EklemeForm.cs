using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using ClassLibrary;// OOOOOOOOOO:)))

namespace emlakofisi
{
    public partial class EklemeForm : Form
    {
        private Ev[] kayitlar = new Ev[1000]; // Sabit boyutlu dizi

        public EklemeForm()
        {
            InitializeComponent();
        }

        private void EklemeForm_Load(object sender, EventArgs e)
        {
            comboBox3.Items.Add("Konya");
            comboBox3.Items.Add("İstanbul");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Konya")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Selçuklu");
                comboBox1.Items.Add("Karatay");
                comboBox1.Items.Add("Meram");
            }
            if (comboBox3.Text == "İstanbul")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Beşiktaş");
                comboBox1.Items.Add("Beyoğlu");
                comboBox1.Items.Add("Kadıköy");
                comboBox1.Items.Add("Taksim");
                comboBox1.Items.Add("Zeytinburnu");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği bilgilerle yeni Ev nesnesi oluştur
            Ev yeniEv = new Ev();
            yeniEv.OdaSayisi = Convert.ToInt32(textBox1.Text);
            yeniEv.KatNumarasi = Convert.ToInt32(textBox3.Text);
            yeniEv.Semt = comboBox1.Text;
            yeniEv.Alani = Convert.ToDouble(textBox2.Text);
            yeniEv.YapimTarihi = dateTimePicker1.Value;
            yeniEv.Tur = (EvTur)Enum.Parse(typeof(EvTur), comboBox2.Text);

            // Ek bilgileri kontrol et ve atama yap
            if (checkBox1.Checked) // Kiralık ev
            {
                yeniEv.Depozito = Convert.ToDecimal(textBox4.Text);
                yeniEv.Kira = Convert.ToDecimal(textBox5.Text);
            }
            else if (checkBox2.Checked) // Satılık ev
            {
                yeniEv.Fiyat = Convert.ToDecimal(textBox6.Text);
            }


            // Oluşturulan Ev nesnesini sabit boyutlu diziye ekle
            for (int i = 0; i < kayitlar.Length; i++)
            {
                if (kayitlar[i] == null)
                {
                    kayitlar[i] = yeniEv;
                    break;
                }
            }

            if (checkBox1.Checked)
            {
                string dosyaAdi = "kiralik.txt";
                using (StreamWriter sw = new StreamWriter(dosyaAdi, true))
                {
                    sw.WriteLine($"{yeniEv.OdaSayisi},{yeniEv.KatNumarasi},{yeniEv.Semt},{yeniEv.Alani},{yeniEv.YapimTarihi},{yeniEv.Tur},{yeniEv.Depozito},{yeniEv.Kira}");
                }
            }

            if (checkBox2.Checked)
            {
                string dosyaAdi = "satilik.txt";
                using (StreamWriter sw = new StreamWriter(dosyaAdi, true))
                {
                    sw.WriteLine($"{yeniEv.OdaSayisi},{yeniEv.KatNumarasi},{yeniEv.Semt},{yeniEv.Alani},{yeniEv.YapimTarihi},{yeniEv.Tur},{yeniEv.Fiyat}");
                }
            }

            // MessageBox ile kaydedildi bilgisi göster
            MessageBox.Show("Kaydedildi");
        }

       
    }
}
