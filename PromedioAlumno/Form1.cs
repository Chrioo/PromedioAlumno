using PromedioAlumno.Entidades;
using PromedioAlumno.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioAlumno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Materia;

            ClsAlumno datos = new ClsAlumno();
            Materia = txtMateria.Text;
            datos.Nombre = txtNombre.Text;
            datos.Apellido = txtApellido.Text;
            datos.Lab1 = double.Parse( txtLaboratorio1.Text);
            datos.Lab2 = double.Parse(txtLaboratorio2.Text);
            datos.Lab3 = double.Parse(txtLaboratorio3.Text);
            datos.Parcial1 = double.Parse(txtParcial1.Text);
            datos.Parcial2 = double.Parse(txtParcial2.Text);
            datos.Parcial3 = double.Parse(txtParcial3.Text);
            NClsDatos logic = new NClsDatos();
            MessageBox.Show("Notas de la Asignatura de: "+Materia+logic.Calculo(datos));

        }
    }
    }

