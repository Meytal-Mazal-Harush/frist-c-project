using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class Board
    {
        public int BoardSize { get; set; }
        public BasicCard [] card;
        public Board(int BoardSize, List<BasicCard> c)
        {
            card = new BasicCard[BoardSize];
            Random random = new Random();
            for (int i = 0; i < BoardSize; i++)
            {

                int randomNumber = random.Next(0, BoardSize);
                while (card[randomNumber] != null)
                {
                    randomNumber = random.Next(0, BoardSize);
                }

                card[randomNumber] = c[i];
            }
        }
        public void initialization( List <BasicCard> c)
        { 
            Random random = new Random();
            for (int i = 0; i < c.Count(); i++)
            {
                
                int randomNumber = random.Next(0, BoardSize);
                while (card[i] == null)
                { 
                     randomNumber = random.Next(0, BoardSize);
                }

                card[randomNumber] = c[i];
            }
           

        }
        public void BoardDrew()
        {
            int i = 0;
            for (int j = 0; j <4; j++)
            {
                for (int k = 0; k <4; k++)
                {
                    if (card[i] != null)
                        card[i].Draw();
                    else
                        Console.Write("[ ]");
                    i++;
                }
                Console.WriteLine();
            }
        }

        public bool CardLocation(int userNum)
        {
            if (userNum > 17)
                return false;
            return true;

        }


        public bool IsACardInTheGame()
        {
           
            foreach (BasicCard c in card)
            {
                if (card != null)
                    return true;
            }
            return false;
        }

    }
}
