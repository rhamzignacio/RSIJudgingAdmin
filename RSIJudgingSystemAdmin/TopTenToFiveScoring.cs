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
    public partial class TopTenToFiveScoring : Form
    {
        public TopTenToFiveScoring()
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

           GetAverage();
        }

        private void GetAverage()
        {
            listView8.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var query = from c in db.ContestantProfile
                            join j1 in db.Top5Judge1 on c.ContestantNo equals j1.CandidateNo
                            join j2 in db.Top5Judge2 on c.ContestantNo equals j2.CandidateNo
                            join j3 in db.Top5Judge3 on c.ContestantNo equals j3.CandidateNo
                            join j4 in db.Top5Judge4 on c.ContestantNo equals j4.CandidateNo
                            join j5 in db.Top5Judge1 on c.ContestantNo equals j5.CandidateNo
                            join j6 in db.Top5Judge1 on c.ContestantNo equals j6.CandidateNo
                            join j7 in db.Top5Judge1 on c.ContestantNo equals j7.CandidateNo
                            select new Top5ScoreModel
                            {
                                ContestantNo = c.ContestantNo,

                                Beauty1 = j1.Beauty,
                                Intelligence1 = j1.Intelligence,
                                Poise1 = j1.Poise,

                                Beauty2 = j2.Beauty,
                                Intelligence2 = j2.Intelligence,
                                Poise2 = j2.Poise,

                                Beauty3 = j3.Beauty,
                                Intelligence3 = j3.Intelligence,
                                Poise3 = j3.Poise,

                                Beauty4 = j4.Beauty,
                                Intelligence4 = j4.Intelligence,
                                Poise4 = j4.Poise,

                                Beauty5 = j5.Beauty,
                                Intelligence5 = j5.Intelligence,
                                Poise5 = j5.Poise,

                                Beauty6 = j6.Beauty,
                                Intelligence6 = j6.Intelligence,
                                Poise6 = j6.Poise,

                                Beauty7 = j7.Beauty,
                                Intelligence7 = j7.Intelligence,
                                Poise7 = j7.Poise,

                                TotalScore = ((j1.Beauty + j1.Intelligence + j1.Poise) +
                                (j2.Beauty + j2.Intelligence + j2.Poise) +
                                (j3.Beauty + j3.Intelligence + j3.Poise) +
                                (j4.Beauty + j4.Intelligence + j4.Poise) +
                                (j5.Beauty + j5.Intelligence + j5.Poise) +
                                (j6.Beauty + j6.Intelligence + j6.Poise) +
                                (j7.Beauty + j7.Intelligence + j7.Poise)) / 7
                            };

                var top10List = query.OrderByDescending(r => r.TotalScore).ToList();

                int ctr = 1;

                top10List.ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());

                    lvi.SubItems.Add(item.ContestantNo);

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView8.Items.Add(lvi);

                    ctr++;
                });
            }
        }
        private decimal? IfNull(decimal? _value)
        {
            if (_value == null)
                return 0;
            else
                return _value;
        }

        private void GetJudge1()
        {
            listView1.Items.Clear();

            using (var db = new RSIJudgingSystemEntities())
            {
                var candidates = from c in db.ContestantProfile
                                 join j in db.Top5Judge1 on c.ContestantNo equals j.CandidateNo
                                 select new Top5Model
                                 {
                                     ContestantNo = c.ContestantNo,
                                     Beauty = j.Beauty,
                                     Intelligence = j.Intelligence,
                                     Poise = j.Poise,
                                     TotalScore = j.Beauty + j.Intelligence + j.Poise
                                 };

                int ctr = 1;

                candidates.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());

                    lvi.SubItems.Add(item.ContestantNo);

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView1.Items.Add(lvi);

                    ctr++;
                });

                if (candidates.Count() == 10)
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
                var candidates = from c in db.ContestantProfile
                                 join j in db.Top5Judge2 on c.ContestantNo equals j.CandidateNo
                                 select new Top5Model
                                 {
                                     ContestantNo = c.ContestantNo,
                                     Beauty = j.Beauty,
                                     Intelligence = j.Intelligence,
                                     Poise = j.Poise,
                                     TotalScore = j.Beauty + j.Intelligence + j.Poise
                                 };

                int ctr = 1;

                candidates.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());

                    lvi.SubItems.Add(item.ContestantNo);

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView2.Items.Add(lvi);

                    ctr++;
                });

                if (candidates.Count() == 10)
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
                var candidates = from c in db.ContestantProfile
                                 join j in db.Top5Judge3 on c.ContestantNo equals j.CandidateNo
                                 select new Top5Model
                                 {
                                     ContestantNo = c.ContestantNo,
                                     Beauty = j.Beauty,
                                     Intelligence = j.Intelligence,
                                     Poise = j.Poise,
                                     TotalScore = j.Beauty + j.Intelligence + j.Poise
                                 };

                int ctr = 1;

                candidates.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());

                    lvi.SubItems.Add(item.ContestantNo);

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView3.Items.Add(lvi);

                    ctr++;
                });

                if (candidates.Count() == 10)
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
                var candidates = from c in db.ContestantProfile
                                 join j in db.Top5Judge4 on c.ContestantNo equals j.CandidateNo
                                 select new Top5Model
                                 {
                                     ContestantNo = c.ContestantNo,
                                     Beauty = j.Beauty,
                                     Intelligence = j.Intelligence,
                                     Poise = j.Poise,
                                     TotalScore = j.Beauty + j.Intelligence + j.Poise
                                 };

                int ctr = 1;

                candidates.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());

                    lvi.SubItems.Add(item.ContestantNo);

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView4.Items.Add(lvi);

                    ctr++;
                });

                if (candidates.Count() == 10)
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
                var candidates = from c in db.ContestantProfile
                                 join j in db.Top5Judge5 on c.ContestantNo equals j.CandidateNo
                                 select new Top5Model
                                 {
                                     ContestantNo = c.ContestantNo,
                                     Beauty = j.Beauty,
                                     Intelligence = j.Intelligence,
                                     Poise = j.Poise,
                                     TotalScore = j.Beauty + j.Intelligence + j.Poise
                                 };

                int ctr = 1;

                candidates.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());

                    lvi.SubItems.Add(item.ContestantNo);

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView5.Items.Add(lvi);

                    ctr++;
                });

                if (candidates.Count() == 10)
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
                var candidates = from c in db.ContestantProfile
                                 join j in db.Top5Judge6 on c.ContestantNo equals j.CandidateNo
                                 select new Top5Model
                                 {
                                     ContestantNo = c.ContestantNo,
                                     Beauty = j.Beauty,
                                     Intelligence = j.Intelligence,
                                     Poise = j.Poise,
                                     TotalScore = j.Beauty + j.Intelligence + j.Poise
                                 };

                int ctr = 1;

                candidates.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());

                    lvi.SubItems.Add(item.ContestantNo);

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView6.Items.Add(lvi);

                    ctr++;
                });

                if (candidates.Count() == 10)
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
                var candidates = from c in db.ContestantProfile
                                 join j in db.Top5Judge7 on c.ContestantNo equals j.CandidateNo
                                 select new Top5Model
                                 {
                                     ContestantNo = c.ContestantNo,
                                     Beauty = j.Beauty,
                                     Intelligence = j.Intelligence,
                                     Poise = j.Poise,
                                     TotalScore = j.Beauty + j.Intelligence + j.Poise
                                 };

                int ctr = 1;

                candidates.AsQueryable().OrderByDescending(r => r.TotalScore).ToList().ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(ctr.ToString());

                    lvi.SubItems.Add(item.ContestantNo);

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalScore));

                    listView7.Items.Add(lvi);

                    ctr++;
                });

                if (candidates.Count() == 10)
                    lblJ7.ForeColor = Color.Green;
                else
                    lblJ7.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Top5PrintReport form = new Top5PrintReport();

            form.Show();
        }
    }
}
