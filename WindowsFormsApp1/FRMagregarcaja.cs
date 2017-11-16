using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class FRMagregarcaja : Form
    {
        public FRMagregarcaja(string cod_producto)
        {
            InitializeComponent();
            txtcodigoproducto.Text = cod_producto;
        }
        String strconection = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.CajasConnectionString"].ConnectionString; DataTable cajas = new DataTable();
        DataTable ubicacion = new DataTable();
        private void FRMagregarcaja_Load(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection(strconection);
            txtcaja.Select();
            try
            {
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
                dgvcajas.Columns[3].Visible = false;
                cmbfiltro.DataSource = ubicacion;
                cmbfiltro.DisplayMember = "id_ubicacion";
                cmbfiltro.ValueMember = "descripcion";
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

        private void cmbfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = cajas.DefaultView;
            dv.RowFilter = string.Format("Ubicación like '%{0}%'", cmbfiltro.Text);
            dgvcajas.DataSource = dv;
        }

        private void txtcaja_TextChanged(object sender, EventArgs e)
        {
            DataView dv = cajas.DefaultView;
            dv.RowFilter = string.Format("caja like '{0}%' and Ubicación like'%{1}%'", txtcaja.Text, cmbfiltro.Text);
            dgvcajas.DataSource = dv.ToTable();
        }

        private void dgvcajas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            OleDbConnection con = new OleDbConnection(strconection);
            string cod_producto = txtcodigoproducto.Text;
            int id_caja = Convert.ToInt16(dgvcajas.CurrentRow.Cells["id_caja"].Value.ToString());
            int id_ubicacion = Convert.ToInt16(dgvcajas.CurrentRow.Cells["id_ubicacion"].Value.ToString());
            try
            {
                string insertar = "Insert into relacioncp Values (" + id_caja + ",'" + cod_producto + "'," + id_ubicacion + ")";
                con.Open();
                OleDbCommand cmdinsertar = new OleDbCommand(insertar, con);
                cmdinsertar.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
            catch (Exception ex)
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

        private void btninsertar_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(strconection);
            string cod_producto = txtcodigoproducto.Text;
            int id_caja = Convert.ToInt16(dgvcajas.CurrentRow.Cells["id_caja"].Value.ToString());
            int id_ubicacion = Convert.ToInt16(dgvcajas.CurrentRow.Cells["id_ubicacion"].Value.ToString());
            try
            {
                string insertar = "Insert into relacioncp Values (" + id_caja + ",'" + cod_producto + "'," + id_ubicacion + ")";
                con.Open();
                OleDbCommand cmdinsertar = new OleDbCommand(insertar, con);
                cmdinsertar.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
            catch (Exception ex)
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
