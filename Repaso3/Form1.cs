using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso3
{
    public partial class Form1: Form
    {
        List<Propietario> propietarios = new List<Propietario>();
        public Form1()
        {
            InitializeComponent();
        }
        private void mostrar()
        {
            ArchivoPropietario archivoPropietario = new ArchivoPropietario();
            propietarios = archivoPropietario.Leer("../../Propietarios.json");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = propietarios;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Propietario propietario = new Propietario();
            propietario.nombre = textBoxNombre.Text;
            propietario.apellido = textBoxApellido.Text;
            propietario.DPI = textBoxDPI.Text;
            propietarios.Add(propietario);
            ArchivoPropietario archivoPropietario = new ArchivoPropietario();
            archivoPropietario.guardar("../../Propietarios.json", propietarios);
            mostrar();
            textBoxApellido.Text = "";
            textBoxDPI.Text = "";
            textBoxNombre.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Propiedades propiedad = new Propiedades();
            propiedad.Show();
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            ReportePropiedad reportePropiedad = new ReportePropiedad();
            reportePropiedad.Show();    
        }
    }
}
