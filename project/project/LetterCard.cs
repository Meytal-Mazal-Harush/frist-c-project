using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{//אות
    internal class LetterCard : BasicCard
    {
        public char Letter { get; set; }

        public LetterCard()
        {


        }
        public LetterCard(char c)
        {
            this.Letter = c;
        }

        public override bool CheckMatd(BasicCard other)
        {
            //LetterCard other1 = other as LetterCard;
            //if (this.Equals(other) && this.Letter == other1.Letter)
            //    return true;
            //return false;
            return other is LetterCard otherCard && this.Letter == otherCard.Letter;

        }

        public override void Draw(string? s = null)
        {
            base.Draw(Letter.ToString());
        }
    }
}
