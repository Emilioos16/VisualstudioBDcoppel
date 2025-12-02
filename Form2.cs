using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coppel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cOPPELDataSet.puestos' Puede moverla o quitarla según sea necesario.
            this.puestosTableAdapter.Fill(this.cOPPELDataSet.puestos);
            // TODO: esta línea de código carga datos en la tabla 'cOPPELDataSet.centroTrabajo' Puede moverla o quitarla según sea necesario.
            this.centroTrabajoTableAdapter.Fill(this.cOPPELDataSet.centroTrabajo);
            // TODO: esta línea de código carga datos en la tabla 'cOPPELDataSet.Directivos' Puede moverla o quitarla según sea necesario.
            this.directivosTableAdapter.Fill(this.cOPPELDataSet.Directivos);
            // TODO: esta línea de código carga datos en la tabla 'cOPPELDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.cOPPELDataSet.Empleado);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
