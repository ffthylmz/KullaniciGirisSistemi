using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA050622_G2
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> adSifre = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();


            adSifre.Add("admin", 1234);
            adSifre.Add("personel", 12345);
            adSifre.Add("fatih", 123456);


        }


        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == adSifre.ElementAt(0).Key && txtSifre.Text == adSifre.ElementAt(0).Value.ToString() || txtKullaniciAdi.Text == adSifre.ElementAt(1).Key && txtSifre.Text == adSifre.ElementAt(1).Value.ToString() || txtKullaniciAdi.Text == adSifre.ElementAt(2).Key && txtSifre.Text == adSifre.ElementAt(2).Value.ToString())
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();  // 2. formu açtıktan sonra form 1'i gizler.

                form2.KarsilamaMesajiYaz(txtKullaniciAdi.Text);
            }

            else
            {
                
                MessageBox.Show("Kullanıcı Adı veya Sifre Hatalı!!!");
            }
        }

        private void cbGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }
    }
}

