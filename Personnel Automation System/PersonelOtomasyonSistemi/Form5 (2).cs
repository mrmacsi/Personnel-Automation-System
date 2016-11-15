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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Connection db = new Connection();
        private void button1_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = true;
            groupBox5.Visible = false;
            groupBox7.Visible = false;
        }
       

      

       

       

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox5.Visible = false;
            groupBox7.Visible = false;
        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = true;
            groupBox5.Visible = true;
            groupBox7.Visible = false;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox5.Visible = true;
            groupBox6.Visible = true;
            groupBox7.Visible = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = true;
            groupBox5.Visible = true;
            groupBox7.Visible = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox5.Visible = true;
            groupBox7.Visible = true;
            groupBox6.Visible = false;
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox15.SelectedIndex == 0)
            {
                radioButton9.Checked = true;
                label48.Visible = false;
                comboBox18.Visible = false;
                label49.Visible = true;
             
                textBox23.Visible = true;
                
            }
            else
            {
                label49.Visible = false;
                
                textBox23.Visible = false;
                
            }
            if (comboBox15.SelectedIndex == 1)
            {
                label47.Visible = false;
                label48.Visible = false;
                radioButton10.Visible = false;
                radioButton9.Visible = false;
                comboBox18.Visible = false;
            }
            else
            {
                radioButton9.Checked = true;
                label47.Visible = true;
                label48.Visible = false;
                radioButton10.Visible = true;
                radioButton9.Visible = true;

            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            label48.Visible = true;
            comboBox18.Visible = true;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            label48.Visible = false;
            comboBox18.Visible = false;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            label54.Visible = true;
            engelDurumNot.Visible = true;
            label53.Visible = true;
            engelDurum.Visible = true;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            label54.Visible = false;
            engelDurumNot.Visible = false;
            label53.Visible = false;
            engelDurum.Visible = false;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            label118.Visible = true;
            label122.Visible = true;
            label126.Visible = true;
            textBox85.Visible = true;
            textBox86.Visible = true;
            textBox87.Visible = true;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            label118.Visible = false;
            label122.Visible = false;
            label126.Visible = false;
            textBox85.Visible = false;
            textBox86.Visible = false;
            textBox87.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // ** tblPersonel ** //
            db.insertTable("INSERT INTO tblPersonel "
                          + "VALUES("
                          + bolumId.Text + ","
                          + 1 + "," // durumID
                          + unvanId.Text + ","
                          + "'" + iseBaslamaTarihi.Value.ToString().Substring(0,10) + "',"
                          + maasBilgisi.Text
                          +")"
                          );
            ArrayList pid = new ArrayList();
            pid=db.selectTable("SELECT TOP(1) personelID FROM tblPersonel ORDER BY personelID DESC");
            // ** Genel Bilgiler ** //
            // # Personel Kimlik
            db.insertTable("INSERT INTO tblPersonelKimlik "
                         +"VALUES("
                         +"'"+personelAd.Text+"',"
                         +"'"+personelSoyad.Text+"',"
                         +"'"+personelIkinciAd.Text+"',"
                         +pid[0]+","
                         +askerlikDurumId.SelectedItem+","
                         +cinsiyetId.SelectedItem+","
                         +kanGrubuId.SelectedItem
                         +")");
            // #
            //# Nüfus Bilgileri
           /* db.insertTable("INSERT INTO tblNufusBilgileri "
                          + "VALUES("
                          + pid[0]+","
                          + "'"+nufusSeri.Text+ "',"
                          + nufusSeriNo.Text+ ","
                          +nufusTCNo.Text + ","
                          +"'" + nufusBabaAdi.Text + "',"
                          + "'" + nufusAnneAdi.Text + "',"
                          +  "'" + nufusll.Text + "',"
                          + "'" + nufusIlce.Text + "',"
                          + "'" + nufusMahKoy.Text+ "',"
                          + nufusCiltNo.Text + ","
                          + nufusAileSiraNo.Text+ ","
                          + nufusSiraNo.Text+ ","
                         + "'" + nufusDogumYeri.Text + "',"
                         + "'" + nufusDogumTarihi.Text + "',"
                         +  nufusUyruk.SelectedItem + "',"
                       
                          + ")"); */

            //# Sağlık Bilgileri
            if (engelDurumuVar.Checked)
            {
                db.insertTable("INSERT INTO tblEngelDurum "
                         + "VALUES("
                         + "'" + engelDurum.SelectedItem+ "',"
                         + "'" + engelDurumNot.Text +"',"
                         +pid[0]
                         + ")");
            }
            
            // #

            label168.Visible = true;
        }

        

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void tabGorevBilgileri_Paint(object sender, PaintEventArgs e)
        {
            if(bolumAd.Items.Count < 1)
            {
                // Görev Bilgileri
                ArrayList liste = new ArrayList();
                liste = db.selectTable("SELECT bolumID, bolumAdi FROM tblBolum");
                for (int i = 0; i < liste.Count; i++)
                {
                    if (i % 2 == 0) bolumId.Items.Add(liste[i].ToString());
                    else bolumAd.Items.Add(liste[i].ToString());
                }
                liste = db.selectTable("SELECT fakulteID, fakulteAdi FROM tblFakulte");
                for(int i=0;i<liste.Count;i++)
                {
                    if (i % 2 == 0) fakulteId.Items.Add(liste[i].ToString());
                    else fakulteAd.Items.Add(liste[i].ToString());
                }
                liste = db.selectTable("SELECT * FROM tblUnvan");
                for (int i = 0; i < liste.Count; i++)
                {
                    if (i % 2 == 0) unvanId.Items.Add(liste[i].ToString());
                    else unvanAd.Items.Add(liste[i].ToString());
                }
            }
        }

        private void tabGenelBilgiler_Paint(object sender, PaintEventArgs e)
        {
            if (personelCinsiyet.Items.Count < 1)
            {
                // Genel Bilgiler
                ArrayList liste = new ArrayList();
                liste = db.selectTable("SELECT * FROM tblCinsiyet");
                for (int i = 0; i < liste.Count; i++)
                {
                    if (i % 2 == 0) cinsiyetId.Items.Add(liste[i].ToString());
                    else personelCinsiyet.Items.Add(liste[i].ToString());
                }
                liste = db.selectTable("SELECT * FROM tblKanGrubu");
                for (int i = 0; i < liste.Count; i++)
                {
                    if (i % 2 == 0) kanGrubuId.Items.Add(liste[i].ToString());
                    else personelKanGrubu.Items.Add(liste[i].ToString());
                }
                liste = db.selectTable("SELECT * FROM tblAskerlikDurum");
                for (int i = 0; i < liste.Count; i++)
                {
                    if (i % 2 == 0) askerlikDurumId.Items.Add(liste[i].ToString());
                    else askerlikDurumAd.Items.Add(liste[i].ToString());
                }
            }
        }

        private void fakulteAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            fakulteId.SelectedIndex = fakulteAd.SelectedIndex;

        }

        private void bolumAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            bolumId.SelectedIndex = bolumAd.SelectedIndex;
        }

        private void unvanAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            unvanId.SelectedIndex = unvanAd.SelectedIndex;
        }

        private void personelCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            cinsiyetId.SelectedIndex = personelCinsiyet.SelectedIndex;
        }

        private void personelKanGrubu_SelectedIndexChanged(object sender, EventArgs e)
        {
            kanGrubuId.SelectedIndex = personelKanGrubu.SelectedIndex;
        }

        private void askerlikDurumAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            askerlikDurumId.SelectedIndex = askerlikDurumAd.SelectedIndex;
        }
        int gpCount=1, gpX = 3, gpY = 3;
        void kurumBilgiEkle()
        {
            GroupBox gp = new GroupBox()
            {
                Name = "gpKurum"+gpCount,
                Text = "Kurum "+gpCount,
                Size = new Size(264, 104),
                Location = new Point(gpX, gpY)
            };
            panelCalistigiKurumlar.Controls.Add(gp);
            Label lbl = new Label()
            {
                Name = "krmFALbl" + gpCount,
                Text = "Fakülte adı :",
                Location = new Point(12,22),
                Size = new Size(66, 13)
            };
            TextBox tb = new TextBox()
            {
                Name = "krmFATxb" + gpCount,
                Location = new Point(108, 19),
                Size = new Size(130, 20)
            };
            Label lbl2 = new Label()
            {
                Name = "krmFALbl" + (gpCount + 1),
                Text = "Görev Birimi :",
                Location = new Point(12, 52),
                Size = new Size(66, 13)
            };
            TextBox tb2 = new TextBox()
            {
                Name = "krmFATxb" + (gpCount + 1),
                Location = new Point(108, 49),
                Size = new Size(130, 20)
            };
            Label lbl3 = new Label()
            {
                Name = "krmFALbl" + (gpCount + 2),
                Text = "Ayrılış Tarihi :",
                Location = new Point(12, 82),
                Size = new Size(66, 13)
            };
            DateTimePicker tb3 = new DateTimePicker()
            {
                Name = "krmFATxb" + (gpCount + 2),
                Location = new Point(108, 79),
                Format = DateTimePickerFormat.Short,
                Size = new Size(130, 20)
            };
            panelCalistigiKurumlar.Controls["gpKurum" + gpCount].Controls.Add(lbl);
            panelCalistigiKurumlar.Controls["gpKurum" + gpCount].Controls.Add(tb);
            panelCalistigiKurumlar.Controls["gpKurum" + gpCount].Controls.Add(lbl2);
            panelCalistigiKurumlar.Controls["gpKurum" + gpCount].Controls.Add(tb2);
            panelCalistigiKurumlar.Controls["gpKurum" + gpCount].Controls.Add(lbl3);
            panelCalistigiKurumlar.Controls["gpKurum" + gpCount].Controls.Add(tb3);
            gpCount++;
            gpY += 110;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void tabAtamalar_Paint(object sender, PaintEventArgs e)
        {
            if(panelCalistigiKurumlar.Controls.Count < 1)
            {
                kurumBilgiEkle();
            }
        }

        private void kurumEkleArti_Click(object sender, EventArgs e)
        {
            kurumBilgiEkle();
        }



       
    }
}
