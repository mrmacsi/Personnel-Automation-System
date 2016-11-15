using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PersonelOtomasyonSistemi
{
    public partial class Form1 : Form
    {
        Connection db = new Connection();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kullaniciSifreTxt.PasswordChar = (char)42;
        }

        private void KullaniciAdiKutu_TextChanged(object sender, EventArgs e)
        {

        }

        private void GirisButon_Click(object sender, EventArgs e)
        {
            ListBox listbx = new ListBox();
            try
            {
                if (FormController.kontrolTumTablar(SozlukGirisPanel.Controls, listbx) == 0)
                {
                    string sif = Md5Encrypt.MakeMd5(kullaniciSifreTxt.Text);
                    //db.updateTable("update tblKullanici set kullaniciAdi="+ KullaniciAdiKutu.Text + ",kullaniciSifre='" + sif + "', where kullaniciID=1");
                    ArrayList sd = db.selectTable("select * from tblKullanici where kullaniciAdi='" + KullaniciAdiKutu.Text + "' and kullaniciSifre='" + sif + "'");
                    if (sd[0].ToString() != "")
                    {
                        Form1.ActiveForm.Hide();
                        Form3 form3 = new Form3();
                        form3.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Bulunamadi");
                    }
                }

            }
            catch (Exception mx)
            {
                MessageBox.Show(mx.Message);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}