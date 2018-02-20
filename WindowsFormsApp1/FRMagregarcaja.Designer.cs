namespace WindowsFormsApp1
{
    partial class FRMagregarcaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtcodigoproducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvcajas = new System.Windows.Forms.DataGridView();
            this.txtcaja = new System.Windows.Forms.TextBox();
            this.cmbfiltro = new System.Windows.Forms.ComboBox();
            this.btninsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcajas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodigoproducto
            // 
            this.txtcodigoproducto.Enabled = false;
            this.txtcodigoproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoproducto.Location = new System.Drawing.Point(21, 34);
            this.txtcodigoproducto.Name = "txtcodigoproducto";
            this.txtcodigoproducto.Size = new System.Drawing.Size(100, 26);
            this.txtcodigoproducto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // dgvcajas
            // 
            this.dgvcajas.AllowUserToAddRows = false;
            this.dgvcajas.AllowUserToDeleteRows = false;
            this.dgvcajas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcajas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcajas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcajas.Location = new System.Drawing.Point(21, 118);
            this.dgvcajas.Name = "dgvcajas";
            this.dgvcajas.ReadOnly = true;
            this.dgvcajas.Size = new System.Drawing.Size(365, 269);
            this.dgvcajas.TabIndex = 2;
            this.dgvcajas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcajas_CellDoubleClick);
            this.dgvcajas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvcajas_KeyPress);
            // 
            // txtcaja
            // 
            this.txtcaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcaja.Location = new System.Drawing.Point(21, 86);
            this.txtcaja.Name = "txtcaja";
            this.txtcaja.Size = new System.Drawing.Size(114, 26);
            this.txtcaja.TabIndex = 3;
            this.txtcaja.TextChanged += new System.EventHandler(this.txtcaja_TextChanged);
            // 
            // cmbfiltro
            // 
            this.cmbfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfiltro.FormattingEnabled = true;
            this.cmbfiltro.Location = new System.Drawing.Point(162, 86);
            this.cmbfiltro.Name = "cmbfiltro";
            this.cmbfiltro.Size = new System.Drawing.Size(121, 28);
            this.cmbfiltro.TabIndex = 4;
            this.cmbfiltro.SelectedIndexChanged += new System.EventHandler(this.cmbfiltro_SelectedIndexChanged);
            // 
            // btninsertar
            // 
            this.btninsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.Location = new System.Drawing.Point(21, 394);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(100, 36);
            this.btninsertar.TabIndex = 5;
            this.btninsertar.Text = "Agregar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // FRMagregarcaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 477);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.cmbfiltro);
            this.Controls.Add(this.txtcaja);
            this.Controls.Add(this.dgvcajas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcodigoproducto);
            this.Name = "FRMagregarcaja";
            this.Text = "Agregar ubicación";
            this.Load += new System.EventHandler(this.FRMagregarcaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcajas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigoproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvcajas;
        private System.Windows.Forms.TextBox txtcaja;
        private System.Windows.Forms.ComboBox cmbfiltro;
        private System.Windows.Forms.Button btninsertar;
    }
}