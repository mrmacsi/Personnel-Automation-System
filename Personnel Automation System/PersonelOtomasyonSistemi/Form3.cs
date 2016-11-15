using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelOtomasyonSistemi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public int filtrePersonelId = 0;
        Connection db = new Connection();
        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox13.SelectedIndex == 0)
            {
                comboBox1.Items.Clear();
                comboBox1.Hide();
                textBox1.Show();
                textBox1.Text = "";
                label7.Text = "Ad Giriniz:";
            }
            else if (comboBox13.SelectedIndex == 1)
            {
                comboBox1.Items.Clear();
                comboBox1.Hide();
                textBox1.Show();
                textBox1.Text = "";
                label7.Text = "Soyad Giriniz:";
            }
            else if (comboBox13.SelectedIndex == 2)
            {
                comboBox1.Items.Clear();
                comboBox1.Hide();
                textBox1.Show();
                textBox1.Text = "";
                label7.Text = "TC No Giriniz:";
            }
            else if (comboBox13.SelectedIndex == 3)
            {
                comboBox1.Items.Clear();
                comboBox1.Show();
                textBox1.Hide();
                ArrayList list = db.selectTable("SELECT fakulteAdi FROM tblFakulte");
                foreach (var item in list)
                {
                    comboBox1.Items.Add(item);
                }
                label7.Text = "Fakülte Giriniz:";
            }
            else if (comboBox13.SelectedIndex == 4)
            {
                comboBox1.Items.Clear();
                comboBox1.Show();
                textBox1.Hide();
                ArrayList list = db.selectTable("SELECT bolumAdi FROM tblBolum");
                foreach (var item in list)
                {
                    comboBox1.Items.Add(item);
                }
                label7.Text = "Görev Birimi Giriniz:";
            }
            else
            {
                comboBox1.Items.Clear();
                comboBox1.Show();
                textBox1.Hide();
                ArrayList list = db.selectTable("SELECT unvanAdi FROM tblUnvan");
                foreach (var item in list)
                {
                    comboBox1.Items.Add(item);
                }
                label7.Text = "Unvan Giriniz:";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox13.SelectedIndex = 5;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filtrePersonelId != 0)
            {
                Form3.ActiveForm.Hide();
                Form5 form5 = new Form5(filtrePersonelId);
                form5.Show();
            }
            else
            {
                MessageBox.Show("Kimse Seçilmedi.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            if (comboBox13.SelectedIndex == 3)
            {
                //combobox selected+1 ine sahip olanların personel kişileri çekilecek
                int fakulteid = comboBox1.SelectedIndex + 1;
                List<int> bolumidleri = new List<int>();
                ArrayList liste = db.selectTable("SELECT bolumID FROM tblBolum WHERE tblBolum.fakulteID=" + fakulteid);
                if (liste.Count > 0)
                {
                    foreach (var item in liste)
                    {
                        ArrayList liste4 = db.selectTable("SELECT tcKimlikNo, ad, soyad ,  unvanID, bolumID,tblNufusBilgileri.personelID" +
                    " FROM tblPersonelKimlik, tblPersonel, tblNufusBilgileri WHERE tblNufusBilgileri.personelID=tblPersonelKimlik.personelID AND tblPersonelKimlik.personelID=tblPersonel.personelID AND " +
                    "tblPersonel.bolumID=" + item);
                        if (liste4.Count > 4)
                        {
                            int bolumid = (int)liste4[4];
                            int unvanid = (int)liste4[3];
                            ArrayList liste2 = db.selectTable("SELECT tblFakulte.fakulteAdi, tblBolum.bolumAdi" +
                                " FROM tblBolum, tblFakulte WHERE tblBolum.bolumID=" + bolumid + " AND tblFakulte.fakulteID=tblBolum.fakulteID");
                            ArrayList liste3 = db.selectTable("SELECT unvanAdi FROM tblUnvan WHERE unvanID = " + unvanid);
                            dataGridView1.Rows.Add(liste4[0], liste4[1], liste4[2], liste2[0], liste2[1], liste3[0], liste4[5]);
                        }
                    }
                }
            }
            else if (comboBox13.SelectedIndex == 4)
            {
                //bölümün idsi combobox selected+1 bu olanların listesi gelecek
                int bolumid = comboBox1.SelectedIndex + 1;
                List<int> bolumidleri = new List<int>();
                ArrayList liste = db.selectTable("SELECT bolumID FROM tblPersonel WHERE tblPersonel.bolumID=" + bolumid);
                if (liste.Count > 0)
                {
                    foreach (var item in liste)
                    {
                        ArrayList liste4 = db.selectTable("SELECT tcKimlikNo, ad, soyad ,  unvanID, bolumID,tblNufusBilgileri.personelID" +
                    " FROM tblPersonelKimlik, tblPersonel, tblNufusBilgileri WHERE tblNufusBilgileri.personelID=tblPersonelKimlik.personelID AND tblPersonelKimlik.personelID=tblPersonel.personelID AND " +
                    "tblPersonel.bolumID=" + item);
                        if (liste4.Count > 4)
                        {
                            bolumid = (int)liste4[4];
                            int unvanid = (int)liste4[3];
                            ArrayList liste2 = db.selectTable("SELECT tblFakulte.fakulteAdi, tblBolum.bolumAdi" +
                                " FROM tblBolum, tblFakulte WHERE tblBolum.bolumID=" + bolumid + " AND tblFakulte.fakulteID=tblBolum.fakulteID");
                            ArrayList liste3 = db.selectTable("SELECT unvanAdi FROM tblUnvan WHERE unvanID = " + unvanid);
                            dataGridView1.Rows.Add(liste4[0], liste4[1], liste4[2], liste2[0], liste2[1], liste3[0], liste4[5]);
                        }
                    }
                }
            }
            else if (comboBox13.SelectedIndex == 5)
            {
                //unvanid si combobox selected+1 olanların listesi gelecek
                int unvanid = comboBox1.SelectedIndex + 1;
                List<int> bolumidleri = new List<int>();
                ArrayList liste = db.selectTable("SELECT unvanID FROM tblPersonel WHERE tblPersonel.unvanID=" + unvanid);
                if (liste.Count > 0)
                {
                    foreach (var item in liste)
                    {
                        ArrayList liste4 = db.selectTable("SELECT tcKimlikNo, ad, soyad ,  unvanID, bolumID,tblNufusBilgileri.personelID" +
                    " FROM tblPersonelKimlik, tblPersonel, tblNufusBilgileri WHERE tblNufusBilgileri.personelID=tblPersonelKimlik.personelID AND tblPersonelKimlik.personelID=tblPersonel.personelID AND " +
                    "tblPersonel.unvanID=" + item);
                        if (liste4.Count > 4)
                        {
                            int bolumid = (int)liste4[4];
                            unvanid = (int)liste4[3];
                            ArrayList liste2 = db.selectTable("SELECT tblFakulte.fakulteAdi, tblBolum.bolumAdi" +
                                " FROM tblBolum, tblFakulte WHERE tblBolum.bolumID=" + bolumid + " AND tblFakulte.fakulteID=tblBolum.fakulteID");
                            ArrayList liste3 = db.selectTable("SELECT unvanAdi FROM tblUnvan WHERE unvanID = " + unvanid);
                            dataGridView1.Rows.Add(liste4[0], liste4[1], liste4[2], liste2[0], liste2[1], liste3[0], liste4[5]);
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            if (comboBox13.SelectedIndex == 0)
            {
                ArrayList liste = db.selectTable("SELECT tcKimlikNo, ad, soyad ,  unvanID, bolumID,tblNufusBilgileri.personelID" +
                    " FROM tblPersonelKimlik, tblPersonel, tblNufusBilgileri WHERE tblNufusBilgileri.personelID=tblPersonelKimlik.personelID AND tblPersonelKimlik.personelID=tblPersonel.personelID AND " +
                    "tblPersonelKimlik.ad='" + textBox1.Text + "'");
                if (liste.Count > 4)
                {
                    int bolumid = (int)liste[4];
                    int unvanid = (int)liste[3];
                    ArrayList liste2 = db.selectTable("SELECT tblFakulte.fakulteAdi, tblBolum.bolumAdi" +
                        " FROM tblBolum, tblFakulte WHERE tblBolum.bolumID=" + bolumid + " AND tblFakulte.fakulteID=tblBolum.fakulteID");
                    ArrayList liste3 = db.selectTable("SELECT unvanAdi FROM tblUnvan WHERE unvanID = " + unvanid);

                    dataGridView1.Rows.Add(liste[0], liste[1], liste[2], liste2[0], liste2[1], liste3[0], liste[5]);
                }
            }
            else if (comboBox13.SelectedIndex == 1)
            {
                ArrayList liste = db.selectTable("SELECT tcKimlikNo, ad, soyad ,  unvanID, bolumID,tblNufusBilgileri.personelID" +
                    " FROM tblPersonelKimlik, tblPersonel, tblNufusBilgileri WHERE tblNufusBilgileri.personelID=tblPersonelKimlik.personelID AND tblPersonelKimlik.personelID=tblPersonel.personelID AND " +
                    "tblPersonelKimlik.soyad='" + textBox1.Text + "'");
                if (liste.Count > 4)
                {
                    int bolumid = (int)liste[4];
                    int unvanid = (int)liste[3];
                    ArrayList liste2 = db.selectTable("SELECT tblFakulte.fakulteAdi, tblBolum.bolumAdi" +
                        " FROM tblBolum, tblFakulte WHERE tblBolum.bolumID=" + bolumid + " AND tblFakulte.fakulteID=tblBolum.fakulteID");
                    ArrayList liste3 = db.selectTable("SELECT unvanAdi FROM tblUnvan WHERE unvanID = " + unvanid);

                    dataGridView1.Rows.Add(liste[0], liste[1], liste[2], liste2[0], liste2[1], liste3[0], liste[5]);
                }
            }
            else if (comboBox13.SelectedIndex == 2)
            {
                ArrayList liste = db.selectTable("SELECT tcKimlikNo, ad, soyad ,  unvanID, bolumID,tblNufusBilgileri.personelID" +
                    " FROM tblPersonelKimlik, tblPersonel, tblNufusBilgileri WHERE tblNufusBilgileri.personelID=tblPersonelKimlik.personelID AND tblPersonelKimlik.personelID=tblPersonel.personelID AND " +
                    "tblNufusBilgileri.tcKimlikNo='" + textBox1.Text + "'");
                if (liste.Count > 4)
                {
                    int bolumid = (int)liste[4];
                    int unvanid = (int)liste[3];
                    ArrayList liste2 = db.selectTable("SELECT tblFakulte.fakulteAdi, tblBolum.bolumAdi" +
                        " FROM tblBolum, tblFakulte WHERE tblBolum.bolumID=" + bolumid + " AND tblFakulte.fakulteID=tblBolum.fakulteID");
                    ArrayList liste3 = db.selectTable("SELECT unvanAdi FROM tblUnvan WHERE unvanID = " + unvanid);

                    dataGridView1.Rows.Add(liste[0], liste[1], liste[2], liste2[0], liste2[1], liste3[0], liste[5]);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                try
                {
                    filtrePersonelId = (int)selectedRow.Cells[6].Value;
                }
                catch (Exception)
                {
                }


            }
        }
    }
}
