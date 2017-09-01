namespace RSIJudgingSystemAdmin
{
    partial class RankingReport
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
            this.RankingWinerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RankingWinerTableAdapter = new RSIJudgingSystemAdmin.RSIJudgingSystemDataSetTableAdapters.RankingWinerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RSIJudgingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RankingWinerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RankingWinerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RSIJudgingSystemAdmin.ForRanking.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(816, 460);
            this.reportViewer1.TabIndex = 0;
            // 
            // RSIJudgingSystemDataSet
            // 
            this.RSIJudgingSystemDataSet.DataSetName = "RSIJudgingSystemDataSet";
            this.RSIJudgingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RankingWinerBindingSource
            // 
            this.RankingWinerBindingSource.DataMember = "RankingWiner";
            this.RankingWinerBindingSource.DataSource = this.RSIJudgingSystemDataSet;
            // 
            // RankingWinerTableAdapter
            // 
            this.RankingWinerTableAdapter.ClearBeforeFill = true;
            // 
            // RankingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 460);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RankingReport";
            this.Text = "RankingReport";
            this.Load += new System.EventHandler(this.RankingReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RSIJudgingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RankingWinerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RankingWinerBindingSource;
        private RSIJudgingSystemDataSet RSIJudgingSystemDataSet;
        private RSIJudgingSystemDataSetTableAdapters.RankingWinerTableAdapter RankingWinerTableAdapter;
    }
}