using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace project
{
    internal enum KindOfGame
    {
        exerciseCard, letterCard, symbolCard
    }
    internal class Play
    {
        private Board board;
        public Dictionary<KindOfGame, List<BasicCard>> cards;
        public List<PlayBasis> playes;
        public int Index { get; set; }
        public KindOfGame KindOfGame;



        public Play(Dictionary<KindOfGame, List<BasicCard>> cards)
        {
            PlayBasis playBasis = new UserPlayer();
            PlayBasis p;
            Console.WriteLine("do you went another playr? y=1, n=2");
            int result = int.Parse(Console.ReadLine());
            if (result == 1)
                p = new UserPlayer();
            else
                p = new ComputerPlayer();

            Console.WriteLine("choes what you wet to play ExerciseCard=1, SymbolCard= 2, LetterCard=3");
            int result2 = int.Parse(Console.ReadLine());

            if (result2 == 2)
            {
                this.KindOfGame = KindOfGame.symbolCard;
            }
            if (result2 == 1)
            {
                this.KindOfGame = KindOfGame.exerciseCard;
            }
            if (result2 == 3)
            {
                this.KindOfGame = KindOfGame.letterCard;
            }
            this.playes = new List<PlayBasis>();
            this.playes.Add(playBasis);
            this.playes.Add(p);
            this.cards = cards;
            Index = 0;
            board = new Board(16, cards[KindOfGame]);
        }
    
 
        public  bool FoundCouple(int index1, int index2)
        {
           
            if (!board.card[index1].CheckMatd(board.card[index2]))
                return false;
            playes[Index].Cards.Add(board.card[index1]);
            playes[Index].Cards.Add(board.card[index2]);
            board.card[index1] = null;
            board.card[index2] = null;
            playes[Index].MisPoint += 10;
            return true;

        }

        public void win()
        {
            if (playes[0].MisPoint> playes[1].MisPoint) { 
                Console.WriteLine(playes[0].YourName);
                playes[0].ShowCard();
            }
            else
                Console.WriteLine(playes[1].YourName);
            playes[1].ShowCard();
        }

        public void GameMov()
        {
            board.BoardDrew();
            while (this.board.IsACardInTheGame())
            {
           
                Console.WriteLine($"It's {playes[Index].YourName} turn");
                int c = playes[Index].Choice();

                while (board.card[c] == null)
                {
                    Console.WriteLine("this card is empty enter anoter index");
                    c = int.Parse(Console.ReadLine());
                }
                while (!board.CardLocation(c))
                {
                    Console.WriteLine("Invalid position, try again.");
                    c = playes[Index].Choice();
                }   

                board.card[c].ISovert = true;
                board.BoardDrew();
               
                int c2 = playes[Index].Choice();
                while (board.card[c2] == null)
                {
                    Console.WriteLine("this card is empty enter anoter index");
                    c2 = int.Parse(Console.ReadLine());
                }
                while (!board.CardLocation(c2))    
                {
                    Console.WriteLine("Invalid position, try again.");
                    c2 = playes[Index].Choice(); 
                }
                board.card[c2].ISovert = true;
                board.BoardDrew();
                

                bool b = FoundCouple(c,c2);
                bool flag = false;

                for (int i = 0; i < board.card.Length && !false; i++)
                {
                    if (board.card[i] != null)
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    Console.WriteLine("!!!!!!!!");
                    break;
                }

                if (!b) 
                { 
                board.card[c].ISovert = false;
                board.card[c2].ISovert = false;
                }
                if (Index == 0)
                    Index = 1;
                else
                    Index = 0;

                
                    
        
            }  
             win();
        }

    }
    
     
}
