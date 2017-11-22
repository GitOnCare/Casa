using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FRMreporteubicacionproductos : Form
    {
        public FRMreporteubicacionproductos()
        {
            InitializeComponent();
        }

        private void FRMreporteubicacionproductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'CajasDataSet.reporteubicacion' Puede moverla o quitarla según sea necesario.
            this.reporteubicacionTableAdapter.Fill(this.CajasDataSet.reporteubicacion);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
