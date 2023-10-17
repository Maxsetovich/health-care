using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_project.Forms
{
    public partial class Qabul_qilingan_dorilari : Form
    {
        public Qabul_qilingan_dorilari()
        {
            InitializeComponent();
        }

        private void BtnSaqlash_Click(object sender, EventArgs e)
        {
            if (tb1.Text != "" && tb2.Text != "" && tb3.Text != "") 
            { 
                MessageBox.Show("Ma'lumotlar saqlandi!!!", "Saqlandi!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else { MessageBox.Show("Ma'lumotlarni to'ldiring", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsSymbol(e.KeyChar);
        }

        private void tb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar) || char.IsLetter(e.KeyChar);
        }

        private void tb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar) || char.IsLetter(e.KeyChar);
        }

        private void BtnYopish_Click(object sender, EventArgs e)
        {
            if (tb1.Text != string.Empty && tb2.Text != string.Empty && tb3.Text != string.Empty)
            {
                this.Close();
            }
            else { MessageBox.Show("Ma'lumotlarini kiriting va saqlash tugmasini bosing!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
