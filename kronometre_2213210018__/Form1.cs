using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kronometre_2213210018__
{
    public partial class Form1 : Form
    {
        public int KalanSure; 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSure.Text)) // Süre değerini boş girilince uyarı verir.
            {
                MessageBox.Show("Lütfen süre giriniz."); // Koşul gerçekleşirse çıktı.
                return;
            }

            if (cmbInterval.SelectedIndex == -1)  // hız değeri seçilmezse uyarı verir
            {
                MessageBox.Show("Lütfen hız giriniz."); // Koşul gerçekleşirse çıktı.
                return;
            }

            KalanSure = System.Convert.ToInt32(txtSure.Text);                                   // Kalan süre kullanıcıya gösterilir
            lblSure.Text = System.Convert.ToString(KalanSure);
            lbKayit.Items.Add("Kronometre Başladı:" + DateTime.Now.TimeOfDay.ToString());
            tmrKronometre.Interval = System.Convert.ToInt32(cmbInterval.Text);                //Timer kontrolünün çalışma hızını belirler.
            tmrKronometre.Start();                                                           // Timer kontrolünü çalıştırır.
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            tmrKronometre.Stop();                                                             //Timer kontrolünü durdurur.
            lbKayit.Items.Add("Kronometre Durduruldu:" + DateTime.Now.TimeOfDay.ToString()); // ListBox kontrolüne kayıt girilir.
        }

        private void tmrKronometre_Tick(object sender, EventArgs e)
        {
            KalanSure = KalanSure - 1;                             // Her saniye geçtiğinde sure değeri 1 azalacaktır
            lblSure.Text = System.Convert.ToString(KalanSure);    // KalanSure değeri kullancıya gösterilir
            if (KalanSure == 0)                                  // KalanSure değeri sıfıra ulaşmışsa kronometre durdurulur.
            {
                tmrKronometre.Stop();
                lbKayit.Items.Add("Süre Doldu:" + DateTime.Now.TimeOfDay.ToString());
                MessageBox.Show("Süre Doldu");                          // Süre dolunca ekrana "Süre Doldu" mesajını yazdırır.
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
