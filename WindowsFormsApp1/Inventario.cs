using System;
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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        
        String strconection = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.CajasConnectionString"].ConnectionString;
        public string Strconection { get => strconection; set => strconection = value; }

        DataTable cajas = new DataTable();
        DataTable ubicacion = new DataTable();
        DataTable Productos = new DataTable();
    
        public void Inventario_Load(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection(strconection);
            try
            {

                btnquitar.Enabled = false;
                String strSql = "Select cajas.caja as Caja,cajas.id_caja, ubicacion.descripcion as Ubicación,ubicacion.id_ubicacion,  cajas.volumen from  cajas, ubicacion where ubicacion.id_ubicacion=cajas.id_ubicacion order by ubicacion.descripcion desc, cajas.caja * 1 asc";
                String strSqlCmb = "Select ubicacion.descripcion from ubicacion";
                OleDbCommand comandobuscarcajas = new OleDbCommand(strSql, con);
                OleDbCommand comandobuscarubicacion = new OleDbCommand(strSqlCmb, con);
                con.Open();
                comandobuscarcajas.CommandType = CommandType.Text;
                comandobuscarubicacion.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(comandobuscarcajas);
                OleDbDataAdapter dacmbx = new OleDbDataAdapter(comandobuscarubicacion);
                dacmbx.Fill(ubicacion);
                da.Fill(cajas);
                dgvcajas.DataSource = cajas;
                dgvcajas.Columns[1].Visible = false;
                dgvcajas.Columns[2].Visible = false;
                dgvcajas.Columns[3].Visible = false;
                cmbbfiltro.DataSource = ubicacion;
                cmbbfiltro.DisplayMember = "id_ubicacion";
                cmbbfiltro.ValueMember = "descripcion";
                con.Close();
            }
            catch (Exception ex)
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

        private void cmbbfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = cajas.DefaultView;
            dv.RowFilter = string.Format("Ubicación like '%{0}%'", cmbbfiltro.Text);
            dgvcajas.DataSource = dv;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = cajas.DefaultView;
            dv.RowFilter = string.Format("caja like '{0}%' and Ubicación like'%{1}%'", txtfiltro.Text, cmbbfiltro.Text);
            dgvcajas.DataSource = dv.ToTable();

        }
        private void Obtener_productos_encaja(DataTable productos)
        {
            OleDbConnection con = new OleDbConnection(strconection);
            try
            {
                string idcolumna = dgvcajas.CurrentRow.Cells["id_caja"].Value.ToString();
                String strsql = "Select relacioncp.cod_producto as Codigo, productos.descripcion as Producto from productos, relacioncp where productos.cod_producto=relacioncp.cod_producto and relacioncp.id_caja=" + idcolumna + "";
                
                OleDbCommand comandobuscarproducto = new OleDbCommand(strsql, con);
                con.Open();
                comandobuscarproducto.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(comandobuscarproducto);
                da.Fill(Productos);
                con.Close();
            }
            catch (Exception ex)
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
        private void dgvcajas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnquitar.Enabled = false;
            dgvproductosencaja.DataSource = null;
            dgvproductosencaja.Rows.Clear();
            Productos.Clear();
            Obtener_productos_encaja(Productos);
            dgvproductosencaja.DataSource = Productos;
            dgvproductosencaja.Columns[0].Width = 75;
            dgvproductosencaja.Columns[1].Width = 300;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvproductosencaja.DataSource = null;
            dgvproductosencaja.Rows.Clear();
            dgvproductosencaja.Refresh();
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("¿Seguro que quiere quitar este producto?", "Cuidado!", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                OleDbConnection con = new OleDbConnection(strconection);
                try
                {
                    string codigo = lblcodigoproducto.Text;
                    int id_caja = Convert.ToInt16(lblcodigocaja.Text);
                    string strincomando = "DELETE FROM relacioncp WHERE cod_producto='" + codigo + "' and id_caja=" + id_caja + "";
                    con.Open();
                    OleDbCommand cmdborrar = new OleDbCommand(strincomando, con);
                    cmdborrar.ExecuteNonQuery();
                    Productos.Clear();
                    Obtener_productos_encaja(Productos);
                    dgvproductosencaja.DataSource = null;
                    dgvproductosencaja.Rows.Clear();
                    dgvproductosencaja.DataSource = Productos;
                    dgvproductosencaja.Columns[0].Width = 75;
                    dgvproductosencaja.Columns[1].Width = 300;
                    lblcodigocaja.Text = "";
                    lblcodigoproducto.Text = "";
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


        }

        public void dgvproductosencaja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_caja = Convert.ToInt32(dgvcajas.CurrentRow.Cells[1].Value.ToString());
            int id_ubicacion = Convert.ToInt32(dgvcajas.CurrentRow.Cells[3].Value.ToString());
            
            FRMagregarproducto frm = new FRMagregarproducto(id_caja, id_ubicacion);
            frm.Show();
            
        }
        

        private void Inventario_Activated(object sender, EventArgs e)
        {
           Productos.Clear();
           Obtener_productos_encaja(Productos);
           dgvproductosencaja.DataSource = null;
           dgvproductosencaja.Rows.Clear();
           dgvproductosencaja.DataSource = Productos;
           dgvproductosencaja.Columns[0].Width = 75;
           dgvproductosencaja.Columns[1].Width = 300;
        }

        private void dgvproductosencaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnquitar.Enabled = true;
            string codigo = dgvproductosencaja.CurrentRow.Cells["Codigo"].Value.ToString();
            string id_caja =dgvcajas.CurrentRow.Cells["id_caja"].Value.ToString();
            lblcodigoproducto.Text = codigo;
            lblcodigocaja.Text = id_caja;
        }

        private void dgvcajas_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dgvcajas_KeyUp(object sender, KeyEventArgs e)
        {
            btnquitar.Enabled = false;
            dgvproductosencaja.DataSource = null;
            dgvproductosencaja.Rows.Clear();
            Productos.Clear();
            Obtener_productos_encaja(Productos);
            dgvproductosencaja.DataSource = Productos;
            dgvproductosencaja.Columns[0].Width = 75;
            dgvproductosencaja.Columns[1].Width = 300;
        }
    }
}
