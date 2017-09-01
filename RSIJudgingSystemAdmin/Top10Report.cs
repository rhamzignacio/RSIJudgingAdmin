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
    public partial class Top10Report : Form
    {
        public Top10Report()
        {
            InitializeComponent();

            using (var db = new RSIJudgingSystemEntities())
            {
                Top10WinnersBindingSource.DataSource = db.Top10Winners.OrderByDescending(r=>r.FinalScore).ToList();

                reportViewer1.RefreshReport();
            }
        }

        private void Top10Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RSIJudgingSystemDataSet.Top10Winners' table. You can move, or remove it, as needed.
            this.Top10WinnersTableAdapter.Fill(this.RSIJudgingSystemDataSet.Top10Winners);

            this.reportViewer1.RefreshReport();
        }
    }
}
