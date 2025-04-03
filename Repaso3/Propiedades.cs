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
    public partial class Propiedades: Form
    {
        List<Propiedad> propiedades = new List<Propiedad>();
        public Propiedades()
        {
            InitializeComponent();
        }
        private void mostrar()
        {
            ArchivoPropiedad archivoPropiedad = new ArchivoPropiedad();
            propiedades = archivoPropiedad.Leer("../../Propiedades.json");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = propiedades;
            dataGridView1.Refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Propiedades_Load(object sender, EventArgs e)
        {
            mostrar();
            List<Propietario> propietarios = new List<Propietario>();
            ArchivoPropietario archivoPropietario = new ArchivoPropietario();
            propietarios = archivoPropietario.Leer("../../Propietarios.json");
            comboBoxDPI.DisplayMember = "NombreCompleto";
            comboBoxDPI.ValueMember = "DPI";
            comboBoxDPI.DataSource = propietarios;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Propiedad propiedad = new Propiedad();
            propiedad.NumCasa = Convert.ToInt16(textBoxCasa.Text);
            propiedad.DPI = comboBoxDPI.SelectedValue.ToString();
            propiedad.Cuota = Convert.ToDecimal(textBoxCuota.Text);
            propiedades.Add(propiedad);
            ArchivoPropiedad archivoPropiedad = new ArchivoPropiedad();
            archivoPropiedad.guardar("../../Propiedades.json", propiedades);
            mostrar();
            textBoxCasa.Text = "";
            textBoxCuota.Text = "";
            comboBoxDPI.SelectedValue = "";

        }
    }
}
