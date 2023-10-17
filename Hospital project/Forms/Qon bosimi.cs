using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_project.Forms
{
    public partial class Qon_bosimi : Form
    {
        public Qon_bosimi()
        {
            InitializeComponent();
        }

        private void BtYopish_Click(object sender, EventArgs e)
        {
            if (TbES.Text != string.Empty && TbED.Text != string.Empty && TbKS.Text != string.Empty && TbKD.Text != string.Empty)
            {
                this.Close();
            }
            else { MessageBox.Show("Qon bosimi ma'lumotlarini kiriting va saqlash tugmasini bosing!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void BtSaqlash_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = int.Parse(TbES.Text);
                int x2 = int.Parse(TbED.Text);
                int y1 = int.Parse(TbKS.Text);
                int y2 = int.Parse(TbKD.Text);

                if (x1 < 0 || x1 > 301)
                {
                    TbES.Text = string.Empty;
                    TbED.Text = string.Empty;
                    TbKS.Text = string.Empty;
                    TbKD.Text = string.Empty;
                    MessageBox.Show("Qon bosimi ma'lumotlarini to'g'ri tartibda kiriting!!!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string jsonFilePath1 = "Files/ErtalabkiQonBosim.json";
                    File.WriteAllText(jsonFilePath1, x1+" "+x2);

                    string jsonFilePath2 = "Files/KechkiQonBosim.json";
                    File.WriteAllText(jsonFilePath2, y1 + " " + y2);
                    BtSaqlash.FillColor = Color.DodgerBlue;
                    MessageBox.Show("Ma'lumotlar saqlandi!!!", "Saqlandi!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
                TbES.Text = string.Empty;
                TbED.Text = string.Empty;
                TbKS.Text = string.Empty;
                TbKD.Text = string.Empty;
                MessageBox.Show("Qon bosimi ma'lumotlarini to'g'ri tartibda kiriting!!!!!!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbES_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar) || char.IsLetter(e.KeyChar);
        }

        private void TbED_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar) || char.IsLetter(e.KeyChar);
        }

        private void TbKS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar) || char.IsLetter(e.KeyChar);
        }

        private void TbKD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar) || char.IsLetter(e.KeyChar);
        }
    }
}
