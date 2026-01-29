using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class ComputerPlayer : PlayBasis
    {
       public readonly string NameCamputer = "Camputer";
        public override int Choice()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 16);
            //while (Cards[randomNumber] == null)
            //{
            //    Console.WriteLine("this card is empty enter anoter index");
            //    randomNumber = random.Next(0, 18);
            //}
            return randomNumber;
        }
       
    }
}
