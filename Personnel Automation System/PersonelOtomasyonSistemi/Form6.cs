using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelOtomasyonSistemi
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        

        Connection db = new Connection();
        string personelPicPath = "";
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form6 form6 = new Form6();
            form6.Show();
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
            medeniDurumID.SelectedIndex = medeniDurumCombo.SelectedIndex;
            if (medeniDurumCombo.SelectedIndex == 0)
            {
                cocukYok.Checked = true;
                label48.Visible = false;
                cocukSayisiCombo.Visible = false;
                label49.Visible = true;
             
                esAdiTxt.Visible = true;
                
            }
            else
            {
                label49.Visible = false;
                
                esAdiTxt.Visible = false;
                
            }
            if (medeniDurumCombo.SelectedIndex == 1)
            {
                label47.Visible = false;
                label48.Visible = false;
                cocukVar.Visible = false;
                cocukYok.Visible = false;
                cocukSayisiCombo.Visible = false;
            }
            else
            {
                cocukYok.Checked = true;
                label47.Visible = true;
                label48.Visible = false;
                cocukVar.Visible = true;
                cocukYok.Visible = true;

            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            label48.Visible = true;
            cocukSayisiCombo.Visible = true;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            label48.Visible = false;
            cocukSayisiCombo.Visible = false;
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
            cezaBilgiTxt.Visible = true;
            cezaBaslangicTxt.Visible = true;
            cezaBitisTxt.Visible = true;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            label118.Visible = false;
            label122.Visible = false;
            label126.Visible = false;
            cezaBilgiTxt.Visible = false;
            cezaBaslangicTxt.Visible = false;
            cezaBitisTxt.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        

        private void tabGorevBilgileri_Paint(object sender, PaintEventArgs e)
        {
            if(bolumAd.Items.Count < 1)
            {
               
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
                liste = db.selectTable("SELECT askerlikDurum FROM tblAskerlikDurum");
                for (int i = 0; i < liste.Count; i++)
                {
                    if (i % 2 == 0) askerlikDurumAd.Items.Add(liste[i].ToString());
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
            if (personelCinsiyet.SelectedIndex == 1)
            {
                label22.Enabled = false;
                askerlikDurumAd.Enabled = false;
            }
            else {
                label22.Enabled = true;
                askerlikDurumAd.Enabled = true;
            }
            cinsiyetId.SelectedIndex = personelCinsiyet.SelectedIndex;
        }

        private void personelKanGrubu_SelectedIndexChanged(object sender, EventArgs e)
        {
            kanGrubuId.SelectedIndex = personelKanGrubu.SelectedIndex;
        }

        private void askerlikDurumAd_SelectedIndexChanged(object sender, EventArgs e)
        {
     
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
            ComboBox tb = new ComboBox()
            {
                Name = "krmFATxb" + gpCount,
                Location = new Point(108, 19),
                Size = new Size(130, 20),
            };
            tb.SelectedIndexChanged += tb_SelectedIndexChanged;
            ComboBox tb_1 = new ComboBox()
            {
                Name = "krmFATxbGizli" + gpCount,
                Visible = false
            };
            Label lbl2 = new Label()
            {
                Name = "krmFALbl" + (gpCount + 1),
                Text = "Görev Birimi :",
                Location = new Point(12, 52),
                Size = new Size(66, 13)
            };
            ComboBox tb2 = new ComboBox()
            {
                Name = "krmFATx2b" + gpCount,
                Location = new Point(108, 49),
                Size = new Size(130, 20)
            };
            tb2.SelectedIndexChanged += tb2_SelectedIndexChanged;
            ComboBox tb2_1 = new ComboBox()
            {   //bölümid
                Name = "krmFATx2bGizli" + gpCount,
                Visible = false
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
                Name = "krmFATxbdatp" + gpCount,
                Location = new Point(108, 79),
                Format = DateTimePickerFormat.Short,
                Size = new Size(130, 20)
            };
            panelCalistigiKurumlar.Controls["gpKurum" + gpCount].Controls.Add(lbl);
            panelCalistigiKurumlar.Controls["gpKurum" + gpCount].Controls.Add(tb);
            panelCalistigiKurumlar.Controls["gpKurum" + gpCount].Controls.Add(tb_1);
            panelCalistigiKurumlar.Controls["gpKurum" + gpCount].Controls.Add(lbl2);
            panelCalistigiKurumlar.Controls["gpKurum" + gpCount].Controls.Add(tb2);
            panelCalistigiKurumlar.Controls["gpKurum" + gpCount].Controls.Add(tb2_1);
            panelCalistigiKurumlar.Controls["gpKurum" + gpCount].Controls.Add(lbl3);
            panelCalistigiKurumlar.Controls["gpKurum" + gpCount].Controls.Add(tb3);

            ComboBox hedef = panelCalistigiKurumlar.Controls["gpKurum" + gpCount].Controls["krmFATxb" + gpCount] as ComboBox;
            ComboBox hedefID = panelCalistigiKurumlar.Controls["gpKurum" + gpCount].Controls["krmFATxbGizli" + gpCount] as ComboBox;

            for (int i = 0; i < fakulteAdTxt.Items.Count; i++)
            {
                hedef.Items.Add(fakulteAdTxt.Items[i].ToString());
                hedefID.Items.Add(fakulteIdTxt.Items[i].ToString());
            }

                gpCount++;
            gpY += 110;
        }

        void tb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cmb = (ComboBox)sender;
                int id = int.Parse(cmb.Name.Replace("krmFATx2b",""));
                ComboBox cmbId = panelCalistigiKurumlar.Controls["gpKurum" + id].Controls["krmFATx2bGizli" + id] as ComboBox;

                cmbId.SelectedIndex = cmb.SelectedIndex;
            }
            catch (Exception)
            {}
        }

        void tb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cmb = (ComboBox)sender;
                int id = int.Parse(cmb.Name.Replace("krmFATxb", ""));
                ComboBox bolumCombo = panelCalistigiKurumlar.Controls["gpKurum" + id].Controls["krmFATx2b" + id] as ComboBox;
                ComboBox bolumIdCombo = panelCalistigiKurumlar.Controls["gpKurum" + id].Controls["krmFATx2bGizli" + id] as ComboBox;


                (panelCalistigiKurumlar.Controls["gpKurum" + id].Controls["krmFATxbGizli" + id] as ComboBox).SelectedIndex = cmb.SelectedIndex;

                ArrayList liste = new ArrayList();
                liste = db.selectTable("SELECT bolumID,bolumAdi FROM tblBolum WHERE fakulteID=" + (panelCalistigiKurumlar.Controls["gpKurum" + id].Controls["krmFATxbGizli" + id] as ComboBox).SelectedItem);
                

                bolumCombo.Items.Clear();
                bolumIdCombo.Items.Clear();

                for (int i = 0; i < liste.Count; i++)
                { //krmFATxbGizli
                    if (i % 2 == 0) bolumIdCombo.Items.Add(liste[i].ToString());
                    else bolumCombo.Items.Add(liste[i].ToString());
                }
            }
            catch (Exception)
            { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ArrayList perso = new ArrayList();
            perso = db.selectTable("SELECT TOP(1) personelID FROM tblPersonel ORDER BY personelID DESC");
            personelIDBaslat.Text = (int.Parse(perso[0].ToString()) + 1).ToString();
            ArrayList ilList = db.selectTable("SELECT ilAdi FROM tblIL");
            foreach (var item in ilList)
            {
                nufusIL.Items.Add(item);
                ikametgahIL.Items.Add(item);
            }
            ArrayList uyrukList = db.selectTable("SELECT uyrukAdi FROM tblUyruk");
            foreach (var item in uyrukList )
            {
                nufusUyruk.Items.Add(item);
            }
            // Görev Bilgileri
            ArrayList liste = new ArrayList();
            liste = db.selectTable("SELECT bolumID, bolumAdi FROM tblBolum");
            for (int i = 0; i < liste.Count; i++)
            {
                if (i % 2 == 0) bolumId.Items.Add(liste[i].ToString());
                else bolumAd.Items.Add(liste[i].ToString());
            }
            liste = db.selectTable("SELECT fakulteID, fakulteAdi FROM tblFakulte");
            for (int i = 0; i < liste.Count; i++)
            {
                if (i % 2 == 0)
                {
                    fakulteId.Items.Add(liste[i].ToString());
                }
                else
                {
                    fakulteAd.Items.Add(liste[i].ToString());
                }
            }
            liste = db.selectTable("SELECT bolumID, bolumAdi FROM tblBolum");
            for (int i = 0; i < liste.Count; i++)
            {
                if (i % 2 == 0)
                {
                    departmanId.Items.Add(liste[i].ToString());
                }
                else
                {
                    departmanTxt.Items.Add(liste[i].ToString());
                }
            }
            liste = db.selectTable("SELECT * FROM tblUnvan");
            for (int i = 0; i < liste.Count; i++)
            {
                if (i % 2 == 0)
                {
                    unvanId.Items.Add(liste[i].ToString());
                    unvanGenelId.Items.Add(liste[i].ToString());
                }
                else
                {
                    unvanAd.Items.Add(liste[i].ToString());
                    akademikUnvanTxt.Items.Add(liste[i].ToString());
                }
            }
        }

        private void nufusIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            nufusILCE.Items.Clear();
            nufusILCE.Text = "";
            int a = nufusIL.SelectedIndex + 1;
            ArrayList ilceList = db.selectTable("SELECT ilceAdi FROM tblILCE WHERE ilID=" + a + "");
            foreach (var item in ilceList)
            {
                nufusILCE.Items.Add(item);
            }
        }

        private void ikametgahIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            ikametgahILCE.Items.Clear();
            ikametgahILCE.Text = "";
            int a = ikametgahIL.SelectedIndex + 1;
            ArrayList ilceList = db.selectTable("SELECT ilceAdi FROM tblILCE WHERE ilID=" + a + "");
            foreach (var item in ilceList)
            {
                ikametgahILCE.Items.Add(item);
            }
        }


        private void tabAtamalar_Paint(object sender, PaintEventArgs e)
        {
            if(panelCalistigiKurumlar.Controls.Count < 1)
            {
                kurumBilgiEkle();
            }
            else
            {
                if (panelCalistigiKurumlar.Controls.IndexOf(panelCalistigiKurumlar.Controls["gpKurum1"]) != -1 && (panelCalistigiKurumlar.Controls["gpKurum1"].Controls["krmFATxbGizli1"] as ComboBox).Items.Count == 0)
                {
                    ArrayList liste = new ArrayList();
                    liste = db.selectTable("SELECT fakulteID,fakulteAdi FROM tblFakulte");
                    for (int i = 0; i < liste.Count; i++)
                    { //krmFATxbGizli
                        if (i % 2 == 0)
                        {
                            (panelCalistigiKurumlar.Controls["gpKurum1"].Controls["krmFATxbGizli1"] as ComboBox).Items.Add(liste[i].ToString());
                            fakulteIdTxt.Items.Add(liste[i].ToString());
                        }
                        else { (panelCalistigiKurumlar.Controls["gpKurum1"].Controls["krmFATxb1"] as ComboBox).Items.Add(liste[i].ToString());
                        fakulteAdTxt.Items.Add(liste[i].ToString());
                        }
                    }
                }
            }
        }

        private void kurumEkleArti_Click(object sender, EventArgs e)
        {
            kurumBilgiEkle();
        }

        private void kayitButon_Click(object sender, EventArgs e)
        {
            string maasbilgistring = maasBilgisi.Text.Replace(" ₺", "");
            listBox1.Items.Clear();          
            int hata = 0;
            foreach (var item in tabControls.TabPages)
            {
                TabPage denemeTab = ((TabPage)item);
                if (denemeTab.Name == "tabGorevBilgileri" || denemeTab.Name == "tabFaaliyet" || denemeTab.Name == "tabCeza" || denemeTab.Name == "tabIzin" || denemeTab.Name == "tabOzel" || denemeTab.Name == "tabSaglikBilgileri" || denemeTab.Name == "tabEgitim" || denemeTab.Name == "tabAileCocuk" || denemeTab.Name == "tabDeneyim" || denemeTab.Name == "tabAtamalar" || denemeTab.Name == "tabRaporlar" || denemeTab.Name == "tabIdariGunler")
                {

                }
                else
                {
                    if (FormController.kontrolTumTablar(denemeTab.Controls, listBox1) != 0) hata++;
                }
            }
                if (hata == 0)
                {
                    ArrayList pid = new ArrayList();
                    try
                    {
                        // ** tblPersonel ** //
                        db.insertTable("INSERT INTO tblPersonel "
                                      + "VALUES("
                                      + departmanId.SelectedItem + ","
                                      + "2," // durumID 2: Aktif , 1: Pasif
                                      + unvanGenelId.SelectedItem + ","
                                      + "'" + iseBaslamaTarihi.Value.ToString().Substring(0, 10) + "',"
                                      + float.Parse(maasbilgistring) + ","
                                      + ((cezaVar.Checked) ? 1 : 0) + ","
                                      + (tipCombo1.SelectedIndex + 1) + ","
                                      + (tipCombo2.SelectedIndex + 1)
                                      + ")"
                                      );

                       
                        pid = db.selectTable("SELECT TOP(1) personelID FROM tblPersonel ORDER BY personelID DESC");
                    }
                    catch (Exception)
                    {

                    }

                    try
                    {
                        // ** Genel Bilgiler ** //
                        // # Personel Kimlik
                        db.insertTable("INSERT INTO tblPersonelKimlik "
                                     + "VALUES("
                                     + "'" + personelAd.Text + "',"
                                     + "'" + personelSoyad.Text + "',"
                                     + "'" + personelIkinciAd.Text + "',"
                                     + pid[0] + ","
                                     + (askerlikDurumAd.SelectedIndex+1) + ","
                                     + cinsiyetId.SelectedItem + ","
                                     + kanGrubuId.SelectedItem + ","
                                     + ((engelDurumuVar.Checked) ? 1 : 0) + ","
                                     + kurumSicilNoTxt.Text + ","
                                     + sskNoTxt.Text
                                     + ")");
                        // #
                    }
                    catch (Exception)
                    {
                    }

                    try
                    {
                        //# Nüfus Bilgileri
                        db.insertTable("INSERT INTO tblNufusBilgileri "
                                      + "VALUES("
                                      + pid[0] + ","
                                      + "'" + nufusSeri.Text + "',"
                                      + nufusSeriNo.Text + ","
                                      + nufusTCNo.Text + ","
                                      + "'" + nufusBabaAdi.Text + "',"
                                      + "'" + nufusAnneAdi.Text + "',"
                                      + "'" + nufusIL.Text + "',"
                                      + "'" + nufusILCE.Text + "',"
                                      + "'" + nufusMahKoy.Text + "',"
                                      + nufusCiltNo.Text + ","
                                      + nufusAileSiraNo.Text + ","
                                      + nufusSiraNo.Text + ","
                                      + "'" + nufusDogumYeri.Text + "',"
                                      + "'" + nufusDogumTarihi.Value.Year + "-" + nufusDogumTarihi.Value.Month + "-" + nufusDogumTarihi.Value.Day + "',"
                                      + (nufusUyruk.SelectedIndex + 1) + ","
                                      + (medeniDurumCombo.SelectedIndex + 1) + ","
                                      + "'" + nufusVerildigiYer.Text + "',"
                                      + nufusVerilisNedeni.Text + ","
                                      + nufusKayitNo.Text + ","
                                      + "'" + nufusVerilisTarihi.Value.Year + "-" + nufusVerilisTarihi.Value.Month + "-" + nufusVerilisTarihi.Value.Day + "'"
                                      + ")");

                        //# İkametgah bilgileri
                        db.insertTable("INSERT INTO tblIkametgah VALUES("
                        + pid[0] + ","
                        + "'" + ikametgahMahTxt.Text + "',"
                        + "'" + ikametgahSokakTxt.Text + "',"
                        + "'" + ikametgahCaddeTxt.Text +"',"
                        + (ikametgahILCE.SelectedIndex + 1)
                        +")");
                    }
                    catch (Exception)
                    {
                    }
                   



                    //# Öğrenim Bilgileri
                    // NOT: tblOgrenimDurum silindi. ogrenimDurum sütunu tblOgrenim e aktarıldı.
                    string ogrenimdurumu = "";
                    if (okuryazar.Checked) ogrenimdurumu = "Okur yazar";
                    else if (ilkokul.Checked) ogrenimdurumu = "İlkokul";
                    else if (lise.Checked) ogrenimdurumu = "Lise";
                    else if (uni.Checked) ogrenimdurumu = "Üniversite";
                    else if (yuksekLisans.Checked) ogrenimdurumu = "Yüksek Lisans";
                    else if (doktora.Checked) ogrenimdurumu = "Doktora";
                    try
                    {
                        db.insertTable("INSERT INTO tblOgrenim VALUES("
                         + pid[0] + ","
                         + "'" + ilkOkulAdTxt.Text + "',"
                         + "'" + liseOkulAdTxt.Text + "',"
                         + "'" + uniOkulAdTxt.Text + "',"
                         + "'" + uniMezuniyet.Value.ToString().Substring(0, 10) + "',"
                         + ((uniSure.SelectedItem.ToString()) == "" ? 0 : uniSure.SelectedItem)
                         + "'" + yuksekLisansOkulTxt.Text + "',"
                         + "'" + yuksekLisansMezuniyet.Value.ToString().Substring(0, 10) + "',"
                         + "'" + doktoraOkulAdTxt.Text + "',"
                         + "'" + doktoraMezuniyet.Value.ToString().Substring(0, 10) + "',"
                         + "'" + ogrenimdurumu + "'"
                         + ")");
                    }
                    catch (Exception)
                    {
                    }

                    try
                    {
                        //# Aile-Çocuk
                        db.insertTable("INSERT INTO tblAileCocuk VALUES("
                            + (medeniDurumCombo.SelectedIndex + 1) + ","
                            + (cocukSayisiCombo.SelectedIndex + 1) + ","
                            + pid[0] + ","
                            + "'" + esAdiTxt.Text + "'"
                            + ")");


                        //# Sağlık Bilgileri
                        if (engelDurumuVar.Checked && engelDurum.SelectedIndex != -1)
                            db.insertTable("INSERT INTO tblHastalik VALUES("
                                + pid[0] + ","
                                + "'" + engelDurumNot.Text + "',"
                                + decimal.Parse(engelDurum.SelectedItem.ToString().Replace("%", ""))
                                + ")");
                    }
                    catch (Exception)
                    {
                    }


                    try
                    {
                        // # İletişim Bilgileri
                        db.insertTable("INSERT INTO tblIletisim VALUES("
                            + pid[0] + ","
                            + "'" + adresTxt.Text + "',"
                            + "'" + gsmTelTxt.Text + "',"
                            + "'" + evTelTxt.Text + "',"
                            + "'" + ePostaTxt.Text + "'"
                            + ")");

                        //# Görev Bilgileri
                        db.insertTable("INSERT INTO tblGorevBilgileri VALUES("
                            + bolumId.Text + ","
                            + unvanId.Text + ","
                            + "'" + iseGiris.Value.ToString().Substring(0, 10) + "',"
                            + "'" + isYeriTxt.Text + "',"
                            + dersSaatiSayisi.Text + ","
                            + pid[0]
                            + ")");

                    }
                    catch (Exception)
                    {
                    }
                    
                    //# Deneyim Bilgileri

                    try
                    {
                        //# Atamalar
                        int count = 1;
                        if (FormController.kontrolTumTablar(tabAtamalar.Controls, listBox1) == 0)
                        {

                            foreach (Control cmb in tabAtamalar.Controls["gpKurum" + count].Controls)
                            {
                                try
                                {
                                    ComboBox cmbid = cmb.Controls["krmFATx2b" + count] as ComboBox;
                                    DateTimePicker datp = cmb.Controls["krmFATxbdatp" + count] as DateTimePicker;
                                    db.insertTable("INSERT INTO tblAtamalar VALUES("
                                    + cmbid.SelectedItem + ","
                                    + "'" + datp.Value.ToString().Substring(0, 10) + "',"
                                    + "0"
                                    + ")");
                                    count++;
                                }
                                catch (Exception)
                                {
                                    break;
                                }
                            }
                            db.insertTable("INSERT INTO tblAtamalar VALUES("
                                    + gorevBirimiIdTxt.SelectedItem + ","
                                    + "'" + iseGiris.Value.ToString().Substring(0, 10) + "',"
                                    + "1"
                                    + ")");
                        }



                        //# Faaliyetler
                        for (int i = 1; i <= 6; i++)
                        {
                            TextBox tb = tabFaaliyet.Controls["faaliyet" + i + "Txt"] as TextBox;
                            ComboBox tur = tabFaaliyet.Controls["tur" + i] as ComboBox;
                            DateTimePicker datep = tabFaaliyet.Controls["faaliyet" + i] as DateTimePicker;
                            if (tb.Text != "" && tur.SelectedIndex != -1)
                                db.insertTable("INSERT INTO tblFaaliyet VALUES("
                                    + "'" + tb.Text + "',"
                                    + "'" + tur.SelectedItem + "',"
                                    + "'" + datep.Value.ToString().Substring(0, 10) + "',"
                                    + pid[0]
                                    + ")");
                        }
                    }
                    catch (Exception)
                    {
                    }

                    try
                    {
                        //# Ceza Bilgileri
                        if (cezaVar.Checked)
                        {
                            db.insertTable("INSERT INTO tblCeza VALUES("
                                + pid[0] + ","
                                + "'" + cezaBilgiTxt.Text + "',"
                                + "'" + cezaBaslangicTxt.Value.ToString().Substring(0, 10) + "',"
                                + "'" + cezaBitisTxt.Value.ToString().Substring(0, 10) + "'"
                                + ")");
                        }


                        if (izinCombo.SelectedIndex != -1) // İzin seçilmişse
                            //# Izin
                            db.insertTable("INSERT INTO tblIzin VALUES("
                              + (izinCombo.SelectedIndex + 1) + ","
                              + pid[0] + ","
                              + "'" + izinBaslama.Value.ToString().Substring(0, 10) + "',"
                              + "'" + izinBitis.Value.ToString().Substring(0, 10) + "'"
                              + ")");


                        if (ozelBilgi.Text.Trim() != "") // Özel bilgi girildiyse
                            //# Ozel Bilgi
                            db.insertTable("INSERT INTO tblOzelNot VALUES("
                                  + "'" + ozelBilgi.Text + "',"
                                  + pid[0]
                                  + ")");
                    }
                    catch (Exception)
                    {
                    }


                    try
                    {
                        //# Evraklar
                        int sayac = 1;
                        for (int i = 28; i <= 20; i--)
                        {
                            CheckBox cb = tabEvraklar.Controls["checkBox" + i] as CheckBox;
                            db.insertTable("INSERT INTO tblEvrak VALUES("
                            + pid[0] + ","
                            + sayac + ","
                            + ((cb.Checked) ? 1 : 0)
                            + ")");
                            sayac++;
                        }

                        //# Çıktılar
                        sayac = 1;
                        for (int i = 11; i <= 19; i++)
                        {
                            CheckBox cb = tabCikti.Controls["checkBox" + i] as CheckBox;
                            db.insertTable("INSERT INTO tblCikti VALUES("
                            + pid[0] + ","
                            + sayac + ","
                            + ((cb.Checked) ? 1 : 0)
                            + ")");
                            sayac++;
                        }


                        //# Raporlar
                        // fakültedeki personel dağılımı
                        db.insertTable("INSERT INTO tblRapor VALUES("
                            + pid[0] + ","
                            + "1,"
                            + ((checkBox47.Checked) ? 1 : 0)
                            + ")");
                        // fakültedeki bay/bayan dağılımı
                        db.insertTable("INSERT INTO tblRapor VALUES("
                            + pid[0] + ","
                            + "2,"
                            + ((checkBox46.Checked) ? 1 : 0)
                            + ")");
                        // fakültedeki öğretmen dağılımı
                        db.insertTable("INSERT INTO tblRapor VALUES("
                            + pid[0] + ","
                            + "3,"
                            + ((checkBox45.Checked) ? 1 : 0)
                            + ")");
                    }
                    catch (Exception)
                    {
                    }

                    try
                    {
                        // Resim
                        if (personelPicPath != "")
                            db.insertTable("INSERT INTO tblFotograf VALUES("
                                + "'" + personelPicPath.Replace(Application.StartupPath, "") + "',"
                                + pid[0]
                                + ")");
                    }
                    catch (Exception)
                    {
                    }
                  

                    label168.Visible = true;
                    MessageBox.Show("Personel kaydı başarıyla oluşturuldu !", "Başarılı");
                }
            
        }

        private void tabAileCocuk_Paint(object sender, PaintEventArgs e)
        {
            if (medeniDurumCombo.Items.Count < 1)
            {
                ArrayList liste = db.selectTable("SELECT * FROM tblMedeniHali");
                for(int i=0;i<liste.Count;i++)
                {
                    if (i % 2 == 0) medeniDurumID.Items.Add(liste[i].ToString());
                    else medeniDurumCombo.Items.Add(liste[i].ToString());
                }
            }
        }

        private void btnResimEkleDegistir_Click(object sender, EventArgs e)
        {
            try
            {
                string mainPath = Application.StartupPath + "/images/p";
                string resimAdresi = "";
                string uzanti = "";
                resimDialog.FileName = "";
                resimDialog.Filter = "Resim Dosyaları(jpg,jpeg,png)|*.jpg;*.png;*.jpeg";
                //resimDialog.ShowDialog();
                if (resimDialog.ShowDialog() == DialogResult.OK)
                {
                    resimAdresi = resimDialog.FileName;
                    if(resimAdresi.IndexOf(".jpeg") != -1)
                        uzanti = ".jpeg";
                    else if(resimAdresi.IndexOf(".jpg") != -1)
                        uzanti = ".jpg";
                    else if(resimAdresi.IndexOf(".png") != -1)
                        uzanti = ".png";

                    personelPicPath = mainPath + personelIDBaslat.Text + uzanti;

                    // Eğer personel bir resim seçti ise ve bunu değiştirmek istiyorsa kopyalanan resim silinir ve yeni ekleyeceği resim kopyalanır
                    if (File.Exists(personelPicPath))
                        File.Delete(personelPicPath);

                    File.Copy(resimAdresi, personelPicPath);

                    personelResimi.Image = Image.FromFile(personelPicPath);
                }
                
            }
            catch (Exception msg)
            { MessageBox.Show("hata:"+msg.Message); }
            
        }

        private void tabIzin_Paint(object sender, PaintEventArgs e)
        {
            if(izinCombo.Items.Count < 1)
            {
                ArrayList liste = new ArrayList();
                liste = db.selectTable("SELECT izinAdi FROM tblIzinTuru");
                foreach (string s in liste)
                    izinCombo.Items.Add(s);
            }
        }

        private void kurumSicilNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void sskNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void nufusTCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void nufusSeriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void nufusCiltNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void nufusAileSiraNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void nufusSiraNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void nufusKayitNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void maasBilgisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void maasBilgisi_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(maasBilgisi.Text, out value))
                maasBilgisi.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                maasBilgisi.Text = String.Empty;
        }

        private void dersSaatiSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        List<TabPage> tbpage = new List<TabPage>();
        private void tipCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbpage.Clear();
            if (tipCombo1.SelectedIndex == 2)
            {
                foreach (var item in tabControls.TabPages)
                {
                    TabPage denemeTab = ((TabPage)item);
                    if (denemeTab.Name == "tabGorevBilgileri" || denemeTab.Name == "tabDeneyim" || denemeTab.Name == "tabAtamalar" || denemeTab.Name == "tabRaporlar" || denemeTab.Name == "tabIdariGunler")
                    {
                        tbpage.Add(denemeTab);
                        tabControls.TabPages.Remove(denemeTab);
                    }
                }
            }
            else
            {
                foreach (var item in tbpage)
                {
                    //tabControls.TabPages.Add((TabPage)item);
                }
            }
        }

        private void fakulteAdTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            gorevBirimiIdTxt.Items.Clear();
            gorevBirimiAdTxt.Items.Clear();
                fakulteIdTxt.SelectedIndex = fakulteAdTxt.SelectedIndex;
                ArrayList liste = new ArrayList();
                liste = db.selectTable("SELECT bolumID,bolumAdi FROM tblBolum WHERE fakulteID=" + fakulteIdTxt.SelectedItem);
                for (int i = 0; i < liste.Count; i++)
                {
                    if (i % 2 == 0) gorevBirimiIdTxt.Items.Add(liste[i].ToString());
                    else gorevBirimiAdTxt.Items.Add(liste[i].ToString());
                }
            try
            {}
            catch (Exception)
            { }
        }

        private void gorevBirimiAdTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            gorevBirimiIdTxt.SelectedIndex = gorevBirimiAdTxt.SelectedIndex;
        }

        private void departmanTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            departmanId.SelectedIndex = departmanTxt.SelectedIndex;
        }

        private void akademikUnvanTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            unvanGenelId.SelectedIndex = akademikUnvanTxt.SelectedIndex;
        }


    }
}
