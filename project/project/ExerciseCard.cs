using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{//תרגיל
    internal class ExerciseCard : BasicCard
    {
        public int soultion { get; set; }
        public string regular { get; set; }

        public ExerciseCard()
        {
            
        }
        public ExerciseCard(int soultion , string regular)
        {
            this.soultion = soultion;
            this.regular = regular;
        }

        public override bool CheckMatd(BasicCard other)
        {
            ExerciseCard other1 = other as ExerciseCard;
            if (this.Equals(other) && this.regular == other1.regular && this.soultion == other1.soultion)
                return true;
            return false;
        }
        public override void Draw(string? s = null)
        {
            if (this.Isfitst)
            {
                base.Draw(regular);
            }
            else base.Draw(regular.ToString());
        }
    }
}
