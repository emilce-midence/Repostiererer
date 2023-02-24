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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        double Cantidad, Precio, Categoria, Subtotal, Descuento, ITBIS, Total;

        private void Procesarbutton1_Click(object sender, EventArgs e)
        {
            SALIDA();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void Nuevobutton2_Click(object sender, EventArgs e)
        {
            NUEVO();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SubtotaltextBox1.Enabled = false;
            DescuentotextBox2.Enabled = false;
            ImpuestotextBox3.Enabled = false;
            TotaltextBox4.Enabled = false;
        }

        private void Salirbutton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ENTRADAS()
        {
            Cantidad = Convert.ToDouble(CantidadtextBox1.Text);
            Precio = Convert.ToDouble(PreciotextBox2.Text);
            Categoria = Convert.ToDouble(CategoriatextBox3.Text);
        }

        private void SALIDA()
        {
            if (Categoria == 1)
            {
                Subtotal = Cantidad * Precio;
                ITBIS = Subtotal * 0.18;
                Descuento = Subtotal * 0.20;
                Total = (Subtotal + ITBIS) - Descuento;
                SubtotaltextBox1.Text = Convert.ToString(Subtotal);
                ImpuestotextBox3.Text = Convert.ToString(ITBIS);
                DescuentotextBox2.Text = Convert.ToString(Descuento);
                TotaltextBox4.Text = Convert.ToString(Total);
            }
            else
                if (Categoria == 2)
            {
                Subtotal = Cantidad * Precio;
                ITBIS = Subtotal * 0.18;
                Descuento = Subtotal * 0.15;
                Total = (Subtotal + ITBIS) - Descuento;
                SubtotaltextBox1.Text = Convert.ToString(Subtotal);
                ImpuestotextBox3.Text = Convert.ToString(ITBIS);
                DescuentotextBox2.Text = Convert.ToString(Descuento);
                TotaltextBox4.Text = Convert.ToString(Total);
            }
            else
                if (Categoria == 3)
            {
                Subtotal = Cantidad * Precio;
                ITBIS = Subtotal * 0.18;
                Descuento = Subtotal * 0.10;
                Total = (Subtotal + ITBIS) - Descuento;
                SubtotaltextBox1.Text = Convert.ToString(Subtotal);
                ImpuestotextBox3.Text = Convert.ToString(ITBIS);
                DescuentotextBox2.Text = Convert.ToString(Descuento);
                TotaltextBox4.Text = Convert.ToString(Total);
            }
            else
                if (Categoria == 4)
            {
                Subtotal = Cantidad * Precio;
                ITBIS = Subtotal * 0.18;
                Descuento = Subtotal * 0.05;
                Total = (Subtotal + ITBIS) - Descuento;
                SubtotaltextBox1.Text = Convert.ToString(Subtotal);
                ImpuestotextBox3.Text = Convert.ToString(ITBIS);
                DescuentotextBox2.Text = Convert.ToString(Descuento);
                TotaltextBox4.Text = Convert.ToString(Total);
            }
        }

        private void NUEVO()
        {
            CantidadtextBox1.Text = "0";
            PreciotextBox2.Text = "0";
            CategoriatextBox3.Text = "0";
            TotaltextBox4.Text = "0";
            DescuentotextBox2.Text = "0";
            ImpuestotextBox3.Text = "0";
            SubtotaltextBox1.Text = "0";
        }
    }
}
