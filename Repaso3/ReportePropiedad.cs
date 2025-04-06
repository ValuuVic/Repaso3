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
    public partial class ReportePropiedad: Form
    {
        List<Propiedad> propiedades = new List<Propiedad>();
        List<Propietario> propietarios = new List<Propietario>();
        List<Reporte> reportes = new List<Reporte>();
        public ReportePropiedad()
        {
            InitializeComponent();
        }
        private void cargarPropiedad()
        {
            ArchivoPropiedad propiedad = new ArchivoPropiedad();
            propiedades = propiedad.Leer("../../Propiedades.json");
        }
        private void CargarPropietario()
        {
            ArchivoPropietario archivoPropietario = new ArchivoPropietario();
            propietarios = archivoPropietario.Leer("../../Propietarios.json");
        }
        private void crearReporte()
        {
            reportes.Clear();
            foreach (var propietario in propietarios)
            {
                foreach (var propiedad in propiedades)
                {
                    if (propietario.DPI == propiedad.DPI)
                    {
                        Reporte reporte = new Reporte();
                        reporte.nombre = propietario.nombre;
                        reporte.apellido = propietario.apellido;
                        reporte.numCasa = propiedad.NumCasa;
                        reporte.cuota = propiedad.Cuota;
                        reportes.Add(reporte);
                    }
                }
            }
        }
        private void PropietarioMasDebe()
        {
            // crearReporte();
            Reporte mayor = reportes.OrderByDescending(a => a.cuota).First();
            label3.Text = mayor.nombre + ", " + mayor.apellido + " debe: " + mayor.cuota;
            label2.Visible = true;

        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crearReporte();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reportes;
            dataGridView1.Refresh();
            PropietarioMasDebe();
        }

        private void ReportePropiedad_Load(object sender, EventArgs e)
        {
            cargarPropiedad();
            CargarPropietario();
            label2.Visible = false;
            label3.Text = "";
        }

        private void buttonMayMen_Click(object sender, EventArgs e)
        {
            crearReporte();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reportes.OrderByDescending(a => a.cuota).ToList();
            dataGridView1.Refresh();
            PropietarioMasDebe();
        }

        private void buttonMenMay_Click(object sender, EventArgs e)
        {
            crearReporte();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reportes.OrderBy(a => a.cuota).ToList();
            dataGridView1.Refresh();
            PropietarioMasDebe();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            crearReporte();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reportes.OrderByDescending(a => a.cuota).Take(3).ToList();
            dataGridView1.Refresh();
            PropietarioMasDebe();
        }

        private void buttonBajas_Click(object sender, EventArgs e)
        {
            crearReporte();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reportes.OrderBy(a => a.cuota).Take(3).ToList();
            dataGridView1.Refresh();
            PropietarioMasDebe();
        }
    }
}
