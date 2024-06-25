using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chBxBebidas_CheckedChanged(object sender, EventArgs e)
        {
            if(chBxBebidas.Checked)
            {
                grBxBebidas.Visible = true;
                grBxPlatoFuerte.Visible = false;
                grBxEntradas.Visible = false;
                grBxPostres.Visible = false;
            }
            else
            {
                grBxBebidas.Visible = false;
            }
        }

        private void chBxPlatoFuerte_CheckedChanged(object sender, EventArgs e)
        {
            if(chBxPlatoFuerte.Checked)
            {
                grBxPlatoFuerte.Visible = true;
                grBxBebidas.Visible = false;
                grBxEntradas.Visible = false;
                grBxPostres.Visible = false;
            }
            else
            {
                grBxPlatoFuerte.Visible = false;
            }
        }

        private void chBxEntradas_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxEntradas.Checked)
            {
                grBxEntradas.Visible = true;
                grBxBebidas.Visible = false;
                grBxPlatoFuerte.Visible = false;
                grBxPostres.Visible = false;
            }
            else
            {
                grBxEntradas.Visible = false;
            }
        }

        private void chBxPostres_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxPostres.Checked)
            {
                grBxPostres.Visible = true;
                grBxBebidas.Visible = false;
                grBxPlatoFuerte.Visible = false;
                grBxEntradas.Visible = false;
            }
            else
            {
                grBxPostres.Visible = false;
            }
        }

        private void chBxCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chBxPizza_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txChicha_Click(object sender, EventArgs e)
        {

        }

        private void txPerro_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txTortadechocolate_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int precioTotalCoca = 0;
            // Insertando valor de la cocacola
            {
                var selectedValue = coBxCocaCola.Text;
                int cocaCount = 0;
                if (selectedValue != "")
                {
                    cocaCount = Convert.ToInt32(selectedValue.ToString());
                }

                int cocaPrecioUnitario = 5_000;

                if (cocaCount > 0)
                {
                    cocacolaLabel.Text = "Coca Cola";
                    cocacolaPrecio.Text = "$" + cocaPrecioUnitario.ToString();
                    cocacolaUnidades.Text = cocaCount.ToString();

                    precioTotalCoca = cocaCount * cocaPrecioUnitario;
                }
            }

            int precioTotalAgua = 0;
            {
                var selectedValue = coBxAgua.Text;
                int aguaCount = 0;
                if (selectedValue != "")
                {
                    aguaCount = Convert.ToInt32(selectedValue.ToString());
                }

                int aguaPrecioUnitario = 5_000;

                if (aguaCount > 0)
                {
                    aguaLabel.Text = "Agua";
                    aguaPrecio.Text = "$" + aguaPrecioUnitario.ToString();
                    aguaUnidades.Text = aguaCount.ToString();

                    precioTotalAgua = aguaCount * aguaPrecioUnitario;
                }
            }

            int precioTotalChica = 0;

            {
                var selectedValue = coBxChicha.Text;
                int chicaCount = 0;
                if (selectedValue != "") 
                {
                    chicaCount = Convert.ToInt32(selectedValue.ToString());
                }

                int chichaPrecioUnitario = 12_000;

                if (chicaCount > 0)
                {
                    chichaLabel.Text = "Chicha M.";
                    chichaPrecio.Text = "$" + chichaPrecioUnitario.ToString();
                    chichaUnidades.Text = chicaCount.ToString();

                    precioTotalChica = chicaCount * chichaPrecioUnitario;

                }

            }

            int precioTotalPizza = 0;

            {
                var selectedValue = coBxPizza.Text;
                int pizzaCount = 0;
                if (selectedValue != "")
                {
                    pizzaCount = Convert.ToInt32(selectedValue.ToString());
                }

                int pizzaPrecioUnitario = 15_000;

                if (pizzaCount > 0)
                {
                    pizzaLabel.Text = "Pizza";
                    pizzaPrecio.Text = "$" + pizzaPrecioUnitario.ToString();
                    pizzaUnidades.Text = pizzaCount.ToString();

                    precioTotalPizza = pizzaCount * pizzaPrecioUnitario;

                }
            }

            int precioTotalPerrocaliente = 0;


            {
                var selectedValue = coBxPerrocaliente.Text;
                int perrocalienteCount = 0;
                if ( selectedValue != "")
                {
                    perrocalienteCount = Convert.ToInt32(selectedValue.ToString());

                }

                int perroCalientePrecioUnitario = 10_000;

                if (perrocalienteCount > 0)
                {
                    perrocalienteLabel.Text = "Perro Caliente";
                    perrocalientePrecio.Text = "$" + perroCalientePrecioUnitario.ToString();
                    perrocalienteUnidades.Text = perrocalienteCount.ToString();

                    precioTotalPerrocaliente = perrocalienteCount * perroCalientePrecioUnitario;
                }
            }
           
            int precioTotalSalchipapa = 0;

            {
                var selectedValue = coBxSalchipapas.Text;
                int salchipapaCount = 0;
                if ( selectedValue != "")
                {
                    salchipapaCount = Convert.ToInt32(selectedValue.ToString());
                }

                int salchipapaPrecioUnitario = 20_000;
                if (salchipapaCount > 0)
                {
                    salchipapaLabel.Text = "Salchipapas";
                    salchipapaPrecio.Text = "$" + salchipapaPrecioUnitario.ToString();
                    salchipapaUnidades.Text = salchipapaCount.ToString();

                    precioTotalSalchipapa = salchipapaCount *   salchipapaPrecioUnitario;
                }

            }

            int precioTotalEmpanada = 0;

            {
                var selectedValue = coBxEmpanada.Text;
                int empanadaCount = 0;
                if ( selectedValue != "")
                {
                    empanadaCount = Convert.ToInt32(selectedValue.ToString());
                }

                int empanadaPrecioUnitario = 10_000;

                if (empanadaCount > 0)
                {
                    empanadaLabel.Text = "Empanadas";
                    empanadaPrecio.Text = "$" + empanadaPrecioUnitario.ToString();
                    empanadaUnidades.Text = empanadaCount.ToString();

                    precioTotalEmpanada = empanadaCount * empanadaPrecioUnitario;

                }

            }

            int precioTotalTeque = 0;

            {
                var selectedValue = coBxteque.Text;
                int tequeCount = 0;
                if ( selectedValue != "")
                {
                    tequeCount = Convert.ToInt32(selectedValue.ToString());
                }

                int tequePrecioUnitario = 15_000;

                if ( tequeCount > 0)
                {
                    tequeLabel.Text = "Tequeños";
                    tequePrecio.Text = "$" + tequePrecioUnitario.ToString();
                    tequeUnidades.Text = tequeCount.ToString();

                    precioTotalTeque = tequeCount * tequePrecioUnitario;
                }

            }

            int precioTotalTresleche = 0;

            {
                var seletedValue = coBxTresleche.Text;
                int TreslecheCount = 0;
                if ( seletedValue != "")
                {
                    TreslecheCount = Convert.ToInt32(seletedValue.ToString());
                }

                int treslechePrecioUnitario = 12_000;

                if ( TreslecheCount > 0)
                {
                    treslecheLabel.Text = "Tres Leche";
                    treslechePrecio.Text = "$" + treslechePrecioUnitario.ToString();
                    treslecheUnidades.Text = TreslecheCount.ToString();

                    precioTotalTresleche = TreslecheCount * treslechePrecioUnitario;
                }
            }
            
            int precioTotalTortadechocolate = 0;

            {
                var selectdValue = coBxTortadechocolate.Text;
                int tortadechocolateCount = 0;
                if ( selectdValue != "")
                {
                    tortadechocolateCount = Convert.ToInt32(selectdValue.ToString());
                }

                int tortadechocolatePrecioUnitario = 15_000;

                if ( tortadechocolateCount > 0)
                {
                    tortadechocolateLabel.Text = "Torta de Chocolate";
                    tortadechocolatePrecio.Text = "$" + tortadechocolatePrecioUnitario.ToString();
                    tortadechocolateUnidades.Text = tortadechocolateCount.ToString();

                    precioTotalTortadechocolate = tortadechocolateCount + tortadechocolatePrecioUnitario;
                }
            }



            int valorSubTotal = precioTotalCoca + precioTotalAgua + precioTotalChica + precioTotalPizza + precioTotalPerrocaliente + precioTotalSalchipapa + precioTotalEmpanada + precioTotalTeque + precioTotalTresleche + precioTotalTortadechocolate;
            subtotal.Text = "$" + valorSubTotal.ToString();

        }

        private void grBxBebidas_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void coBxCocaCola_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aguaLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }

}