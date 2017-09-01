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
        public decimal? TotalScore { get; set; }
    }

    public class RankingModel
    {
        public string ContestantNo { get; set; }
        public decimal? Personality { get; set; }
        public decimal? WIT { get; set; }
        public decimal? TotalScore { get; set; }
    }

    public class Top5Model
    {
        public string ContestantNo { get; set; }
        public decimal? Beauty { get; set; }
        public decimal? Intelligence { get; set; }
        public decimal? Poise { get; set; }
        public decimal? TotalScore { get; set; }
    }

    public class Top5ScoreModel
    {
        public string ContestantNo { get; set; }

        public decimal? Total
        {
            get
            {
                return (Beauty1 + Intelligence1 + Poise1 +
                    Beauty2 + Intelligence2 + Poise2 +
                    Beauty3 + Intelligence3 + Poise3 +
                    Beauty4 + Intelligence4 + Poise4 +
                    Beauty5 + Intelligence5 + Poise5 +
                    Beauty6 + Intelligence6 + Poise6 +
                    Beauty7 + Intelligence7 + Poise7) / 7;
            }

        }
        private decimal? _beauty1;
        public decimal? Beauty1
        {
            get
            {
                if (_beauty1 == null)
                    return 0;
                else
                    return _beauty1;
            }
            set { _beauty1 = value; }
        }

        private decimal? _intelligence1;
        public decimal? Intelligence1
        {
            get
            {
                if (_intelligence1 == null)
                    return 0;
                else
                    return _intelligence1;
            }
            set { _intelligence1 = value; }
        }

        private decimal? _poise1;
        public decimal? Poise1
        {
            get
            {
                if (_poise1 == null)
                    return 0;
                else
                    return _poise1;
            }
            set { _poise1 = value; }
        }

        //Judge No 2
        private decimal? _beauty2;
        public decimal? Beauty2
        {
            get
            {
                if (_beauty2 == null)
                    return 0;
                else
                    return _beauty2;
            }
            set { _beauty2 = value; }
        }

        private decimal? _intelligence2;
        public decimal? Intelligence2
        {
            get
            {
                if (_intelligence2 == null)
                    return 0;
                else
                    return _intelligence2;
            }
            set { _intelligence2 = value; }
        }

        private decimal? _poise2;
        public decimal? Poise2
        {
            get
            {
                if (_poise2 == null)
                    return 0;
                else
                    return _poise2;
            }
            set { _poise2 = value; }
        }

        //Judge No 3
        private decimal? _beauty3;
        public decimal? Beauty3
        {
            get
            {
                if (_beauty3 == null)
                    return 0;
                else
                    return _beauty3;
            }
            set { _beauty3 = value; }
        }

        private decimal? _intelligence3;
        public decimal? Intelligence3
        {
            get
            {
                if (_intelligence3 == null)
                    return 0;
                else
                    return _intelligence3;
            }
            set { _intelligence3 = value; }
        }

        private decimal? _poise3;
        public decimal? Poise3
        {
            get
            {
                if (_poise3 == null)
                    return 0;
                else
                    return _poise3;
            }
            set { _poise3 = value; }
        }

        //Judge No 4
        private decimal? _beauty4;
        public decimal? Beauty4
        {
            get
            {
                if (_beauty4 == null)
                    return 0;
                else
                    return _beauty4;
            }
            set { _beauty4 = value; }
        }

        private decimal? _intelligence4;
        public decimal? Intelligence4
        {
            get
            {
                if (_intelligence4 == null)
                    return 0;
                else
                    return _intelligence4;
            }
            set { _intelligence4 = value; }
        }

        private decimal? _poise4;
        public decimal? Poise4
        {
            get
            {
                if (_poise4 == null)
                    return 0;
                else
                    return _poise4;
            }
            set { _poise4 = value; }
        }

        //Judge No 5
        private decimal? _beauty5;
        public decimal? Beauty5
        {
            get
            {
                if (_beauty5 == null)
                    return 0;
                else
                    return _beauty5;
            }
            set { _beauty5 = value; }
        }

        private decimal? _intelligence5;
        public decimal? Intelligence5
        {
            get
            {
                if (_intelligence5 == null)
                    return 0;
                else
                    return _intelligence5;
            }
            set { _intelligence5 = value; }
        }

        private decimal? _poise5;
        public decimal? Poise5
        {
            get
            {
                if (_poise5 == null)
                    return 0;
                else
                    return _poise5;
            }
            set { _poise5 = value; }
        }

        //Judge No 6
        private decimal? _beauty6;
        public decimal? Beauty6
        {
            get
            {
                if (_beauty6 == null)
                    return 0;
                else
                    return _beauty6;
            }
            set { _beauty6 = value; }
        }

        private decimal? _intelligence6;
        public decimal? Intelligence6
        {
            get
            {
                if (_intelligence6 == null)
                    return 0;
                else
                    return _intelligence6;
            }
            set { _intelligence6 = value; }
        }

        private decimal? _poise6;
        public decimal? Poise6
        {
            get
            {
                if (_poise6 == null)
                    return 0;
                else
                    return _poise6;
            }
            set { _poise6 = value; }
        }

        //Judge No 7
        private decimal? _beauty7;
        public decimal? Beauty7
        {
            get
            {
                if (_beauty7 == null)
                    return 0;
                else
                    return _beauty7;
            }
            set { _beauty7 = value; }
        }

        private decimal? _intelligence7;
        public decimal? Intelligence7
        {
            get
            {
                if (_intelligence7 == null)
                    return 0;
                else
                    return _intelligence7;
            }
            set { _intelligence7 = value; }
        }

        private decimal? _poise7;
        public decimal? Poise7
        {
            get
            {
                if (_poise7 == null)
                    return 0;
                else
                    return _poise7;
            }
            set { _poise7 = value; }
        }

        public decimal? TotalScore { get; set; }
    }

    public class RankingScoreModel
    {

        public string ContestantNo { get; set; }
        public decimal PanelInterview { get; set; }

        public decimal? TotalScore { get; set; }
        //JudgeNo1
        private decimal? _personality1;
        public decimal? Personality1
        {
            get
            {
                if (_personality1 == null)
                    return 0;
                else
                    return _personality1;
            }
            set
            {
                _personality1 = value;
            }
        }
        private decimal? _wit1;
        public decimal? WIT1
        {
            get
            {
                if (_wit1 == null)
                    return 0;
                else
                    return _wit1;
            }
            set
            {
                _wit1 = value;
            }
        }
        public decimal? Total1
        {
            get
            {
                return Personality1 + WIT1;
            }
        }

        //JudgeNo2
        private decimal? _personality2;
        public decimal? Personality2
        {
            get
            {
                if (_personality2 == null)
                    return 0;
                else
                    return _personality2;
            }
            set
            {
                _personality2 = value;
            }
        }
        private decimal? _wit2;
        public decimal? WIT2
        {
            get
            {
                if (_wit2 == null)
                    return 0;
                else
                    return _wit2;
            }
            set
            {
                _wit2 = value;
            }
        }
        public decimal? Total2
        {
            get
            {
                return Personality2 + WIT2;
            }
        }

        //JudgeNo3
        private decimal? _personality3;
        public decimal? Personality3
        {
            get
            {
                if (_personality3 == null)
                    return 0;
                else
                    return _personality3;
            }
            set
            {
                _personality3 = value;
            }
        }
        private decimal? _wit3;
        public decimal? WIT3
        {
            get
            {
                if (_wit3 == null)
                    return 0;
                else
                    return _wit3;
            }
            set
            {
                _wit3 = value;
            }
        }
        public decimal? Total3
        {
            get
            {
                return Personality3 + WIT3;
            }
        }

        //JudgeNo4
        private decimal? _personality4;
        public decimal? Personality4
        {
            get
            {
                if (_personality4 == null)
                    return 0;
                else
                    return _personality4;
            }
            set
            {
                _personality4 = value;
            }
        }
        private decimal? _wit4;
        public decimal? WIT4
        {
            get
            {
                if (_wit4 == null)
                    return 0;
                else
                    return _wit4;
            }
            set
            {
                _wit4 = value;
            }
        }
        public decimal? Total4
        {
            get
            {
                return Personality4 + WIT4;
            }
        }

        //JudgeNo5
        private decimal? _personality5;
        public decimal? Personality5
        {
            get
            {
                if (_personality5 == null)
                    return 0;
                else
                    return _personality5;
            }
            set
            {
                _personality5 = value;
            }
        }
        private decimal? _wit5;
        public decimal? WIT5
        {
            get
            {
                if (_wit5 == null)
                    return 0;
                else
                    return _wit5;
            }
            set
            {
                _wit5 = value;
            }
        }
        public decimal? Total5
        {
            get
            {
                return Personality5 + WIT5;
            }
        }

        //JudgeNo6
        private decimal? _personality6;
        public decimal? Personality6
        {
            get
            {
                if (_personality6 == null)
                    return 0;
                else
                    return _personality6;
            }
            set
            {
                _personality6 = value;
            }
        }
        private decimal? _wit6;
        public decimal? WIT6
        {
            get
            {
                if (_wit6 == null)
                    return 0;
                else
                    return _wit6;
            }
            set
            {
                _wit6 = value;
            }
        }
        public decimal? Total6
        {
            get
            {
                return Personality6 + WIT6;
            }
        }

        //JudgeNo7
        private decimal? _personality7;
        public decimal? Personality7
        {
            get
            {
                if (_personality7 == null)
                    return 0;
                else
                    return _personality7;
            }
            set
            {
                _personality7 = value;
            }
        }
        private decimal? _wit7;
        public decimal? WIT7
        {
            get
            {
                if (_wit7 == null)
                    return 0;
                else
                    return _wit7;
            }
            set
            {
                _wit7 = value;
            }
        }
        public decimal? Total7
        {
            get
            {
                return Personality7 + WIT7;
            }
        }

    }

    public class Top10ScoreModel
    {
        public string contestantNo { get; set; }
        public decimal panelInterview { get; set; }
        public decimal PIScore
        {
            get
            {
                return (panelInterview / 100) * 50;
            }
        }

        //JudgeNo1
        private decimal? _beauty1;
        public decimal? beauty1
        {
            get
            {
                if (_beauty1 == null)
                    return 0;
                else
                    return _beauty1;
            }
            set
            {
                _beauty1 = value;
            }
        }
        private decimal? _intelligence1;
        public decimal? intelligence1
        {
            get
            { 
                if (_intelligence1 == null)
                    return 0;
                else
                    return _intelligence1;
            }
            set
            {
                _intelligence1 = value;
            }
        }
        private decimal? _delivery1;
        public decimal? delivery1
        {
            get
            { 
                if (_delivery1 == null)
                    return 0;
                else
                    return _delivery1;
            }
            set
            {
                _delivery1 = value;
            }
        }
        public decimal? total1
        {
            get
            {
                return beauty1 + intelligence1 + delivery1 + PIScore;
            }
        }

        //JudgeNo2
        private decimal? _beauty2;
        public decimal? beauty2
        {
            get
            {
                if (_beauty2 == null)
                    return 0;
                else
                    return _beauty2;
            }
            set
            {
                _beauty2 = value;
            }
        }
        private decimal? _intelligence2;
        public decimal? intelligence2
        {
            get
            {
                if (_intelligence2 == null)
                    return 0;
                else
                    return _intelligence2;
            }
            set
            {
                _intelligence2 = value;
            }
        }
        private decimal? _delivery2;
        public decimal? delivery2
        {
            get
            {
                if (_delivery2 == null)
                    return 0;
                else
                    return _delivery2;
            }
            set
            {
                _delivery2 = value;
            }
        }
        public decimal? total2
        {
            get
            {
                return beauty2 + intelligence2 + delivery2 + PIScore;
            }
        }

        //JudgeNo3
        private decimal? _beauty3;
        public decimal? beauty3
        {
            get
            {
                if (_beauty3 == null)
                    return 0;
                else
                    return _beauty3;
            }
            set
            {
                _beauty3 = value;
            }
        }
        private decimal? _intelligence3;
        public decimal? intelligence3
        {
            get
            {
                if (_intelligence3 == null)
                    return 0;
                else
                    return _intelligence3;
            }
            set
            {
                _intelligence3 = value;
            }
        }
        private decimal? _delivery3;
        public decimal? delivery3
        {
            get
            {
                if (_delivery3 == null)
                    return 0;
                else
                    return _delivery3;
            }
            set
            {
                _delivery3 = value;
            }
        }
        public decimal? total3
        {
            get
            {
                return beauty3 + intelligence3 + delivery3 + PIScore;
            }
        }

        //JudgeNo4 
        private decimal? _beauty4;
        public decimal? beauty4
        {
            get
            {
                if (_beauty4 == null)
                    return 0;
                else
                    return _beauty4;
            }
            set
            {
                _beauty4 = value;
            }
        }
        private decimal? _intelligence4;
        public decimal? intelligence4
        {
            get
            {
                if (_intelligence4 == null)
                    return 0;
                else
                    return _intelligence4;
            }
            set
            {
                _intelligence4 = value;
            }
        }
        private decimal? _delivery4;
        public decimal? delivery4
        {
            get
            {
                if (_delivery4 == null)
                    return 0;
                else
                    return _delivery4;
            }
            set
            {
                _delivery4 = value;
            }
        }
        public decimal? total4
        {
            get
            {
                return beauty4 + intelligence4 + delivery4 + PIScore;
            }
        }

        //JudgeNo5
        private decimal? _beauty5;
        public decimal? beauty5
        {
            get
            {
                if (_beauty5 == null)
                    return 0;
                else
                    return _beauty5;
            }
            set
            {
                _beauty5 = value;
            }
        }
        private decimal? _intelligence5;
        public decimal? intelligence5
        {
            get
            {
                if (_intelligence5 == null)
                    return 0;
                else
                    return _intelligence5;
            }
            set
            {
                _intelligence5 = value;
            }
        }
        private decimal? _delivery5;
        public decimal? delivery5
        {
            get
            {
                if (_delivery5 == null)
                    return 0;
                else
                    return _delivery5;
            }
            set
            {
                _delivery5 = value;
            }
        }
        public decimal? total5
        {
            get
            {
                return beauty5 + intelligence5 + delivery5 + PIScore;
            }
        }

        //JudgeNo6
        private decimal? _beauty6;
        public decimal? beauty6
        {
            get
            {
                if (_beauty6 == null)
                    return 0;
                else
                    return _beauty6;
            }
            set
            {
                _beauty6 = value;
            }
        }
        private decimal? _intelligence6;
        public decimal? intelligence6
        {
            get
            {
                if (_intelligence6 == null)
                    return 0;
                else
                    return _intelligence6;
            }
            set
            {
                _intelligence6 = value;
            }
        }
        private decimal? _delivery6;
        public decimal? delivery6
        {
            get
            {
                if (_delivery6 == null)
                    return 0;
                else
                    return _delivery6;
            }
            set
            {
                _delivery6 = value;
            }
        }
        public decimal? total6
        {
            get
            {
                return beauty6 + intelligence6 + delivery6 + PIScore;
            }
        }

        //JudgeNo7
        private decimal? _beauty7;
        public decimal? beauty7
        {
            get
            {
                if (_beauty7 == null)
                    return 0;
                else
                    return _beauty7;
            }
            set
            {
                _beauty7 = value;
            }
        }
        private decimal? _intelligence7;
        public decimal? intelligence7
        {
            get
            {
                if (_intelligence7 == null)
                    return 0;
                else
                    return _intelligence7;
            }
            set
            {
                _intelligence7 = value;
            }
        }
        private decimal? _delivery7;
        public decimal? delivery7
        {
            get
            {
                if (_delivery7 == null)
                    return 0;
                else
                    return _delivery7;
            }
            set
            {
                _delivery7 = value;
            }
        }
        public decimal? total7
        {
            get
            {
                return beauty7 + intelligence7 + delivery7 + PIScore;
            }
        }

        public decimal? TotalScore
        {
            get
            {
                return (total1 + total2 + total3 + total4 + total5 + total6 + total7) / 7;
            }
        }
    }
}
