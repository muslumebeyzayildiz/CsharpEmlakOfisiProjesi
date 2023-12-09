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

namespace emlakofisi
{
    public partial class Form1 : Form
    {
        Ev[] evKayitlar = new Ev[1000];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EklemeForm evekleme = new EklemeForm();
            evekleme.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SorgulamaForm sorgulama = new SorgulamaForm(evKayitlar);
            sorgulama.Show();
        }
    }
}
