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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcularbutton1_Click(object sender, EventArgs e)
        {
            double ValorPresente, TasaInteres, Periodos, MontoTotal, Intereses;
            int Tiempo;

            ValorPresente = Convert.ToDouble(CapitaltextBox1.Text);
            TasaInteres = Convert.ToDouble(TasatextBox2.Text);
            TasaInteres = TasaInteres / 100;
            Periodos = Convert.ToDouble(PeriodotextBox3.Text);

            MontoTotal = ValorPresente * Math.Pow((1 + TasaInteres), Periodos);
            MontotextBox4.Text = Convert.ToString(MontoTotal);

            Tiempo = 1;

            while (Tiempo <= Periodos)
            {
                Intereses = ValorPresente * TasaInteres;
                ValorPresente = ValorPresente + Intereses;

                listBox1.Items.Add(Convert.ToString(Tiempo) + "     " + Convert.ToString(ValorPresente) + "     " + Convert.ToString(Intereses));
                Tiempo = Tiempo + 1;
            }
        }

        private void Nuevobutton2_Click(object sender, EventArgs e)
        {
            CapitaltextBox1.Clear();
            TasatextBox2.Clear();
            PeriodotextBox3.Clear();
            MontotextBox4.Clear();
            CapitaltextBox1.Focus();
            listBox1.ClearSelected();
        }

        private void Salirbutton3_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnMenssage_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
