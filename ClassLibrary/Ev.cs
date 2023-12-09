using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public enum EvTur
    {
        Daire,
        Bahceli,
        Dubleks,
        Mustakil,
        // Diğer Türler
    }


    public class Ev
    {
        private static int _sonEmlakNumarasi = 0;

        public Ev(int odaSayisi, int katNumarasi, string semt, double alani)
        {
            OdaSayisi = odaSayisi;
            KatNumarasi = katNumarasi;
            Semt = semt;
            Alani = alani;

            EmlakNumarasi = ++_sonEmlakNumarasi;
            Aktif = true; // Varsayılan olarak ev aktif olarak başlasın
        }

        public Ev(int odaSayisi, int katNumarasi, string semt, double alani, DateTime yapimTarihi, EvTur tur)
            : this(odaSayisi, katNumarasi, semt, alani)
        {
            YapimTarihi = yapimTarihi;
            Tur = tur;
        }

        // Alanlar (Fields)
        private int _odaSayisi;
        private int _katNumarasi;
        private string _semt;
        private double _alani;
        private DateTime _yapimTarihi;
        private EvTur _tur;
        private bool _aktif;
        private int _emlakNumarasi;

        // Kiralık ev için
        private decimal _depozito;
        private decimal _kira;

        // Satılık ev için
        private decimal _fiyat;

        // Özellikler (Properties)
        public int OdaSayisi
        {
            get { return _odaSayisi; }
            set
            {
                if (value >= 0)
                    _odaSayisi = value;
                else
                {
                    _odaSayisi = 0;
                    LogKaydi("Oda Sayisi", "Negatif deger girildi.");
                }
            }
        }

        public int KatNumarasi
        {
            get { return _katNumarasi; }
            set
            {
                if (value > 0)
                    _katNumarasi = value;
                else
                {
                    _katNumarasi = 0;
                    LogKaydi("Kat Numarasi", "Sifirdan kucuk deger girildi.");
                }
            }
        }

        public string Semt
        {
            get { return _semt; }
            set { _semt = value; }
        }

        public double Alani
        {
            get { return _alani; }
            set
            {
                if (value > 0)
                    _alani = value;
                else
                {
                    _alani = 0;
                    LogKaydi("Alan", "Sifirdan kucuk deger girildi.");
                }
            }
        }

        public DateTime YapimTarihi
        {
            get { return _yapimTarihi; }
            set
            {
                if (value <= DateTime.Now)
                    _yapimTarihi = value;
                else
                {
                    _yapimTarihi = DateTime.Now;
                    LogKaydi("Yapim Tarihi", "Bugunden buyuk tarih girildi.");
                }
            }
        }

        public EvTur Tur
        {
            get { return _tur; }
            set { _tur = value; }
        }

        public bool Aktif
        {
            get { return _aktif; }
            set { _aktif = value; }
        }

        public int EmlakNumarasi
        {
            get { return _emlakNumarasi; }
            private set { _emlakNumarasi = value; }
        }

        public decimal Depozito { get; set; }
        public decimal Kira { get; set; }
        public decimal Fiyat { get; set; }


        // Yapım Tarihine göre evin yaşını hesaplayan property
        public int EvYasi
        {
            get { return DateTime.Now.Year - YapimTarihi.Year; }
        }

        // Kurucu Metot (Constructor)
        // Farklı versiyonları da eklenmiştir.
        public Ev()
        {
            EmlakNumarasi = ++_sonEmlakNumarasi;
            Aktif = true; // Varsayılan olarak ev aktif olarak başlasın
        }

        // Metotlar
        public virtual string EvBilgileri()//virtual yaptık türetilen sınıflar tarafından değiştirilebilsin
        {
            // string.Format metodu, belirli bir formatta bir dize oluşturmanızı sağlar.
            // {0}, {1}, {2}, ... gibi yer tutucular, ardından gelen parametre değerleriyle doldurulur.
            return string.Format("Emlak Numarası: {0}\nOda Sayısı: {1}\nKat Numarası: {2}\nSemt: {3}\nAlanı: {4}\n" +
                                 "Yapım Tarihi: {5}\nTür: {6}\nAktif: {7}\nEv Yaşı: {8} yıl\n",
                                 EmlakNumarasi, OdaSayisi, KatNumarasi, Semt, Alani, YapimTarihi.ToShortDateString(),
                                 Tur, Aktif, EvYasi);
        }

        public decimal FiyatHesapla()
        {
            decimal katsayi = OkuKatsayi(); // Katsayıyı oku

            // Katsayıyı oda sayısı ile çarp ve sonucu döndür
            return OdaSayisi * katsayi;
        }

        private decimal OkuKatsayi()
        {
            string dosyaAdi = "room_cost.txt";

            // Dosya var mı kontrol et
            if (File.Exists(dosyaAdi))
            {
                // Dosya varsa katsayıyı dosyadan oku
                using (StreamReader sr = new StreamReader(dosyaAdi))
                {
                    if (decimal.TryParse(sr.ReadLine(), out decimal katsayi))
                    {
                        return katsayi;
                    }
                    else
                    {
                        LogKaydi("OkuKatsayi", "Dosya içeriği geçerli bir sayı değil. Varsayılan katsayı kullanılacak.");
                        return 200; // Varsayılan katsayı
                    }
                }
            }
            else
            {
                // Dosya yoksa varsayılan katsayıyı kullan
                LogKaydi("OkuKatsayi", "Dosya bulunamadı. Varsayılan katsayı kullanılacak.");
                return 200; // Varsayılan katsayı
            }
        }

        protected void LogKaydi(string alanAdi, string hataMesaji)
        {
            string logSatiri = $"{DateTime.Now} - Hata! Alan: {alanAdi}, Hata Mesaji: {hataMesaji}";

            // Log dosyasına yazma işlemi
            string logDosyaYolu = "log.txt"; // Log dosyasının adı ve yolu
            using (StreamWriter sw = new StreamWriter(logDosyaYolu, true))
            {
                sw.WriteLine(logSatiri);
            }
        }
    }


    public class KiralikEv : Ev
    {
        private decimal _depozito;
        private decimal _kira;

        public decimal Depozito
        {
            get { return _depozito; }
            set
            {
                if (value >= 0)
                    _depozito = value;
                else
                {
                    _depozito = 0;
                    LogKaydi("Depozito", "Negatif deger girildi.");
                }
            }
        }

        public decimal Kira
        {
            get { return _kira; }
            set
            {
                if (value >= 0)
                    _kira = value;
                else
                {
                    _kira = 0;
                    LogKaydi("Kira", "Negatif deger girildi.");
                }
            }
        }

        // Kiralık ev için özel bir kurucu metod
        public KiralikEv(int odaSayisi, int katNumarasi, string semt, double alani, decimal depozito, decimal kira)
            : base(odaSayisi, katNumarasi, semt, alani)
        {
            Depozito = depozito;
            Kira = kira;
        }

        // EvBilgileri metodunu override ediyoruz
        public override string EvBilgileri()
        {
            // Ev sınıfının EvBilgileri metodunu çağırıp, kiralık ev özel bilgilerini ekliyoruz
            string evBilgileri = base.EvBilgileri();
            evBilgileri += string.Format("Depozito: {0}\nKira: {1}\n", Depozito, Kira);

            return evBilgileri;
        }
    }

    public class SatilikEv : Ev
    {
        private decimal _fiyat;

        public decimal Fiyat
        {
            get { return _fiyat; }
            set
            {
                if (value >= 0)
                    _fiyat = value;
                else
                {
                    _fiyat = 0;
                    LogKaydi("Fiyat", "Negatif deger girildi.");
                }
            }
        }

        // Satılık ev için özel bir kurucu metod
        public SatilikEv(int odaSayisi, int katNumarasi, string semt, double alani, decimal fiyat)
            : base(odaSayisi, katNumarasi, semt, alani)
        {
            Fiyat = fiyat;
        }

        // EvBilgileri metodunu override ediyoruz
        public override string EvBilgileri()
        {
            // Ev sınıfının EvBilgileri metodunu çağırıp, satılık ev özel bilgilerini ekliyoruz
            string evBilgileri = base.EvBilgileri();
            evBilgileri += string.Format("Fiyat: {0}\n", Fiyat);

            return evBilgileri;
        }
    }

}
