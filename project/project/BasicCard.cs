using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal abstract class BasicCard
    {
        public bool ISovert { get; set; }
        public bool Isfitst { get; set; }

        public override bool Equals(object? obj)
        {

            BasicCard other = obj as BasicCard;//המרתי את מה שקיבלתי לכרטיס
            if (other == null)// אם הצלחת להמיר אז:
            {
                return false;//אם שתהים הפוכים וגם אחד ראשון ואחד שני
            }
            return this.ISovert == other.ISovert && this.Isfitst != other.Isfitst;//אם לא הצלחת להמיר ( כי אולי שלחו לי אוביקט מסוג בן אדם) אז תחזיר פולס
        }

        public abstract bool CheckMatd(BasicCard other);
        

        public virtual void Draw(string? s=null)
        {
            Console.Write("[");
            if (this.ISovert) 
            {
                Console.Write(s);
                Console.Write("]");
            }
            else
            {
                Console.Write("?");
                Console.Write("]");
            }
            

        }
    }

}
