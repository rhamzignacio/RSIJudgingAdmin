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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTop10Scores_Click(object sender, EventArgs e)
        {
            TopTenScoring form = new TopTenScoring();

            form.Show();
        }

        private void btnTop5Scores_Click(object sender, EventArgs e)
        {
            TopFiveScoring form = new TopFiveScoring();

            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TopTenToFiveScoring form = new TopTenToFiveScoring();

            form.Show();
        }
    }
}
