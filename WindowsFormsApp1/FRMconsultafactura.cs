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
    public partial class FRMconsultafactura : Form
    {
        public FRMconsultafactura()
        {
            InitializeComponent();
        }

        private void FRMconsultafactura_Load(object sender, EventArgs e)
        {
            this.reportViewer1.PrinterSettings.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.DataTable1TableAdapter.FillBy(this.FacturasDataSet.DataTable1, new System.Nullable<int>(((int)(System.Convert.ChangeType(textBox1.Text, typeof(int))))));
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
