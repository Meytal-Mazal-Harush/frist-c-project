using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal abstract class PlayBasis
    {
        public int MisPoint { get; set; }
        public   List<BasicCard> Cards;
        public virtual string? YourName { get; set; }

        protected PlayBasis()
        {
            Cards = new List<BasicCard>();
        }

        public virtual void Name() { }
        public abstract int Choice();
        public void ShowCard() 
        {
            for (int i = 0; i < Cards.Count; i++) {
               Cards[i].Draw();
            }
        }


    }
}
