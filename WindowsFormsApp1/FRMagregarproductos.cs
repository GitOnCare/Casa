using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace WindowsFormsApp1
{
    public partial class FRMagregarproducto : Form
    {
        public  FRMagregarproducto(int id_caja, int id_ubicacion)
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(id_caja);
            textBox2.Text = Convert.ToString(id_ubicacion);
        }


        String strconection = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.CajasConnectionString"].ConnectionString; DataTable productosasignados = new DataTable();
        
        private void FRMagregarproducto_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(strconection);
            txtfiltrar.Select();
            cmbfiltro.SelectedIndex = 0;
            try
            {
                String consulta = "Select productos.cod_producto as Código, productos.referencia as Referencia,productos.descripcion as Producto,existencia.cantidad as Existencia from productos, existencia where existencia.cod_articulo=productos.cod_producto order by productos.descripcion";
                OleDbCommand cmdobtenerproductos = new OleDbCommand(consulta, con);
                con.Open();
                cmdobtenerproductos.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cmdobtenerproductos);
                da.Fill(productosasignados);
                dgvagregarproductos.DataSource = productosasignados;
                dgvagregarproductos.Columns[0].Width = 75;
                dgvagregarproductos.Columns[1].Width = 100;
                dgvagregarproductos.Columns[2].Width = 350;
                dgvagregarproductos.Columns[3].Width = 100;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Verifique la conexión");
            }
            finally
            {
                if(con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
                



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (cmbfiltro.SelectedIndex == 0)
            { 
            DataView dv = productosasignados.DefaultView;
            dv.RowFilter = string.Format(""+cmbfiltro.Text+" like '%{0}%'",txtfiltrar.Text);
            dgvagregarproductos.DataSource = dv.ToTable();
            }
            else
            if (cmbfiltro.SelectedIndex == 1)
            {
                DataView dv = productosasignados.DefaultView;
                dv.RowFilter = string.Format("" + cmbfiltro.Text + " like '{0}'", txtfiltrar.Text);
                dgvagregarproductos.DataSource = dv.ToTable();
            }
            else
            {
                DataView dv = productosasignados.DefaultView;
                dv.RowFilter = string.Format("" + cmbfiltro.Text + " like '%{0}%'", txtfiltrar.Text);
                dgvagregarproductos.DataSource = dv.ToTable();
            }


        }

        private void dgvagregarproductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OleDbConnection con = new OleDbConnection(strconection);
            int id_caja = Convert.ToInt16(textBox1.Text);
            int id_ubicacion = Convert.ToInt16(textBox2.Text);
            string codigo = dgvagregarproductos.CurrentRow.Cells["Código"].Value.ToString();
            string insertar = "insert into relacioncp Values(" + id_caja + ",'" + codigo + "'," + id_ubicacion + ")";
            try
            {
                con.Open();
                OleDbCommand cmdinsertar = new OleDbCommand(insertar, con);
                cmdinsertar.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Verifique la conexión");
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }
    }
}
