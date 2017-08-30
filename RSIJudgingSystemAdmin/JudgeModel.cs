using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSIJudgingSystemAdmin
{
    class JudgeModel
    {
       
    }

    public class Top10Model
    {
        public string ContestantNo { get; set; }
        public decimal? PanelInterview { get; set; }
        public decimal? beauty { get; set; }
        public decimal? intelligence { get; set; }
        public decimal? delivery { get; set; }
        public decimal? TotalScore
        {
            get
            {
                return ((PanelInterview / 100) * 50) + beauty + intelligence + delivery;
            }
            set
            {
                
            }
        }
    }
}
