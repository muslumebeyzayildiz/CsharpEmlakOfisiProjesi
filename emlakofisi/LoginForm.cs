using System;
using System.Windows.Forms;
using System.IO;

namespace emlakofisi
{
    
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (AuthenticateUser(username, password))
            {
                // Yetkilendirme başarılı, Ana Form'u aç
                Form1 isim = new Form1();
                isim.Show();

                // Login Form'u kapat
                this.Hide();//üzerinde çalıştığım formu gizle
            }
            else
            {
                // Hatalı giriş durumunda bir label üzerinde hata mesajını göster
                label3.Text = "Hatalı kullanıcı adı veya şifre.";
            }
        }

        private bool AuthenticateUser(string enteredUsername, string enteredPassword)
        {
            string usersFilePath = "users.txt";

            // Dosya var mı kontrol et
            if (File.Exists(usersFilePath))
            {
                // Dosya varsa içeriği oku
                string[] lines = File.ReadAllLines(usersFilePath);

                // Her satırı kontrol et
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    // Kullanıcı adı ve şifre eşleşiyorsa true döndür
                    if (parts.Length == 2 && parts[0] == enteredUsername && parts[1] == enteredPassword)
                    {
                        return true;
                    }
                }
            }

            // Eğer dosya yoksa veya eşleşme bulunamazsa false döndür
            return false;
        }
    }
}
