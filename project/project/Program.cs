using System.ComponentModel;
using System.Drawing;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BasicCard> listSymbol = new List<BasicCard>();
            
            listSymbol.Add(new SymbolCard() { ISovert = false, Isfitst = true, Color = ConsoleColor.Magenta, Symbol = '!' });
            listSymbol.Add(new SymbolCard() { ISovert = false, Isfitst = false, Color = ConsoleColor.Magenta, Symbol = '!' });
            listSymbol.Add(new SymbolCard() { ISovert = false, Isfitst = true, Color = ConsoleColor.Blue, Symbol = '+' });
            listSymbol.Add(new SymbolCard() { ISovert = false, Isfitst = false, Color = ConsoleColor.Blue, Symbol = '+' });
            listSymbol.Add(new SymbolCard() { ISovert = false, Isfitst = true, Color = ConsoleColor.Yellow, Symbol = '#' });
            listSymbol.Add(new SymbolCard() { ISovert = false, Isfitst = false, Color = ConsoleColor.Yellow, Symbol = '#' });
            listSymbol.Add(new SymbolCard() { ISovert = false, Isfitst = true, Color = ConsoleColor.Red, Symbol = '^' });
            listSymbol.Add(new SymbolCard() { ISovert = false, Isfitst = false, Color = ConsoleColor.Red, Symbol = '^' });
            listSymbol.Add(new SymbolCard() { ISovert = false, Isfitst = true, Color = ConsoleColor.Green, Symbol = '@' });
            listSymbol.Add(new SymbolCard() { ISovert = false, Isfitst = false, Color = ConsoleColor.Green, Symbol = '@' });
            listSymbol.Add(new SymbolCard() { ISovert = false, Isfitst = true, Color = ConsoleColor.Cyan, Symbol = '%' });
            listSymbol.Add(new SymbolCard() { ISovert = false, Isfitst = true, Color = ConsoleColor.Cyan, Symbol = '%' });
            listSymbol.Add(new SymbolCard() { ISovert = false, Isfitst = false, Color = ConsoleColor.DarkYellow, Symbol = '~' });
            listSymbol.Add(new SymbolCard() { ISovert = false, Isfitst = true, Color = ConsoleColor.DarkYellow, Symbol = '~' });
            listSymbol.Add(new SymbolCard() { ISovert = false, Isfitst = false, Color = ConsoleColor.DarkBlue, Symbol = '?' });
            listSymbol.Add(new SymbolCard() { ISovert = false, Isfitst = false, Color = ConsoleColor.DarkBlue, Symbol = '?' });

            List<BasicCard> listLetter = new List<BasicCard>();
            listLetter.Add(new LetterCard() { ISovert = false, Isfitst = true, Letter = 'A' });
            listLetter.Add(new LetterCard() { ISovert = false, Isfitst = false, Letter = 'A' });
            listLetter.Add(new LetterCard() { ISovert = false, Isfitst = true, Letter = 'B' });
            listLetter.Add(new LetterCard() { ISovert = false, Isfitst = false, Letter = 'B' });
            listLetter.Add(new LetterCard() { ISovert = false, Isfitst = true, Letter = 'C' });
            listLetter.Add(new LetterCard() { ISovert = false, Isfitst = false, Letter = 'C' });
            listLetter.Add(new LetterCard() { ISovert = false, Isfitst = true, Letter = 'D' });
            listLetter.Add(new LetterCard() { ISovert = false, Isfitst = false, Letter = 'D' });
            listLetter.Add(new LetterCard() { ISovert = false, Isfitst = true, Letter = 'E' });
            listLetter.Add(new LetterCard() { ISovert = false, Isfitst = false, Letter = 'E' });
            listLetter.Add(new LetterCard() { ISovert = false, Isfitst = true, Letter = 'F' });
            listLetter.Add(new LetterCard() { ISovert = false, Isfitst = false, Letter = 'F' });
            listLetter.Add(new LetterCard() { ISovert = false, Isfitst = true, Letter = 'G' });
            listLetter.Add(new LetterCard() { ISovert = false, Isfitst = false, Letter = 'G' });
            listLetter.Add(new LetterCard() { ISovert = false, Isfitst = true, Letter = 'H' });
            listLetter.Add(new LetterCard() { ISovert = false, Isfitst = false, Letter = 'H' });

            List<BasicCard> listExercise = new List<BasicCard>();
            listExercise.Add(new ExerciseCard() { ISovert = false, Isfitst = true, soultion=6, regular = "3+3"});
            listExercise.Add(new ExerciseCard() { ISovert = false, Isfitst = false, soultion = 6, regular = "3+3" });
            listExercise.Add(new ExerciseCard() { ISovert = false, Isfitst = true, soultion = 10, regular = "5+5" });
            listExercise.Add(new ExerciseCard() { ISovert = false, Isfitst = false, soultion = 10, regular = "5+5" });
            listExercise.Add(new ExerciseCard() { ISovert = false, Isfitst = true, soultion = 8, regular = "5+3" });
            listExercise.Add(new ExerciseCard() { ISovert = false, Isfitst = false, soultion = 8, regular = "5+3" });
            listExercise.Add(new ExerciseCard() { ISovert = false, Isfitst = true, soultion = 3, regular = "1+2" });
            listExercise.Add(new ExerciseCard() { ISovert = false, Isfitst = false, soultion = 3, regular = "1+2" });
            listExercise.Add(new ExerciseCard() { ISovert = false, Isfitst = true, soultion = 7, regular = "5+2" });
            listExercise.Add(new ExerciseCard() { ISovert = false, Isfitst = false, soultion = 7, regular = "5+2" });
            listExercise.Add(new ExerciseCard() { ISovert = false, Isfitst = true, soultion = 9, regular = "5+4" });
            listExercise.Add(new ExerciseCard() { ISovert = false, Isfitst = false, soultion = 9, regular = "5+4" });
            listExercise.Add(new ExerciseCard() { ISovert = false, Isfitst = true, soultion = 13, regular = "5+8" });
            listExercise.Add(new ExerciseCard() { ISovert = false, Isfitst = false, soultion = 13, regular = "5+8" });
            listExercise.Add(new ExerciseCard() { ISovert = false, Isfitst = true, soultion = 4, regular = "2+2" });
            listExercise.Add(new ExerciseCard() { ISovert = false, Isfitst = false, soultion = 4, regular = "2+2" });
           
            foreach (var item  in listExercise)
            {
               item.Draw();
            }
            Console.WriteLine("");

            foreach (var item in listSymbol)
            {
                item.Draw();
            }
            Console.WriteLine("");

            foreach (var item in listLetter)
            {
                item.Draw();
            }
            Dictionary<KindOfGame, List<BasicCard>> cards = new Dictionary<KindOfGame, List<BasicCard>>();
            cards.Add(KindOfGame.letterCard, listLetter);
            cards.Add(KindOfGame.exerciseCard, listExercise);
            cards.Add(KindOfGame.symbolCard, listSymbol);
            Play game = new Play(cards);
            game.GameMov();
        }
    }
}


