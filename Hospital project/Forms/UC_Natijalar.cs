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
    public partial class UC_Natijalar : UserControl
    {
        public UC_Natijalar()
        {
            InitializeComponent();
            string jsonFilePath = "Files/UmumiyAhvoli.json";
            int x1 = int.Parse(File.ReadAllText(jsonFilePath));
            GraphUA.Series["Umumiy ahvoli"].Points.AddXY(1, x1);

            string jsonFilePath2 = "Files/Kayfiyati.json";
            int y1 = int.Parse(File.ReadAllText(jsonFilePath2));
            GraphUA.Series["Kayfiyati"].Points.AddXY(2, y1);

            string jsonFilePath3 = "Files/JismoniyFaollik.json";
            int x2 = int.Parse(File.ReadAllText(jsonFilePath3));
            GraphJfU.Series["Jismoniy faollik"].Points.AddXY(1, x2);

            string jsonFilePath4 = "Files/Uyqusi.json";
            int y2 = int.Parse(File.ReadAllText(jsonFilePath4));
            GraphJfU.Series["Uyqusi"].Points.AddXY(2, y2);

            string jsonFilePath5 = "Files/ErtalabkiQonBosim.json";
            string[] bloodPressureMorning = (File.ReadAllText(jsonFilePath5)).Split(' ');
            GraphQBE.Series["Sistolik"].Points.AddXY(1, bloodPressureMorning[0]);
            GraphQBE.Series["Diastolik"].Points.AddXY(2, bloodPressureMorning[1]);

            string jsonFilePath6 = "Files/KechkiQonBosim.json";
            string[] bloodPressureNight = (File.ReadAllText(jsonFilePath6)).Split(' ');
            GraphQBK.Series["Sistolik"].Points.AddXY(1, bloodPressureNight[0]);
            GraphQBK.Series["Diastolik"].Points.AddXY(2, bloodPressureNight[1]);

        }
    }
}
