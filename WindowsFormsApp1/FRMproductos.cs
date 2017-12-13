using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace WindowsFormsApp1
{
    public partial class FRMproductos : Form
    {
        public FRMproductos()
        {
            InitializeComponent();
        }
        String strconection = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.CajasConnectionString"].ConnectionString;
        
        DataTable Productos2 = new DataTable();
        DataTable Cajas = new DataTable();
        string direccionfotos = "\\\\Caja-pc\\c\\GPLUS1.0\\imagenes\\";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (cmbfiltro.SelectedIndex == 0)
            {
                DataView dv = Productos2.DefaultView;
                dv.RowFilter = string.Format("" + cmbfiltro.Text + " like '%{0}%'", txtfiltrarproducto.Text);
                dgvproductos.DataSource = dv.ToTable();
            }
            else
            if (cmbfiltro.SelectedIndex == 1)
            {
                DataView dv = Productos2.DefaultView;
                dv.RowFilter = string.Format("" + cmbfiltro.Text + " like '{0}'", txtfiltrarproducto.Text);
                dgvproductos.DataSource = dv.ToTable();
            }
            else
            {
                DataView dv = Productos2.DefaultView;
                dv.RowFilter = string.Format("" + cmbfiltro.Text + " like '%{0}%'", txtfiltrarproducto.Text);
                dgvproductos.DataSource = dv.ToTable();
            }


        }

        private void FRMproductos_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(strconection);
            try
            {
                txtfiltrarproducto.Select();
                cmbfiltro.SelectedIndex = 0;
                String strbuscarproductos = "Select productos.cod_producto as Código,productos.referencia as Referencia, productos.descripcion as Producto, existencia.cantidad as Existencia From productos, existencia Where productos.cod_producto=existencia.cod_articulo order by productos.descripcion asc";               
                OleDbCommand cmdbuscarproductos = new OleDbCommand(strbuscarproductos, con);
                con.Open();
                cmdbuscarproductos.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cmdbuscarproductos);
                da.Fill(Productos2);
                dgvproductos.DataSource = Productos2;
                dgvproductos.Columns[0].Width = 75;
                dgvproductos.Columns[1].Width = 100;
                dgvproductos.Columns[2].Width = 370;
                dgvproductos.Columns[3].Width = 100;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }



        }

        private void dgvproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvcajadelproducto.DataSource = null;
            dgvcajadelproducto.Rows.Clear();
            Cajas.Clear();
            Obtener_ubicacion_producto(Cajas);
            dgvcajadelproducto.DataSource = Cajas;
            dgvcajadelproducto.Columns[0].Visible = false;
            imagenproducto.Image = null;
            string codproducto = dgvproductos.CurrentRow.Cells["Código"].Value.ToString();
            try
            {
                Image imagen= Image.FromFile(@"\\\\CAJA-PC\\c\\GPLUS1.0\\imagenes\\" + codproducto + ".jpg");
                Bitmap bmimagen = new Bitmap(imagen);
                imagen.Dispose();
                imagen = null;
                imagenproducto.Image = bmimagen;
            }
            catch
            {

            }
            finally
            {
            }


        }
        private void Obtener_ubicacion_producto(DataTable Cajas)
        {
            string codproducto = dgvproductos.CurrentRow.Cells["Código"].Value.ToString();
            String sqlbuscarubicacion = "Select relacioncp.id_caja, cajas.caja as Caja,ubicacion.descripcion as Ubicación From Cajas,relacioncp,ubicacion Where relacioncp.id_ubicacion=ubicacion.id_ubicacion and relacioncp.cod_producto='" + codproducto + "' and cajas.id_caja=relacioncp.id_caja ";
            OleDbConnection con = new OleDbConnection(strconection);
            try
            {
                OleDbCommand comandobuscarcaja = new OleDbCommand(sqlbuscarubicacion, con);
                con.Open();
                comandobuscarcaja.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(comandobuscarcaja);
                da.Fill(Cajas);
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Verifique la conexión con la base de datos");
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection(strconection);
            DialogResult dialogresult = MessageBox.Show("¿Seguro que quiere quitar este producto?", "Cuidado!", MessageBoxButtons.YesNo);
            try
            {
                if (dialogresult == DialogResult.Yes)
                {
                    int codigocaja = Convert.ToInt16(label1.Text);
                    string codigoproducto = label2.Text;
                    string comando = "DELETE FROM relacioncp WHERE id_caja=" + codigocaja + " and cod_producto='" + codigoproducto + "'";
                    con.Open();
                    OleDbCommand cmdborrar = new OleDbCommand(comando, con);
                    cmdborrar.ExecuteNonQuery();
                    

                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Verifique la conexión con la base de datos");
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            Cajas.Clear();
            Obtener_ubicacion_producto(Cajas);
            dgvcajadelproducto.DataSource = null;
            dgvcajadelproducto.Rows.Clear();
            dgvcajadelproducto.DataSource = Cajas;

            dgvcajadelproducto.Columns[0].Visible = false;

        }

        private void dgvcajadelproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo =dgvcajadelproducto.CurrentRow.Cells["id_caja"].Value.ToString();
            label1.Text = codigo;
            string codigoproducto = dgvproductos.CurrentRow.Cells["Código"].Value.ToString();
            label2.Text = codigoproducto;
        }

        private void dgvcajadelproducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string cod_producto = dgvproductos.CurrentRow.Cells["Código"].Value.ToString();
            FRMagregarcaja frm = new FRMagregarcaja(cod_producto);
            frm.Show();
        }

        private void FRMproductos_Activated(object sender, EventArgs e)
        {
            Cajas.Clear();
            Obtener_ubicacion_producto(Cajas);
            dgvcajadelproducto.DataSource = null;
            dgvcajadelproducto.Rows.Clear();
            dgvcajadelproducto.DataSource = Cajas;

            dgvcajadelproducto.Columns[0].Visible = false;
            
           

        }

        private void verCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario frm = new Inventario();
            frm.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMreporteubicacionproductos frm = new FRMreporteubicacionproductos();
            frm.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMconsultafactura frm = new FRMconsultafactura();
            frm.Show();
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            string codproducto = dgvproductos.CurrentRow.Cells["Código"].Value.ToString();
            OpenFileDialog foto= new OpenFileDialog();
            foto.Filter = "Archivo JPG|*.jpg";
            if (foto.ShowDialog() == DialogResult.OK)
            {
                string direccionfinal = direccionfotos + "\\" + codproducto+".jpg";
                using(FileStream fs = File.Create(direccionfinal)) { }
                File.Delete(direccionfinal);
                
                
                File.Copy(foto.FileName, direccionfinal);
                Image imagen = Image.FromFile(@"\\\\CAJA-PC\\c\\GPLUS1.0\\imagenes\\" + codproducto + ".jpg");
                Bitmap bmimagen = new Bitmap(imagen);
                imagen.Dispose();
                imagen = null;
                imagenproducto.Image = bmimagen;
            }
            
        }
    }
}
