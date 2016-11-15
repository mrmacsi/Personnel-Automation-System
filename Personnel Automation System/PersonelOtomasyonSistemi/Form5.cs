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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public int gelenPersonelID = 0;

        public Form5(int id)
        {
            gelenPersonelID = id;
            InitializeComponent();
        }

        string personelPicPath = "";
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

        

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            try
            {
                cinsiyetId.SelectedIndex = personelCinsiyet.SelectedIndex;
            }
            catch (Exception)
            {
                
            }
        }

        private void personelKanGrubu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                kanGrubuId.SelectedIndex = personelKanGrubu.SelectedIndex;
            }
            catch (Exception)
            {
            }
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
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
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

            //
            if (nufusIL.Items.Count > 0 && nufusIL.SelectedIndex == -1)
            {
                int ilid, ilceid;
                // NÜFUS BİLGİLERİ
                ArrayList nufusbilgilerlist = db.selectTable(" SELECT N.tcKimlikNo,N.seri,N.seriNo,N.ciltNo,N.aileSiraNo,N.siraNo,N.anaAdi,N.babaAdi,N.dogumYeri,N.dogumTarihi,N.verildigiYer,VD.verilisNedeni,N.verilisTarihi,N.kayitNo,U.uyrukAdi,N.nufusKayitIl,N.nufusKayitIlce,N.nufusKayitMahKoy "
                    + "FROM tblNufusBilgileri N INNER JOIN tblVerilisNedeni VD ON N.verilisNedeniID = VD.verilisNedeniID "
                    + "INNER JOIN tblUyruk U ON N.uyrukID=U.uyrukID "
                   + "WHERE N.personelID= " + gelenPersonelID + "");
                if (nufusbilgilerlist.Count > 0)
                {
                    nufusTCNo.Text = nufusbilgilerlist[0].ToString();
                    nufusSeri.Text = nufusbilgilerlist[1].ToString();
                    nufusSeriNo.Text = nufusbilgilerlist[2].ToString();
                    nufusCiltNo.Text = nufusbilgilerlist[3].ToString();
                    nufusAileSiraNo.Text = nufusbilgilerlist[4].ToString();
                    nufusSiraNo.Text = nufusbilgilerlist[5].ToString();
                    nufusAnneAdi.Text = nufusbilgilerlist[6].ToString();
                    nufusBabaAdi.Text = nufusbilgilerlist[7].ToString();
                    nufusDogumYeri.Text = nufusbilgilerlist[8].ToString();
                    nufusDogumTarihi.Value = Convert.ToDateTime(nufusbilgilerlist[9]);
                    nufusVerildigiYer.Text = nufusbilgilerlist[10].ToString();
                    nufusVerilisNedeni.Text = nufusbilgilerlist[11].ToString();
                    nufusVerilisTarihi.Value = Convert.ToDateTime(nufusbilgilerlist[12]);
                    nufusKayitNo.Text = nufusbilgilerlist[13].ToString();
                    nufusUyruk.SelectedItem = nufusbilgilerlist[14].ToString();

                    ilid = nufusIL.FindString(nufusbilgilerlist[15].ToString());
                    nufusIL.SelectedIndex = ilid + 1;
                    ilceid = nufusIL.FindString(nufusbilgilerlist[16].ToString());
                    nufusILCE.SelectedIndex = ilceid + 1;
                    nufusMahKoy.Text = nufusbilgilerlist[17].ToString();
                }
                // NUFUS DEVAM
                try
                {
                    ArrayList nufusbilgiler2list =
                    db.selectTable("SELECT I.ikametgahMah,I.ikametgahSok,I.ikametgahCad,Ilc.ilceAdi,Il.ilAdi "
                     + "FROM tblIkametgah I INNER JOIN tblILCE Ilc ON I.ilceAdi=Ilc.ilceAdi "
                     + "INNER JOIN tblIL Il ON Ilc.ilID=Il.ilID "
                     + "WHERE I.personelID=" + gelenPersonelID + "");
                    if (nufusbilgiler2list.Count > 0)
                    {
                        ikametgahMahTxt.Text = nufusbilgiler2list[0].ToString();
                        ikametgahSokakTxt.Text = nufusbilgiler2list[1].ToString();
                        ikametgahCaddeTxt.Text = nufusbilgiler2list[2].ToString();
                        int ilceid2 = ikametgahILCE.FindString(nufusbilgiler2list[3].ToString());
                        ikametgahILCE.SelectedIndex = ilceid2 + 1;
                        int ilid2 = ikametgahIL.FindString(nufusbilgiler2list[4].ToString());
                        ikametgahIL.SelectedIndex = ilid2 + 1;

                    }
                }
                catch (Exception)
                {
                }

            }
            //

            //GENEL BİLGİLER 

            ArrayList gorevtipi = db.selectTable("SELECT T.tipAdi FROM tblTip T INNER JOIN tblPersonel P ON T.tipID=P.tipID "
                + " WHERE P.personelId=" + gelenPersonelID + "");
            tipCombo1.SelectedItem = gorevtipi[0].ToString();
            ArrayList calismatipi = db.selectTable("SELECT C.calismaZamanAdi FROM tblCalismaZaman C INNER JOIN tblPersonel P ON C.calismaID = P.calismaID "
               + " WHERE P.personelId=" + gelenPersonelID + "");
            tipCombo2.SelectedItem = calismatipi[0].ToString();

            // GENEL BİLGİLER 2
            ArrayList genelbilgi2 = db.selectTable("SELECT PK.kurumSicilNo,PK.SSKNo FROM tblPersonelKimlik PK "
                + "WHERE PK.personelID =" + gelenPersonelID + "");
            kurumSicilNoTxt.Text = genelbilgi2[0].ToString();
            sskNoTxt.Text = genelbilgi2[0].ToString();
            ArrayList iseBaslama = db.selectTable("SELECT P.iseBaslamaTarihi FROM tblPersonel P "
                + "WHERE P.personelID= " + gelenPersonelID + "");
            iseBaslamaTarihi.Value = Convert.ToDateTime(iseBaslama[0]);
            ArrayList unvan = db.selectTable("SELECT U.unvanAdi FROM tblUnvan U INNER JOIN tblPersonel P ON U.unvanID = P.unvanID "
               + "WHERE P.personelID= " + gelenPersonelID + "");
            akademikUnvanTxt.SelectedItem = unvan[0].ToString();
            ArrayList departman = db.selectTable("SELECT P.bolumID FROM tblPersonel P INNER JOIN tblBolum B ON P.bolumID=B.bolumID "
             + "WHERE P.personelID= " + gelenPersonelID + "");
            departmanTxt.SelectedIndex = Convert.ToInt32(departman[0]) - 1;
        

            //EGİTİM BİLGİLERİ

            ArrayList egitimbilgi = db.selectTable("SELECT O.ilkOkulAdi,O.liseAdi,O.universiteAdi,O.universiteMezTar,O.universiteSure,O.yuksekLisansAdi,O.yuksekLisansTar,O.doktoraAdi,O.doktoraTar,O.ogrenimDurum FROM TBLOgrenim O WHERE O.personelID = " + gelenPersonelID + "");
            int say = 0;
            for (int i = 0; i < egitimbilgi.Count; i++)
            {
                if (egitimbilgi[i].ToString() != "")
                {

                    say++;
                }
            }
            if (say == 2)
            {
                ilkokul.Checked = true;
                ilkOkulAdTxt.Text = egitimbilgi[0].ToString();
            }
            else if (say == 3)
            {
                lise.Checked = true;
                ilkOkulAdTxt.Text = egitimbilgi[0].ToString();
                liseOkulAdTxt.Text = egitimbilgi[1].ToString();
            }
            else if (say == 6)
            {
                uni.Checked = true;
                ilkOkulAdTxt.Text = egitimbilgi[0].ToString();
                liseOkulAdTxt.Text = egitimbilgi[1].ToString();
                uniOkulAdTxt.Text = egitimbilgi[2].ToString();
                uniMezuniyet.Value = Convert.ToDateTime(egitimbilgi[3]);
                uniSure.SelectedItem = egitimbilgi[4].ToString();
            }
            else if (say == 8)
            {
                yuksekLisans.Checked = true;
                ilkOkulAdTxt.Text = egitimbilgi[0].ToString();
                liseOkulAdTxt.Text = egitimbilgi[1].ToString();
                uniOkulAdTxt.Text = egitimbilgi[2].ToString();
                uniMezuniyet.Value = Convert.ToDateTime(egitimbilgi[3]);
                uniSure.SelectedItem = egitimbilgi[4].ToString();
                yuksekLisansOkulTxt.Text = egitimbilgi[5].ToString();
                yuksekLisansMezuniyet.Value = Convert.ToDateTime(egitimbilgi[6]);
            }
            else if (say == 9)
            {
                doktora.Checked = true;
                ilkOkulAdTxt.Text = egitimbilgi[0].ToString();
                liseOkulAdTxt.Text = egitimbilgi[1].ToString();
                uniOkulAdTxt.Text = egitimbilgi[2].ToString();
                uniMezuniyet.Value = Convert.ToDateTime(egitimbilgi[3]);
                uniSure.SelectedItem = egitimbilgi[4].ToString();
                yuksekLisansOkulTxt.Text = egitimbilgi[5].ToString();
                yuksekLisansMezuniyet.Value = Convert.ToDateTime(egitimbilgi[6]);
                doktoraOkulAdTxt.Text = egitimbilgi[7].ToString();
                doktoraMezuniyet.Value = Convert.ToDateTime(egitimbilgi[8]);
            }
            else
            {
                okuryazar.Checked = true;

            }
            try
            {
                //CEZALAR
                ArrayList cezalar = db.selectTable("SELECT cezaBilgisi,cezaBaslamaTar,cezaBitisTar FROM tblCeza WHERE personelID=" + gelenPersonelID);
                if (cezalar.Count == 0)
                    cezaYok.Checked = false;
                else
                {
                    cezaYok.Checked = true;
                    cezaBilgiTxt.Text = cezalar[0].ToString();
                    cezaBaslangicTxt.Value = Convert.ToDateTime(cezalar[1]);
                    cezaBitisTxt.Value = Convert.ToDateTime(cezalar[2]);
                }
                //GÖREV BİLGİLERİ
                ArrayList gorevBilgi = db.selectTable("SELECT GB.dersSaati,GB.isYeri,GB.iseGirisTarihi,B.bolumAdi,F.fakulteAdi,U.unvanAdi "
                + "FROM tblGorevBilgileri GB "
                + "inner join tblBolum B ON B.bolumID = GB.bolumID "
                + "inner join tblFakulte F ON F.fakulteID = B.fakulteID "
                + "inner join tblUnvan U ON U.unvanID = GB.unvanID "
                + "WHERE GB.personelID=" + gelenPersonelID);
                if (gorevBilgi.Count > 0)
                {
                    textBox68.Text = gorevBilgi[0].ToString();
                    isYeriTxt.Text = gorevBilgi[1].ToString();
                    iseBaslamaTarihi.Value = Convert.ToDateTime(gorevBilgi[2]);
                    bolumAd.SelectedIndex = bolumAd.FindString(gorevBilgi[3].ToString());
                    fakulteAd.SelectedIndex = fakulteAd.FindString(gorevBilgi[4].ToString());
                    unvanAd.SelectedIndex = unvanAd.FindString(gorevBilgi[5].ToString());
                }
                //Ceza
                ArrayList ceza = db.selectTable("SELECT cezaBilgisi,cezaBaslamaTar,cezaBitisTar FROM tblCeza WHERE personelID=" + gelenPersonelID);
                if (ceza.Count > 0)
                {
                    cezaVar.Checked = true;
                    cezaBilgiTxt.Text = ceza[0].ToString();
                    cezaBaslangicTxt.Value = Convert.ToDateTime(ceza[1]);
                    cezaBitisTxt.Value = Convert.ToDateTime(ceza[2]);
                }
                //MAAŞ
                ArrayList maas = db.selectTable("SELECT maas FROM tblPersonel WHERE personelID=" + gelenPersonelID);
                if (maas.Count > 0) maasBilgisi.Text = maas[0].ToString();

                //İLETİŞİM
                ArrayList iletisim = db.selectTable("SELECT gsm,evTel,eMail,adres FROM tblIletisim WHERE personelID=" + gelenPersonelID);
                if (iletisim.Count > 0)
                {
                    gsmTelTxt.Text = iletisim[0].ToString();
                    evTelTxt.Text = iletisim[1].ToString();
                    ePostaTxt.Text = iletisim[2].ToString();
                    adresTxt.Text = iletisim[3].ToString();
                }
                //rapor
                ArrayList raporlar = db.selectTable("SELECT raporBilgiID FROM tblRapor WHERE personelID=" + gelenPersonelID);

                for (int i = 0; i < raporlar.Count; i++)
                {
                    int degisken = 48 - (int.Parse(raporlar[i].ToString()));
                    (tabRaporlar.Controls["checkBox" + degisken.ToString()] as CheckBox).Checked = true;
                }
                //evrak
                ArrayList evraklar = db.selectTable("SELECT evrakBilgiID FROM tblEvrak WHERE personelID=" + gelenPersonelID);
                say = 1;
                for (int i = 0; i < evraklar.Count; i++)
                {
                    int degisken = 28 - (int.Parse(evraklar[i].ToString()));
                    (tabEvraklar.Controls["checkBox" + degisken.ToString()] as CheckBox).Checked = true;
                }
                //Cikti
                ArrayList ciktilar = db.selectTable("SELECT ciktiBilgiID FROM tblCikti WHERE personelID=" + gelenPersonelID);
                for (int i = 0; i < ciktilar.Count; i++)
                {
                    int degisken = (int.Parse(ciktilar[i].ToString()) + 11);
                    (tabCikti.Controls["checkBox" + degisken.ToString()] as CheckBox).Checked = true;
                }
                //fAALİYET
                ArrayList faaliyetler = db.selectTable("SELECT faaliyetAdi, faaliyetTuru, faaliyetTarihi FROM tblFaaliyet WHERE personelID=" + gelenPersonelID);
                say = 1;
                for (int i = 0; i < faaliyetler.Count; i += 3)
                {
                    tabFaaliyet.Controls["faaliyet" + say + "Txt"].Text = faaliyetler[i].ToString();
                    tabFaaliyet.Controls["tur" + say].Text = faaliyetler[i + 1].ToString();
                    (tabFaaliyet.Controls["faaliyet" + say] as DateTimePicker).Text = faaliyetler[i + 2].ToString();
                    say++;
                }
                //izin
                ArrayList izinler = db.selectTable("SELECT IT.izinAdi,I.izinBaslangic,izinBitis "
                + "FROM tblIzin I "
                + "inner join tblIzinTuru IT ON I.izinTurID = IT.izinTurID "
                + "WHERE I.personelID=" + gelenPersonelID);
                if (izinler.Count > 0)
                {
                    izinCombo.SelectedIndex = izinCombo.FindString(izinler[0].ToString());
                    izinBaslama.Value = Convert.ToDateTime(izinler[1]);
                    izinBitis.Value = Convert.ToDateTime(izinler[2]);
                }
                //AİLE COCUK
                ArrayList ailecocuk = db.selectTable("SELECT MH.medeniHali,A.cocukSayisi,A.esininAdi "
                + "FROM tblAileCocuk A "
                + "inner join tblMedeniHali MH ON A.medeniHaliID = MH.medeniHaliID "
                + "WHERE A.personelID=" + gelenPersonelID);
                if (ailecocuk.Count > 0)
                {
                    medeniDurumCombo.SelectedIndex = medeniDurumCombo.FindString(ailecocuk[0].ToString());
                    if (medeniDurumCombo.FindString(ailecocuk[0].ToString()) != 1)
                    {
                        if ((int)ailecocuk[1] > 0)
                        {
                            cocukVar.Checked = true;
                            cocukSayisiCombo.SelectedIndex = cocukSayisiCombo.FindString(ailecocuk[1].ToString());
                        }
                        else
                        {
                            cocukVar.Checked = false;
                        }
                        esAdiTxt.Text = ailecocuk[2].ToString();
                    }
                }
                //ÖZEL BİLGİLER
                ArrayList ozelbilgi = db.selectTable("SELECT ozelNot FROM tblOzelNot WHERE personelID=" + gelenPersonelID);
                if (ozelbilgi.Count > 0) ozelBilgi.Text = ozelbilgi[0].ToString();
                //özel bilgi
            }
            catch (Exception)
            {
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

        public int hata = 0;
        private void button6_Click_1(object sender, EventArgs e)
        {
            //sınırlı erişim için kod
            string maasbilgistring = maasBilgisi.Text.Replace(" ₺", "");
            //tüm erişimleri için kod
            foreach (var item in tabControls.TabPages)
            {
                TabPage denemeTab = ((TabPage)item);
                if (FormController.kontrolTumTablar(denemeTab.Controls, listBox1) != 0) hata++;
            }
           
            if(nufusTCNo.Text.Length != 11)
               listBox1.Items.Add("TC Kimlik No 11 haneli olmalıdır !");
            else if (hata == 0)
            {
                int izinTuruID = 0;
                int personelID = 0, bolumID = 0, fakulteID;//PERSONEL ıd geldiğinde bu değişkene atılmalı
                //özel bilgi
                db.updateTable("UPDATE tblOzelNot SET ozelNot='" + ozelBilgi.Text +
                   "' WHERE personelID=" + personelID
                    );
                MessageBox.Show("Düzenlendi");

                //ÖĞRENİM BİLGİLERİ

                /*if (okuryazar.Checked == true)
                    ogrenimDurumID = 1;
                if (lise.Checked == true)
                    ogrenimDurumID = 2;
                if (okuryazar.Checked == true)
                    ogrenimDurumID = 3;
                if (okuryazar.Checked == true)
                    ogrenimDurumID = 4;
                if (okuryazar.Checked == true)
                    ogrenimDurumID = 5;
                if (okuryazar.Checked == true)
                    ogrenimDurumID = 6;*/
                string ogrenimdurumu = "";
                if (okuryazar.Checked) ogrenimdurumu = "Okur yazar";
                else if (ilkokul.Checked) ogrenimdurumu = "İlkokul";
                else if (lise.Checked) ogrenimdurumu = "Lise";
                else if (uni.Checked) ogrenimdurumu = "Üniversite";
                else if (yuksekLisans.Checked) ogrenimdurumu = "Yüksek Lisans";
                else if (doktora.Checked) ogrenimdurumu = "Doktora";
                db.updateTable("UPDATE tblOgrenim SET ilkOkulAdi='" + ilkOkulAdTxt.Text +
                    "',liseAdi='" + liseOkulAdTxt.Text + ",universiteAdi='" + uniOkulAdTxt.Text +
                    "',universiteMezTar=" + uniMezuniyet.Value.ToString().Substring(0, 10) + ",universiteSure=+" +
                    uniSure.SelectedText + ",yuksekLisansAdi='" + yuksekLisansOkulTxt.Text + "',yuksekLisansTar=" +
                  yuksekLisansMezuniyet.Value.ToString().Substring(0, 10) + ",doktoraAdi='" + doktoraOkulAdTxt.Text +
                    "',doktoraTar=" + doktoraMezuniyet.Value.ToString().Substring(0, 10) +
                    "',ogrenimDurum='" + ogrenimdurumu + "'" +
                    " WHERE personelID=" + personelID
                    );
                MessageBox.Show("Düzenlendi");

                int tipID, calismaID, kanGrubuID = 0, cinsiyetID = 0, kurumSicilNo, SSKNo, askerlikDurumID, hastalik = 0, akademikUnvan;
                if (tipCombo1.Text == "Tam Zamanlı")
                    calismaID = 1;
                else
                    calismaID = 2;

                if (tipCombo1.Text == "Akademik")
                    tipID = 1;
                else if (tipCombo1.Text == "İdari")
                    tipID = 2;
                else
                    tipID = 3;
                if (engelDurumuVar.Checked == true)
                    hastalik = 1;
                else
                    hastalik = 0;

                kanGrubuID = personelKanGrubu.SelectedIndex + 1;
                askerlikDurumID = askerlikDurumAd.SelectedIndex + 1;
                cinsiyetID = personelCinsiyet.SelectedIndex + 1;
                kurumSicilNo = int.Parse(kurumSicilNoTxt.Text);
                SSKNo = int.Parse(sskNoTxt.Text);
                akademikUnvan = akademikUnvanTxt.SelectedIndex + 1;
                fakulteID = departmanTxt.SelectedIndex + 1;

                db.updateTable("UPDATE tblPersonelKimlik SET ad=" + "'" + personelAd.Text + "'" +
                    ",soyad=" + "'" + personelSoyad.Text + "'" +
                    ",ikinciAd=" + "'" + personelIkinciAd.Text + "'" +
                    ",kurumSicilNo=" + kurumSicilNo +
                    ",SSKNo=" + SSKNo +
                    ",kanGrubuID=" + kanGrubuID +
                    ",cinsiyetID=" + cinsiyetID +
                    ",askerlikDurumID=" + askerlikDurumID +
                    ",hastalikVarmi=" + hastalik +
                    "WHERE personelID=" + personelID
                    );
                //hastalık alındı ancak varsa ne olduğu eklenmedi
                //tüm idler güncelleme ekranında bir gizli bölümde çekilip tutulmuş olmalı textboxların içinde olabilir.
                db.updateTable("UPDATE tblPersonel SET tipID=" + tipID +
                    ",calismaID=" + calismaID +
                    ",iseBaslamaTarihi=" + "'" + iseBaslamaTarihiGenel.Value.ToString().Substring(0, 10) + "'" +
                    "WHERE personelID=" + personelID
                    );
                db.updateTable("UPDATE tblBolum SET fakulteID=" + fakulteID +
                    ",unvanID=" + akademikUnvan +
                    "WHERE bolumID=" + bolumID
                    );
                MessageBox.Show("Düzenlendi");

                db.updateTable("UPDATE tblNufusBilgileri SET tcKimlikNo=" + int.Parse(nufusTCNo.Text) +
                    ",seri=" + "'" + nufusSeri.Text + "'" +
                    ",seriNo=" + int.Parse(nufusTCNo.Text) +
                    ",ciltNo=" + int.Parse(nufusCiltNo.Text) +
                    ",aileSiraNo=" + int.Parse(nufusAileSiraNo.Text) +
                    ",siraNo=" + int.Parse(nufusSiraNo.Text) +
                    ",babaAdi=" + "'" + nufusBabaAdi.Text + "'" +
                    ",anaAdi=" + "'" + nufusAnneAdi.Text + "'" +
                    ",nufusKayitIl=" + "'" + nufusIL.Text + "'" +
                    ",nufusKayitIlce=" + "'" + nufusILCE.Text + "'" +
                    ",nufusKayitMahKoy=" + "'" + nufusMahKoy.Text + "'" +
                    ",dogumYeri=" + "'" + nufusDogumYeri.Text + "'" +
                    ",dogumTarihi=" + "'" + nufusDogumTarihi.Value.ToString().Substring(0, 10) + "'" +
                    ",verildigiYer=" + "'" + nufusVerildigiYer.Text + "'" +
                    ",verilisNedeni=" + "'" + nufusVerilisNedeni.Text + "'" +
                    ",verilisTarihi=" + "'" + nufusVerilisTarihi.Value.ToString().Substring(0, 10) + "'" +
                    ",kayitNo=" + int.Parse(nufusKayitNo.Text) +
                    ",uyrukID=" + (nufusUyruk.SelectedIndex + 1) +
                    "WHERE personelID=" + personelID
                    );
                db.updateTable("UPDATE tblNufusBilgileri SET ikametgahMah=" + "'" + ikametgahMahTxt.Text + "'" +
                    ",ikametgahSok=" + "'" + ikametgahSokakTxt.Text + "'" +
                    ",ikametgahCad=" + "'" + ikametgahCaddeTxt.Text + "'" +
                    ",ilceID=" + (ikametgahILCE.SelectedIndex + 1) +
                    "WHERE personelID=" + personelID
                    );
                MessageBox.Show("Düzenlendi");

                db.updateTable("UPDATE tblFaaliyet SET medeniHaliID=" + (medeniDurumCombo.SelectedIndex + 1) +
                        ",cocukSayisi=" + (cocukSayisiCombo.SelectedIndex + 1) +
                        ",esininAdi=" + "'" + esAdiTxt.Text + "'" +
                        "WHERE personelID=" + personelID
                        );
                MessageBox.Show("Düzenlendi");

                /*Tüm tablo kontrolleri için kod
                foreach (var item in tabControls.TabPages)
                {
                    TabPage denemeTab = ((TabPage)item);
                    FormController.kontrolTumTablar(denemeTab.Controls);
                }*/

                db.updateTable("UPDATE tblPersonel SET Maas=" + Convert.ToDouble(maasbilgistring) + " WHERE personelID=" + personelID + " ");

                MessageBox.Show("Düzenlendi");

                if (cezaVar.Checked == true)
                {
                    db.updateTable("UPDATE tblCeza SET cezaBilgisi='" + cezaBilgiTxt.Text +
                        "',cezaBaslamaTar=" + cezaBaslangicTxt.Value.ToString().Substring(0, 10) +
                        "cezaBitisTar=" + cezaBitisTxt.Value.ToString().Substring(0, 10) +
                           "WHERE personelID=" + personelID + " "

                        );
                    MessageBox.Show("Düzenlendi");
                }



                if (izinCombo.SelectedIndex == 0)
                    izinTuruID = 1;
                if (izinCombo.SelectedIndex == 1)
                    izinTuruID = 2;
                if (izinCombo.SelectedIndex == 2)
                    izinTuruID = 3;
                db.updateTable("UPDATE TABLE SET izinBaslangic=" + izinBaslama.Value.ToString().Substring(0, 10) +
                    "izinBitis=" + izinBitis.Value.ToString().Substring(0, 10) +
                    "izinTurID=" + izinTuruID +
                    "WHERE personelID=" + personelID + " ");

                //İLETİŞİM BİLGİLERİ

                db.updateTable("UPDATE tblIletisim SET adres='" + adresTxt.Text +
                    "',gsm='" + gsmTelTxt.Text + "',evTel='" + evTelTxt.Text + "',eMail='" + ePostaTxt.Text +
                    "' WHERE personelID=" + personelID + ""
                    );
                MessageBox.Show("Düzenlendi");


                db.updateTable("UPDATE tblIletisim SET adres='" + adresTxt.Text +
                    "',gsm='" + gsmTelTxt.Text + "',evTel='" + evTelTxt.Text + "',eMail='" + ePostaTxt.Text +
                    "' WHERE personelID=" + personelID + ""
                    );
                MessageBox.Show("Düzenlendi");

                int sayac;
                ArrayList liste = db.selectTable("SELECT faaliyetID FROM tblFaaliyet WHERE personelID=" + personelID);
                sayac = 1;
                foreach (var item in liste)
                {
                    db.updateTable("UPDATE tblFaaliyet SET " +
                    "faaliyetAdi='" + tabControls.Controls["faaliyet" + sayac + "Txt"].Text + "',faaliyetTuru='" + tabControls.Controls["tur" + sayac].Text + "',faaliyetTarihi='" + (tabControls.Controls["faaliyet" + sayac] as DateTimePicker).Value.ToShortDateString() +

                    "' WHERE faaliyetID=" + item + ""
                    );
                    sayac++;
                }

                sayac = 1;
                for (int i = 28; i <= 20; i--)
                {
                    db.updateTable("UPDATE tblEvrak SET evrakVarMi=" + ((tabControls.Controls["checkBox" + i] as CheckBox).Checked ? 1 : 0) +
                        " WHERE evrakBilgiID=" + sayac + " AND personelID=" + personelID);
                    sayac++;
                }
                sayac = 1;
                for (int i = 11; i <= 19; i++)
                {
                    db.updateTable("UPDATE tblCikti SET ciktiVarMi=" + ((tabCikti.Controls["checkBox" + i] as CheckBox).Checked ? 1 : 0) +
                        " WHERE ciktiBilgiID=" + sayac + " AND personelID=" + personelID);
                    sayac++;
                }
            }
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

        private void textBox68_KeyPress(object sender, KeyPressEventArgs e)
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

        private void maasBilgisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
                    if (resimAdresi.IndexOf(".jpeg") != -1)
                        uzanti = ".jpeg";
                    else if (resimAdresi.IndexOf(".jpg") != -1)
                        uzanti = ".jpg";
                    else if (resimAdresi.IndexOf(".png") != -1)
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
            { MessageBox.Show("hata:" + msg.Message); }
        }

        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            if ( personelCinsiyet.SelectedIndex == -1)
            {
                ArrayList ad = db.selectTable("SELECT PK.ad,PK.soyad,PK.ikinciAd,C.cinsiyetID,K.kanGrubuID,A.askerlikDurumID "
        + "FROM tblPersonelKimlik PK INNER JOIN tblCinsiyet C ON PK.cinsiyetID= C.cinsiyetID  "
        + "INNER JOIN tblKanGrubu K ON PK.kanGrubuID=K.kanGrubuID "
        + "INNER JOIN tblAskerlikDurum A ON PK.askerlikDurumID=A.askerlikDurumID "
        + "WHERE personelID = " + gelenPersonelID + "");
                if(ad.Count > 0)
                {
                    personelAd.Text = ad[0].ToString();
                    personelSoyad.Text = ad[1].ToString();
                    personelIkinciAd.Text = ad[2].ToString();
                    personelCinsiyet.SelectedIndex = Convert.ToInt32(ad[3]) - 1;
                    personelKanGrubu.SelectedIndex = Convert.ToInt32(ad[4]) - 1;
                    askerlikDurumAd.SelectedIndex = Convert.ToInt32(ad[5]) - 1;
                }
            }

            
        }

      
     


    }
}
