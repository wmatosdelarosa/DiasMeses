using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiasMeses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dia;
            dia = Convert.ToInt32(txtDias.Text);
            if (dia > 0 && dia <= 7)
            {
                if (dia == 1)
                    label1.Text =( "Lunes");
                if (dia == 2)
                    label1.Text = "Martes";
                if (dia == 3)
                    label1.Text = "Miercoles";
                if (dia == 4)
                    label1.Text = "Jueves" ;
                if (dia == 5)
                    label1.Text = "Viernes";
                if (dia == 6)
                    label1.Text = "Sabado";
                if (dia == 7)
                    label1.Text = "Domingo";
            }

            else
            {
                label1.Text = "Incorrecto";
            }

      

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int mes;
            mes = Convert.ToInt32(txtMes.Text);
            if (mes > 0 && mes <= 12)
            {
                if (mes == 1)
                    label1.Text = "Enero";

                if (mes == 2)
                    label1.Text = "Febrero";

                if (mes == 3)
                    label1.Text = "Marzo";
                if (mes == 4)
                    label1.Text = "Abril";
                if (mes == 5)
                    label1.Text = "Mayo";
                if (mes == 6)
                    label1.Text = "Junio";
                if (mes == 7)
                    label1.Text = "Julio";
                if (mes == 8)
                    label1.Text = "Agosto";
                if (mes == 9)
                    label1.Text = "Septiembre";
                if (mes == 10)
                    label1.Text = "Octubre";
                if (mes == 11)
                    label1.Text = "Noviembre";
                if (mes == 12)
                    label1.Text = "Diciembre";
            }

            else
                label1.Text = "INCORRECTO";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    

