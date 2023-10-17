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
    public partial class Ovqatlar : Form
    {
        public Ovqatlar()
        {
            InitializeComponent();
        }

        private void BtnYopish_Click(object sender, EventArgs e)
        {
            if (chb1.Checked || chb2.Checked || chb3.Checked || chb4.Checked || chb5.Checked || chb6.Checked || chb7.Checked || chb8.Checked || chb9.Checked || chb10.Checked || chb11.Checked || chb12.Checked)
            {
                this.Close();
            }
            else { MessageBox.Show("Ovqatlarni tanlang va saqlash tugmasini bosing!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void BtnSaqlash_Click(object sender, EventArgs e)
        {
            BtnSaqlash.FillColor = Color.DodgerBlue;
            MessageBox.Show("Ma'lumotlar saqlandi!!!", "Saqlandi!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
