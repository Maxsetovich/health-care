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
    public partial class Izohlar : Form
    {
        public Izohlar()
        {
            InitializeComponent();
        }

        private void BtnYopish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSaqlash_Click(object sender, EventArgs e)
        {
            BtnSaqlash.FillColor = Color.DodgerBlue;
            MessageBox.Show("Ma'lumotlar saqlandi!!!", "Saqlandi!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
