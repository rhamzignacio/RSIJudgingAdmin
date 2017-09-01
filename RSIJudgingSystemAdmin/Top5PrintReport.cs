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
    public partial class Top5PrintReport : Form
    {
        public Top5PrintReport()
        {
            InitializeComponent();

            using (var db = new RSIJudgingSystemEntities())
            {
                Top5WinnersBindingSource.DataSource = db.Top5Winners.OrderByDescending(r => r.FinalScore).ToList();

                reportViewer1.RefreshReport();
            }
        }

        private void Top5PrintReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RSIJudgingSystemDataSet.Top5Winners' table. You can move, or remove it, as needed.
            this.Top5WinnersTableAdapter.Fill(this.RSIJudgingSystemDataSet.Top5Winners);

            this.reportViewer1.RefreshReport();
        }
    }
}
