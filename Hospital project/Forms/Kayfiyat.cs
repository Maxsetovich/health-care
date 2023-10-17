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
    public partial class Kayfiyat : Form
    {
        public Kayfiyat()
        {
            InitializeComponent();
        }

        private void BtnSad_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnSad.Checked)
            {
                BtnSad.BackColor = Color.Red;
            }
            else
            {
                BtnSad.BackColor = SystemColors.Window;
            }
        }

        private void BtnBad_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnBad.Checked) 
            { BtnBad.BackColor = Color.SkyBlue; }
            else { BtnBad.BackColor= SystemColors.Window; }
        }

        private void BtnMidhappy_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnMidhappy.Checked) 
            { BtnMidhappy.BackColor = Color.Green; }
            else { BtnMidhappy.BackColor= SystemColors.Window; }
        }

        private void BtnHappy_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnHappy.Checked)
            { BtnHappy.BackColor = Color.PaleTurquoise; }
            else { BtnHappy.BackColor = SystemColors.Window; }
        }

        private void BtnHappiest_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnHappiest.Checked)
            { BtnHappiest.BackColor = Color.PaleVioletRed; }
            else { BtnHappiest.BackColor = SystemColors.Window; }
        }

        private void BtnYopish_Click(object sender, EventArgs e)
        {
            if (BtnSad.Checked || BtnBad.Checked || BtnMidhappy.Checked || BtnHappy.Checked || BtnHappiest.Checked)
            {
                this.Close();
            }
            else { MessageBox.Show("Kayfiyat holatlaridan bittasini tanlang va saqlash tugmasini bosing!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);  }
        }

        private void BtnSaqlash_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (BtnSad.Checked) { x = 0; MessageBox.Show("Ma'lumotlar saqlandi!!!", "Saqlandi!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else if (BtnBad.Checked) { x = 25; MessageBox.Show("Ma'lumotlar saqlandi!!!", "Saqlandi!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else if (BtnMidhappy.Checked) { x = 50; MessageBox.Show("Ma'lumotlar saqlandi!!!", "Saqlandi!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else if (BtnHappy.Checked) { x = 75; MessageBox.Show("Ma'lumotlar saqlandi!!!", "Saqlandi!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else if (BtnHappiest.Checked) { x = 100; MessageBox.Show("Ma'lumotlar saqlandi!!!", "Saqlandi!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else { MessageBox.Show("Kayfiyat holatlaridan bittasini tanlang", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);  }
            string jsonFilePath = "Files/Kayfiyati.json";
            File.WriteAllText(jsonFilePath, x.ToString());
            BtnSaqlash.FillColor = Color.DodgerBlue;

        }
    }
}
