using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSIJudgingSystemAdmin
{
    public partial class RankingReport : Form
    {
        public RankingReport()
        {
            InitializeComponent();

            using (var db = new RSIJudgingSystemEntities())
            {
                RankingWinerBindingSource.DataSource = db.RankingWiner.OrderByDescending(r => r.FinalScore).ToList();

                reportViewer1.RefreshReport();
            }
        }

        private void RankingReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RSIJudgingSystemDataSet.RankingWiner' table. You can move, or remove it, as needed.
            this.RankingWinerTableAdapter.Fill(this.RSIJudgingSystemDataSet.RankingWiner);

            this.reportViewer1.RefreshReport();
        }
    }
}
