using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class UserPlayer : PlayBasis
    {
        public override string? YourName { get; set; }

        public UserPlayer()
        {
            Name();  
        }

        public override void Name()
        {
            Console.WriteLine("enter your name");
            this.YourName = Console.ReadLine();

        }

        public override int Choice()
        {
            Console.WriteLine("enter mis card");
           int choice = int.Parse(Console.ReadLine());
            //while (Cards[choice] == null)
            //{
            //    Console.WriteLine("this card is empty enter anoter index");
            //    Console.WriteLine("enter mis card");
            //    choice = int.Parse(Console.ReadLine());
            //}
            return choice;
        }


    }
}
