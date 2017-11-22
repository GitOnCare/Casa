namespace WindowsFormsApp1
{
    partial class FRMreporteubicacionproductos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reporteubicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CajasDataSet = new WindowsFormsApp1.CajasDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteubicacionTableAdapter = new WindowsFormsApp1.CajasDataSetTableAdapters.reporteubicacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteubicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CajasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteubicacionBindingSource
            // 
            this.reporteubicacionBindingSource.DataMember = "reporteubicacion";
            this.reporteubicacionBindingSource.DataSource = this.CajasDataSet;
            // 
            // CajasDataSet
            // 
            this.CajasDataSet.DataSetName = "CajasDataSet";
            this.CajasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteubicacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(696, 569);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // reporteubicacionTableAdapter
            // 
            this.reporteubicacionTableAdapter.ClearBeforeFill = true;
            // 
            // FRMreporteubicacionproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 569);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMreporteubicacionproductos";
            this.Text = "Reporte de ubicaciones de productos";
            this.Load += new System.EventHandler(this.FRMreporteubicacionproductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteubicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CajasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteubicacionBindingSource;
        private CajasDataSet CajasDataSet;
        private CajasDataSetTableAdapters.reporteubicacionTableAdapter reporteubicacionTableAdapter;
    }
}