namespace WindowsFormsApp1
{
    partial class Inventario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvcajas = new System.Windows.Forms.DataGridView();
            this.cmbbfiltro = new System.Windows.Forms.ComboBox();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.dgvproductosencaja = new System.Windows.Forms.DataGridView();
            this.btnquitar = new System.Windows.Forms.Button();
            this.lblcodigoproducto = new System.Windows.Forms.Label();
            this.lblcodigocaja = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductosencaja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcajas
            // 
            this.dgvcajas.AllowUserToAddRows = false;
            this.dgvcajas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcajas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcajas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvcajas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcajas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcajas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcajas.GridColor = System.Drawing.SystemColors.Control;
            this.dgvcajas.Location = new System.Drawing.Point(12, 55);
            this.dgvcajas.Name = "dgvcajas";
            this.dgvcajas.ReadOnly = true;
            this.dgvcajas.Size = new System.Drawing.Size(262, 452);
            this.dgvcajas.TabIndex = 0;
            this.dgvcajas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcajas_CellClick);
            this.dgvcajas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvcajas_KeyDown);
            this.dgvcajas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvcajas_KeyUp);
            // 
            // cmbbfiltro
            // 
            this.cmbbfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbfiltro.FormattingEnabled = true;
            this.cmbbfiltro.Location = new System.Drawing.Point(174, 20);
            this.cmbbfiltro.Name = "cmbbfiltro";
            this.cmbbfiltro.Size = new System.Drawing.Size(129, 28);
            this.cmbbfiltro.TabIndex = 1;
            this.cmbbfiltro.SelectedIndexChanged += new System.EventHandler(this.cmbbfiltro_SelectedIndexChanged);
            // 
            // txtfiltro
            // 
            this.txtfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltro.Location = new System.Drawing.Point(12, 20);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(138, 26);
            this.txtfiltro.TabIndex = 2;
            this.txtfiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvproductosencaja
            // 
            this.dgvproductosencaja.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductosencaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvproductosencaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproductosencaja.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvproductosencaja.Location = new System.Drawing.Point(319, 55);
            this.dgvproductosencaja.Name = "dgvproductosencaja";
            this.dgvproductosencaja.Size = new System.Drawing.Size(419, 452);
            this.dgvproductosencaja.TabIndex = 3;
            this.dgvproductosencaja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductosencaja_CellClick);
            this.dgvproductosencaja.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductosencaja_CellDoubleClick);
            // 
            // btnquitar
            // 
            this.btnquitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitar.Location = new System.Drawing.Point(760, 55);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(109, 43);
            this.btnquitar.TabIndex = 4;
            this.btnquitar.Text = "Quitar ";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // lblcodigoproducto
            // 
            this.lblcodigoproducto.AutoSize = true;
            this.lblcodigoproducto.Location = new System.Drawing.Point(810, 28);
            this.lblcodigoproducto.Name = "lblcodigoproducto";
            this.lblcodigoproducto.Size = new System.Drawing.Size(35, 13);
            this.lblcodigoproducto.TabIndex = 5;
            this.lblcodigoproducto.Text = "label1";
            this.lblcodigoproducto.Visible = false;
            // 
            // lblcodigocaja
            // 
            this.lblcodigocaja.AutoSize = true;
            this.lblcodigocaja.Location = new System.Drawing.Point(769, 33);
            this.lblcodigocaja.Name = "lblcodigocaja";
            this.lblcodigocaja.Size = new System.Drawing.Size(35, 13);
            this.lblcodigocaja.TabIndex = 6;
            this.lblcodigocaja.Text = "label2";
            this.lblcodigocaja.Visible = false;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1103, 608);
            this.Controls.Add(this.lblcodigocaja);
            this.Controls.Add(this.lblcodigoproducto);
            this.Controls.Add(this.btnquitar);
            this.Controls.Add(this.dgvproductosencaja);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.cmbbfiltro);
            this.Controls.Add(this.dgvcajas);
            this.Name = "Inventario";
            this.Tag = "Inventairo";
            this.Text = "Inventario";
            this.Activated += new System.EventHandler(this.Inventario_Activated);
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductosencaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcajas;
        private System.Windows.Forms.ComboBox cmbbfiltro;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.DataGridView dgvproductosencaja;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Label lblcodigoproducto;
        private System.Windows.Forms.Label lblcodigocaja;
    }
}

