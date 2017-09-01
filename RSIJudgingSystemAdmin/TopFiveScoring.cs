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
    public partial class TopFiveScoring : Form
    {
        public TopFiveScoring()
        {
            InitializeComponent();

            timer1 = new Timer();

            timer1.Tick += new EventHandler(timer1_Tick);

            timer1.Interval = 1000;

            timer1.Start();
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

            GetScoreAverage();
        }

        private void GetJudge1()
        {
            listView1.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var contestants = from j in db.RankingJudge1
                                  select new RankingModel
                                  {
                                      ContestantNo = j.ContestantNo,
                                      Personality = j.Personality,
                                      WIT = j.Wit,
                                      TotalScore = j.Personality + j.Wit
                                  };

                int ctr = 1;

                contestants.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());

                    lvi.SubItems.Add(item.ContestantNo);

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView1.Items.Add(lvi);

                    ctr++;
                });

                if (contestants.Count() == 5)
                    lblJ1.ForeColor = Color.Green;
                else
                    lblJ1.ForeColor = Color.Red;
            }
        }

        private void GetJudge2()
        {
            listView2.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var contestants = from j in db.RankingJudge2
                                  select new RankingModel
                                  {
                                      ContestantNo = j.ContestantNo,
                                      Personality = j.Personality,
                                      WIT = j.Wit,
                                      TotalScore = j.Personality + j.Wit
                                  };

                int ctr = 1;

                contestants.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());

                    lvi.SubItems.Add(item.ContestantNo);

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView2.Items.Add(lvi);

                    ctr++;
                });

                if (contestants.Count() == 5)
                    lblJ2.ForeColor = Color.Green;
                else
                    lblJ2.ForeColor = Color.Red;
            }
        }

        private void GetJudge3()
        {
            listView3.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var contestants = from j in db.RankingJudge3
                                  select new RankingModel
                                  {
                                      ContestantNo = j.ContestantNo,
                                      Personality = j.Personality,
                                      WIT = j.Wit,
                                      TotalScore = j.Personality + j.Wit
                                  };

                int ctr = 1;

                contestants.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());

                    lvi.SubItems.Add(item.ContestantNo);

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView3.Items.Add(lvi);

                    ctr++;
                });

                if (contestants.Count() == 5)
                    lblJ3.ForeColor = Color.Green;
                else
                    lblJ3.ForeColor = Color.Red;
            }
        }

        private void GetJudge4()
        {
            listView4.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var contestants = from j in db.RankingJudge4
                                  select new RankingModel
                                  {
                                      ContestantNo = j.ContestantNo,
                                      Personality = j.Personality,
                                      WIT = j.Wit,
                                      TotalScore = j.Personality + j.Wit
                                  };

                int ctr = 1;

                contestants.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());

                    lvi.SubItems.Add(item.ContestantNo);

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView4.Items.Add(lvi);

                    ctr++;
                });

                if (contestants.Count() == 5)
                    lblJ4.ForeColor = Color.Green;
                else
                    lblJ4.ForeColor = Color.Red;
            }
        }

        private void GetJudge5()
        {
            listView5.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var contestants = from j in db.RankingJudge5
                                  select new RankingModel
                                  {
                                      ContestantNo = j.ContestantNo,
                                      Personality = j.Personality,
                                      WIT = j.Wit,
                                      TotalScore = j.Personality + j.Wit
                                  };

                int ctr = 1;

                contestants.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());

                    lvi.SubItems.Add(item.ContestantNo);

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView5.Items.Add(lvi);

                    ctr++;
                });

                if (contestants.Count() == 5)
                    lblJ5.ForeColor = Color.Green;
                else
                    lblJ5.ForeColor = Color.Red;
            }
        }

        private void GetJudge6()
        {
            listView6.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var contestants = from j in db.RankingJudge6
                                  select new RankingModel
                                  {
                                      ContestantNo = j.ContestantNo,
                                      Personality = j.Personality,
                                      WIT = j.Wit,
                                      TotalScore = j.Personality + j.Wit
                                  };

                int ctr = 1;

                contestants.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());

                    lvi.SubItems.Add(item.ContestantNo);

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView6.Items.Add(lvi);

                    ctr++;
                });

                if (contestants.Count() == 5)
                    lblJ6.ForeColor = Color.Green;
                else
                    lblJ6.ForeColor = Color.Red;
            }
        }

        private void GetJudge7()
        {
            listView7.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var contestants = from j in db.RankingJudge7
                                  select new RankingModel
                                  {
                                      ContestantNo = j.ContestantNo,
                                      Personality = j.Personality,
                                      WIT = j.Wit,
                                      TotalScore = j.Personality + j.Wit
                                  };

                int ctr = 1;

                contestants.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());

                    lvi.SubItems.Add(item.ContestantNo);

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView7.Items.Add(lvi);

                    ctr++;
                });

                if (contestants.Count() == 5)
                    lblJ7.ForeColor = Color.Green;
                else
                    lblJ7.ForeColor = Color.Red;
            }
        }

        private void GetScoreAverage()
        {
            listView8.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var query = from c in db.ContestantProfile
                            join fJ1 in db.RankingJudge1 on c.ContestantNo equals fJ1.ContestantNo 
                            join fJ2 in db.RankingJudge2 on c.ContestantNo equals fJ2.ContestantNo 
                            join fJ3 in db.RankingJudge3 on c.ContestantNo equals fJ3.ContestantNo 
                            join fJ4 in db.RankingJudge4 on c.ContestantNo equals fJ4.ContestantNo 
                            join fJ5 in db.RankingJudge5 on c.ContestantNo equals fJ5.ContestantNo 
                            join fJ6 in db.RankingJudge6 on c.ContestantNo equals fJ6.ContestantNo
                            join fJ7 in db.RankingJudge7 on c.ContestantNo equals fJ7.ContestantNo 
                            select new RankingScoreModel
                            {
                                ContestantNo = c.ContestantNo,

                                Personality1 = fJ1.Personality,
                                WIT1 = fJ1.Wit,

                                Personality2 = fJ2.Personality,
                                WIT2 = fJ2.Wit,

                                Personality3 = fJ3.Personality,
                                WIT3 = fJ3.Wit,

                                Personality4 = fJ4.Personality,
                                WIT4 = fJ4.Wit,

                                Personality5 = fJ5.Personality,
                                WIT5 = fJ5.Wit,

                                Personality6 = fJ6.Personality,
                                WIT6 = fJ6.Wit,

                                Personality7 = fJ7.Personality,
                                WIT7 = fJ7.Wit,

                                TotalScore = ((fJ1.Personality + fJ1.Wit) +
                                (fJ1.Personality + fJ2.Wit) +
                                (fJ3.Personality + fJ3.Wit) +
                                (fJ4.Personality + fJ4.Wit) +
                                (fJ5.Personality + fJ5.Wit) +
                                (fJ6.Personality + fJ6.Wit) +
                                (fJ7.Personality + fJ7.Wit)/7)
                            };

                var rankList = query.OrderByDescending(r => r.TotalScore).ToList();

                int x = 1;
                rankList.ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(x.ToString());

                    lvi.SubItems.Add(item.ContestantNo);

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView8.Items.Add(lvi);

                    x++;
                });
            }
        }

        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
