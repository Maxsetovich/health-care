using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_project.Forms
{
    public partial class UmumiyAhvoli : Form
    {
        public UmumiyAhvoli()
        {
            InitializeComponent();
        }

        private void TbUmumiyAhvoli_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar) || char.IsLetter(e.KeyChar);
        }

        private void BtnSaqlashUA_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(TbUmumiyAhvoli.Text);
                if (a < 1 || a > 101)
                {
                    TbUmumiyAhvoli.Text = string.Empty;
                    MessageBox.Show("1 dan 100 gacha son kiriting!!!");
                }
                else
                {
                    BtnSaqlashUA.FillColor = Color.DodgerBlue;
                    string jsonFilePath = "Files/UmumiyAhvoli.json";
                    File.WriteAllText(jsonFilePath, a.ToString());
                    MessageBox.Show("Ma'lumotlar saqlandi!!!", "Saqlandi!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
            }
            catch 
            {
                TbUmumiyAhvoli.Text = string.Empty;
                MessageBox.Show("1 dan 100 gacha son kiriting!!!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnYopishUA_Click(object sender, EventArgs e)
        {
            if (TbUmumiyAhvoli.Text != string.Empty)
            {
                this.Close();
            }
            else { MessageBox.Show("Ma'lumotlarini kiriting va saqlash tugmasini bosing!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void TbUmumiyAhvoli_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
