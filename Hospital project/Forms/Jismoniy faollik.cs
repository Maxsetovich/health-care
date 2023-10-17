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
    public partial class Jismoniy_faollik : Form
    {
        public Jismoniy_faollik()
        {
            InitializeComponent();
        }

        private void BtnYopish_Click(object sender, EventArgs e)
        {
            if (RB1.Checked || RB2.Checked || RB3.Checked || RB4.Checked || RB5.Checked)
            {
                this.Close();
            }
            else { MessageBox.Show("Jismoniy faollik holatlaridan bittasini tanlang va saqlash tugmasini bosing!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BtnSaqlash_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (RB1.Checked) { x = 0; MessageBox.Show("Ma'lumotlar saqlandi!!!", "Saqlandi!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else if (RB2.Checked) { x = 25; MessageBox.Show("Ma'lumotlar saqlandi!!!", "Saqlandi!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else if (RB3.Checked) { x = 50; MessageBox.Show("Ma'lumotlar saqlandi!!!", "Saqlandi!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else if (RB4.Checked) { x = 75; MessageBox.Show("Ma'lumotlar saqlandi!!!", "Saqlandi!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else if (RB5.Checked) { x = 100; MessageBox.Show("Ma'lumotlar saqlandi!!!", "Saqlandi!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else { MessageBox.Show("Jismoniy faollik holatlaridan bittasini tanlang", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            string jsonFilePath = "Files/JismoniyFaollik.json";
            File.WriteAllText(jsonFilePath, x.ToString());
            BtnSaqlash.FillColor = Color.DodgerBlue;
        }
    }
}
