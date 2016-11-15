using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelOtomasyonSistemi
{
    internal static class FormController
    {
        internal static int kontrolTumTablar(Control.ControlCollection controls, ListBox listbx)
        {
            int bosSay = 0;
            foreach (var item in controls)
            {
                //şuan tabın içindeki kontollleri yani 2 tane group box nesnesi var itemde
                //itemin içine girince groupboxın içine girmiş oluyoruz type cast yapıyoruz yanlz sagdakinde bos yerler wardı hala uyarmadı
                if (item is GroupBox)
                {
                    GroupBox asd = ((GroupBox)item);
                    foreach (var item2 in asd.Controls)
                    {
                        if (item2 is TextBox)
                        {
                            if (charactercontrol(((TextBox)item2).Text))
                            {
                                listbx.Items.Add(((TextBox)item2).Name + " Geçersiz Karakter Var\n");
                                bosSay++;
                            }
                            if (((TextBox)item2).Text == "")
                            {
                                listbx.Items.Add(((TextBox)item2).Name + " Boş Bırakıldı\n");
                                bosSay++;
                            }
                        }
                        if (item2 is ComboBox)
                        {
                            if (charactercontrol(((ComboBox)item2).Text))
                            {
                                listbx.Items.Add(((ComboBox)item2).Name + " Geçersiz Karakter Var\n");
                                bosSay++;
                            }
                            if (((ComboBox)item2).Text == "")
                            {
                                listbx.Items.Add(((ComboBox)item2).Name + " Boş Bırakıldı\n");
                                bosSay++;
                            }
                        }
                    }
                }
                else if (item is TextBox)
                {
                    if (charactercontrol(((TextBox)item).Text))
                    {
                        listbx.Items.Add(((TextBox)item).Name + " Geçersiz Karakter Var\n");
                        bosSay++;
                    }
                    if (((TextBox)item).Text == "")
                    {
                        listbx.Items.Add(((TextBox)item).Name + " Boş Bırakıldı\n");
                        bosSay++;
                    }
                }
                else if (item is ComboBox)
                {
                    if (charactercontrol(((ComboBox)item).Text))
                    {
                        listbx.Items.Add(((ComboBox)item).Name + " Geçersiz Karakter Var\n");
                        bosSay++;
                    }
                    if (((ComboBox)item).Text == "")
                    {
                        listbx.Items.Add(((ComboBox)item).Name + " Boş Bırakıldı\n");
                        bosSay++;
                    }
                }
            }
            return bosSay;
        }
        public static bool charactercontrol(string text)
        {
            return Regex.IsMatch(text, @"[^A-Za-zÖÇŞĞÜİıöçşğü0-9\s]");
        }
    }
}
