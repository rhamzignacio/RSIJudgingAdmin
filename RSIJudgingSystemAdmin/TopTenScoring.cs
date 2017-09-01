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
        List<Top10Model> judge1 = new List<Top10Model>();
        List<Top10Model> judge2 = new List<Top10Model>();
        List<Top10Model> judge3 = new List<Top10Model>();
        List<Top10Model> judge4 = new List<Top10Model>();
        List<Top10Model> judge5 = new List<Top10Model>();
        List<Top10Model> judge6 = new List<Top10Model>();
        List<Top10Model> judge7 = new List<Top10Model>();

        public TopTenScoring()
        {
            InitializeComponent();

            timer1 = new Timer();

            timer1.Tick += new EventHandler(timer1_Tick);

            timer1.Interval = 1000;

            timer1.Start();
        }

        private void GetJudge1()
        {
            listView1.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var contestants = from c in db.ContestantProfile
                                  join j in db.Top10Judge1 on c.ContestantNo equals j.ContestantNo
                                  select new Top10Model
                                  {
                                      ContestantNo = c.ContestantNo,
                                      PanelInterview = c.PanelInterview,
                                      beauty = j.Beauty,
                                      delivery = j.Delivery,
                                      intelligence = j.Intelligence,
                                      TotalScore = ((c.PanelInterview / 100) * 50) + j.Beauty + j.Delivery + j.Intelligence
                                  };

                int ctr = 1;

                judge1 = contestants.ToList();

                contestants.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());
                    lvi.SubItems.Add(item.ContestantNo);
                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView1.Items.Add(lvi);

                    ctr++;
                });
            }
        }

        private void GetJudge2()
        {
            listView2.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var contestants = from c in db.ContestantProfile
                                  join j in db.Top10Judge2 on c.ContestantNo equals j.ContestantNo
                                  select new Top10Model
                                  {
                                      ContestantNo = c.ContestantNo,
                                      PanelInterview = c.PanelInterview,
                                      beauty = j.Beauty,
                                      delivery = j.Delivery,
                                      intelligence = j.Intelligence,
                                      TotalScore = ((c.PanelInterview / 100) * 50) + j.Beauty + j.Delivery + j.Intelligence
                                  };

                int ctr = 1;

                judge2 = contestants.ToList();

                contestants.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());
                    lvi.SubItems.Add(item.ContestantNo);
                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView2.Items.Add(lvi);

                    ctr++;
                });
            }
        }

        private void GetJudge3()
        {
            listView3.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var contestants = from c in db.ContestantProfile
                                  join j in db.Top10Judge3 on c.ContestantNo equals j.ContestantNo
                                  select new Top10Model
                                  {
                                      ContestantNo = c.ContestantNo,
                                      PanelInterview = c.PanelInterview,
                                      beauty = j.Beauty,
                                      delivery = j.Delivery,
                                      intelligence = j.Intelligence,
                                      TotalScore = ((c.PanelInterview / 100) * 50) + j.Beauty + j.Delivery + j.Intelligence
                                  };

                int ctr = 1;

                judge3 = contestants.ToList();

                contestants.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());
                    lvi.SubItems.Add(item.ContestantNo);
                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView3.Items.Add(lvi);

                    ctr++;
                });
            }
        }

        private void GetJudge4()
        {
            listView4.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var contestants = from c in db.ContestantProfile
                                  join j in db.Top10Judge4 on c.ContestantNo equals j.ContestantNo
                                  select new Top10Model
                                  {
                                      ContestantNo = c.ContestantNo,
                                      PanelInterview = c.PanelInterview,
                                      beauty = j.Beauty,
                                      delivery = j.Delivery,
                                      intelligence = j.Intelligence,
                                      TotalScore = ((c.PanelInterview / 100) * 50) + j.Beauty + j.Delivery + j.Intelligence
                                  };

                int ctr = 1;

                judge4 = contestants.ToList();

                contestants.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());
                    lvi.SubItems.Add(item.ContestantNo);
                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView4.Items.Add(lvi);

                    ctr++;
                });
            }
        }

        private void GetJudge5()
        {
            listView5.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var contestants = from c in db.ContestantProfile
                                  join j in db.Top10Judge5 on c.ContestantNo equals j.ContestantNo
                                  select new Top10Model
                                  {
                                      ContestantNo = c.ContestantNo,
                                      PanelInterview = c.PanelInterview,
                                      beauty = j.Beauty,
                                      delivery = j.Delivery,
                                      intelligence = j.Intelligence,
                                      TotalScore = ((c.PanelInterview / 100) * 50) + j.Beauty + j.Delivery + j.Intelligence
                                  };

                int ctr = 1;

                judge5 = contestants.ToList();

                contestants.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());
                    lvi.SubItems.Add(item.ContestantNo);
                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView5.Items.Add(lvi);

                    ctr++;
                });
            }
        }

        private void GetJudge6()
        {
            listView6.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var contestants = from c in db.ContestantProfile
                                  join j in db.Top10Judge6 on c.ContestantNo equals j.ContestantNo
                                  select new Top10Model
                                  {
                                      ContestantNo = c.ContestantNo,
                                      PanelInterview = c.PanelInterview,
                                      beauty = j.Beauty,
                                      delivery = j.Delivery,
                                      intelligence = j.Intelligence,
                                      TotalScore = ((c.PanelInterview / 100) * 50) + j.Beauty + j.Delivery + j.Intelligence
                                  };

                int ctr = 1;

                judge6 = contestants.ToList();

                contestants.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());
                    lvi.SubItems.Add(item.ContestantNo);
                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView6.Items.Add(lvi);

                    ctr++;
                });
            }
        }

        private void GetJudge7()
        {
            listView7.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var contestants = from c in db.ContestantProfile
                                  join j in db.Top10Judge7 on c.ContestantNo equals j.ContestanceNo
                                  select new Top10Model
                                  {
                                      ContestantNo = c.ContestantNo,
                                      PanelInterview = c.PanelInterview,
                                      beauty = j.Beauty,
                                      delivery = j.Delivery,
                                      intelligence = j.Intelligence,
                                      TotalScore = ((c.PanelInterview / 100) * 50) + j.Beauty + j.Delivery + j.Intelligence
                                  };

                int ctr = 1;

                judge7 = contestants.ToList();

                contestants.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());
                    lvi.SubItems.Add(item.ContestantNo);
                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView7.Items.Add(lvi);

                    ctr++;
                });
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetJudge1();

            GetJudge2();

            GetJudge3();

            GetJudge4();

            GetJudge5();

            GetJudge6();

            GetJudge7();

            GetAverageScore();
        }

        private void GetAverageScore()
        {
            using (var db = new RSIJudgingSystemEntities())
            {
                var contestant = db.ContestantProfile.OrderByDescending(r => r.PanelInterview).ToList();

                List<Top10ScoreModel> top10List = new List<Top10ScoreModel>();

                for (int x = 0; x < contestant.Count; x++)
                {
                    if(x < 10)
                    {
                        var contesNo = contestant[x].ContestantNo;

                        var query = from c in db.ContestantProfile
                                    join j1 in db.Top10Judge1 on c.ContestantNo equals j1.ContestantNo into qJ1
                                    from fJ1 in qJ1.DefaultIfEmpty()
                                    join j2 in db.Top10Judge2 on c.ContestantNo equals j2.ContestantNo into qJ2
                                    from fJ2 in qJ2.DefaultIfEmpty()
                                    join j3 in db.Top10Judge3 on c.ContestantNo equals j3.ContestantNo into qJ3
                                    from fJ3 in qJ3.DefaultIfEmpty()
                                    join j4 in db.Top10Judge4 on c.ContestantNo equals j4.ContestantNo into qJ4
                                    from fJ4 in qJ4.DefaultIfEmpty()
                                    join j5 in db.Top10Judge5 on c.ContestantNo equals j5.ContestantNo into qJ5
                                    from fJ5 in qJ5.DefaultIfEmpty()
                                    join j6 in db.Top10Judge6 on c.ContestantNo equals j6.ContestantNo into qJ6
                                    from fJ6 in qJ6.DefaultIfEmpty()
                                    join j7 in db.Top10Judge7 on c.ContestantNo equals j7.ContestanceNo into qJ7
                                    from fJ7 in qJ7.DefaultIfEmpty()
                                    where c.ContestantNo == contesNo
                                    select new Top10ScoreModel
                                    {
                                        contestantNo = c.ContestantNo,
                                        panelInterview = c.PanelInterview,

                                        beauty1 = fJ1.Beauty,
                                        intelligence1 = fJ1.Intelligence,
                                        delivery1 = fJ1.Delivery,

                                        beauty2 = fJ2.Beauty,
                                        intelligence2 = fJ2.Intelligence,
                                        delivery2 = fJ2.Delivery,

                                        beauty3 = fJ3.Beauty,
                                        intelligence3 = fJ3.Intelligence,
                                        delivery3 = fJ3.Delivery,

                                        beauty4 = fJ4.Beauty,
                                        intelligence4 = fJ4.Intelligence,
                                        delivery4 = fJ4.Delivery,

                                        beauty5 = fJ5.Beauty,
                                        intelligence5 = fJ5.Intelligence,
                                        delivery5 = fJ5.Delivery,

                                        beauty6 = fJ6.Beauty,
                                        intelligence6 = fJ6.Intelligence,
                                        delivery6 = fJ6.Delivery,

                                        beauty7 = fJ7.Beauty,
                                        intelligence7 = fJ7.Intelligence,
                                        delivery7 = fJ7.Delivery
                                    };

                        top10List.Add(query.SingleOrDefault());
                    }
                }

                var temp = top10List.OrderByDescending(r => r.TotalScore).ToList();

                int ctr = 1;

                listView8.Items.Clear();

                temp.ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());

                    lvi.SubItems.Add(item.contestantNo);

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView8.Items.Add(lvi);

                    ctr++;
                });
            }
        }

        private void TopTenScoring_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
