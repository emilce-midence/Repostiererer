using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emilce_Midence___IParcial_Examen
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Listarbutton1_Click(object sender, EventArgs e)
        {
            int desde = Convert.ToInt32(DesdenumericUpDown1.Value);
            int hasta = Convert.ToInt32(HastanumericUpDown2.Value);
            int multiplo = Convert.ToInt32(MultiplotextBox1.Text);
            for (int i = desde; i <= hasta; i++)
            {
                if (i % multiplo == 0)
                {
                    ListalistBox1.Items.Add(i);
                }
            }
        }
    }
}
