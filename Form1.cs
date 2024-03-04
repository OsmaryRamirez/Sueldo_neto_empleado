using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sueldo_neto_de_un_empleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_pago.Clear();
            txt_horas.Clear();
            txt_bruto.Clear();
            txt_afp.Clear();
            txt_sfs.Clear();
            txt_total.Clear();
            txt_neto.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double pago, horas, bruto, afp, sfs, total, neto;

            pago = Convert.ToDouble(txt_pago.Text);
            horas = Convert.ToDouble(txt_horas.Text);
            

             bruto= pago *horas;
            afp = bruto * 0.0287; // 2.87%
            sfs = bruto * 0.0304; // 3.04%
            total = afp + sfs;
            neto = bruto - total;

            txt_bruto.Text = bruto.ToString();
            txt_neto.Text = neto.ToString();
            txt_total.Text = total.ToString();  
            txt_afp.Text = afp.ToString();
            txt_sfs.Text = sfs.ToString();
            
             
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
