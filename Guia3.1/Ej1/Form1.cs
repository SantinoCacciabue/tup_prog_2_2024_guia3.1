using Ej1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void bCalcular_Click(object sender, EventArgs e)
        {
            string marca = (tBmarca.Text);
            int modelo = Convert.ToInt32(nModelo.Text);
            int valor = Convert.ToInt32(tBvalor.Text);
            int añoACalcular = Convert.ToInt32(nAñoACalcular.Text);
            Moto vehiculo = new Moto(marca, modelo, valor);
            Evaluador evaluador = null;
            if(rBlineal.Checked == true)
            {
                int vidaUtil = Convert.ToInt32(tBvidaUtil.Text);
                evaluador = new EvaluadorLineal(vehiculo, añoACalcular, vidaUtil);
            }
            else if (rBanual.Checked == true)
            {
                double tasa = Convert.ToDouble(tbTasa.Text);
                evaluador = new EvaluadorAnual(vehiculo,añoACalcular,tasa);
            }
            if(evaluador != null)
            {
                Datos datos = new Datos();
                datos.lBresultados.Items.Add(evaluador.VerDescripcion());
                datos.ShowDialog();

            }
        }
        private void rbLineal_CheckedChanged(object sender, EventArgs e)
        {
            tbTasa.Enabled = rBanual.Checked;
            tbTasa.Enabled = rBlineal.Checked;
        }
    }
}
