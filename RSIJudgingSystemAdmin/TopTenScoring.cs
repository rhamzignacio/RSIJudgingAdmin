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
    public partial class TopTenScoring : Form
    {
        public TopTenScoring()
        {
            InitializeComponent();

            GetJudge1();
        }

        private void GetJudge1()
        {
            listView1.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var contestants = from c in db.ContestantProfile
                                  join j1 in db.Top10Judge1 on c.ContestantNo equals j1.ContestantNo
                                  select new Top10Model
                                  {
                                      ContestantNo = c.ContestantNo,
                                      PanelInterview = c.PanelInterview,
                                      beauty = j1.Beauty,
                                      delivery = j1.Delivery,
                                      intelligence = j1.Intelligence
                                  };

                contestants.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem("1");
                    lvi.SubItems.Add(item.ContestantNo);
                    lvi.SubItems.Add(item.TotalScore.ToString());

                    listView1.Items.Add(lvi);
                });
            }
        }
    }
}
