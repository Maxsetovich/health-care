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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            UC_Asosiy uC_Asosiy = new UC_Asosiy();
            addUserControl(uC_Asosiy);
        }

        private void BtnMenu1_Click(object sender, EventArgs e)
        {
            BtnAsosiy.Checked = true;
            BtnAsosiy_Click(sender, e);
            UmumiyAhvoli umumiyAhvoli = new UmumiyAhvoli();
            umumiyAhvoli.Show();
        }

        private void BtnMenu2_Click(object sender, EventArgs e)
        {
            BtnAsosiy.Checked = true;
            BtnAsosiy_Click(sender, e);
            Ovqatlar ovqatlar = new Ovqatlar();
            ovqatlar.Show();
        }


        private void BtnMenu3_Click(object sender, EventArgs e)
        {
            BtnAsosiy.Checked = true;
            BtnAsosiy_Click(sender, e);
            Kayfiyat kayfiyat = new Kayfiyat();
            kayfiyat.Show();
        }

        private void BtnMenu4_Click(object sender, EventArgs e)
        {
            BtnAsosiy.Checked = true;
            BtnAsosiy_Click(sender, e);
            Jismoniy_faollik jismoniy_Faollik = new Jismoniy_faollik();
            jismoniy_Faollik.Show();
        }

        private void BtnMenu7_Click(object sender, EventArgs e)
        {
            BtnAsosiy.Checked = true;
            BtnAsosiy_Click(sender, e);
            Uyqusi uyqusi = new Uyqusi();
            uyqusi.Show();
        }

        private void BtnMenu9_Click(object sender, EventArgs e)
        {
            BtnAsosiy.Checked = true;
            BtnAsosiy_Click(sender, e);
            Simptomlar simptomlar = new Simptomlar();
            simptomlar.Show();
        }

        private void BtnMenu6_Click(object sender, EventArgs e)
        {
            BtnAsosiy.Checked = true;
            BtnAsosiy_Click(sender, e);
            Qon_bosimi qon_Bosimi = new Qon_bosimi();
            qon_Bosimi.Show();
        }

        private void BtnMenu8_Click(object sender, EventArgs e)
        {
            BtnAsosiy.Checked = true;
            BtnAsosiy_Click(sender, e);
            Izohlar izohlar = new Izohlar();
            izohlar.Show();
        }

        private void BtnMenu5_Click(object sender, EventArgs e)
        {
            BtnAsosiy.Checked = true;
            BtnAsosiy_Click(sender, e);
            Qabul_qilingan_dorilari qabul_Qilingan_Dorilari = new Qabul_qilingan_dorilari();
            qabul_Qilingan_Dorilari.Show();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void BtnAsosiy_Click(object sender, EventArgs e)
        {
            UC_Asosiy uC_Asosiy = new UC_Asosiy();
            addUserControl(uC_Asosiy);
        }

        private void BtnNatijalar_Click(object sender, EventArgs e)
        {
            UC_Natijalar uC_Natijalar = new UC_Natijalar();
            addUserControl(uC_Natijalar);
        }

        private void BtnProfil_Click(object sender, EventArgs e)
        {
            UC_Profil uC_Profil = new UC_Profil();
            addUserControl(uC_Profil);
        }

        private void PnlExitMenuForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
