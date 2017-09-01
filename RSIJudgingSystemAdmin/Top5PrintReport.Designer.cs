namespace RSIJudgingSystemAdmin
{
    partial class Top5PrintReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RSIJudgingSystemDataSet = new RSIJudgingSystemAdmin.RSIJudgingSystemDataSet();
            this.Top5WinnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Top5WinnersTableAdapter = new RSIJudgingSystemAdmin.RSIJudgingSystemDataSetTableAdapters.Top5WinnersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RSIJudgingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top5WinnersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Top5WinnersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RSIJudgingSystemAdmin.Top5Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(895, 566);
            this.reportViewer1.TabIndex = 0;
            // 
            // RSIJudgingSystemDataSet
            // 
            this.RSIJudgingSystemDataSet.DataSetName = "RSIJudgingSystemDataSet";
            this.RSIJudgingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Top5WinnersBindingSource
            // 
            this.Top5WinnersBindingSource.DataMember = "Top5Winners";
            this.Top5WinnersBindingSource.DataSource = this.RSIJudgingSystemDataSet;
            // 
            // Top5WinnersTableAdapter
            // 
            this.Top5WinnersTableAdapter.ClearBeforeFill = true;
            // 
            // Top5PrintReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 566);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Top5PrintReport";
            this.Text = "Top5PrintReport";
            this.Load += new System.EventHandler(this.Top5PrintReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RSIJudgingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top5WinnersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Top5WinnersBindingSource;
        private RSIJudgingSystemDataSet RSIJudgingSystemDataSet;
        private RSIJudgingSystemDataSetTableAdapters.Top5WinnersTableAdapter Top5WinnersTableAdapter;
    }
}