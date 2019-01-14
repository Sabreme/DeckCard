using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    /// <summary>
    /// This is a quick imnplementaiton done in 1 hour trying to showcase my interpretation of abstract classes and polymorphism
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// This is a list of 2 cards which are created and instantiated in the Main method.
        /// </summary>
        public static List<Card> TwoPair = new List<Card>();

        static void Main(string[] args)
        {           
            ///We create the Queen of Hearts which inherits from the Card Class
            QueenHarts Queen_Of_Hearts = new QueenHarts("Queen of Hearts");
            Queen_Of_Hearts.ChangeSuite(Card.Suite_Type.Hearts);
            Queen_Of_Hearts.SetValue(Card.Value_Type.queen);

            /// Adding the above card to the Linked List.
            TwoPair.Add(Queen_Of_Hearts);

            QueenSpades Queen_Of_Spades = new QueenSpades("Queen of Spades");
            Queen_Of_Spades.ChangeSuite(Card.Suite_Type.Spades);
            Queen_Of_Spades.SetValue(Card.Value_Type.queen);

            TwoPair.Add(Queen_Of_Spades);        

            /// Here go to through each Card in the list and use the parent cards PrintCard method to print the details for each card.
            /// 
            foreach (Card card in TwoPair)
            {
                card.PrintCard();
            }

            /// Console Output should like like below
            ////------------------------------------------------------
            /// Card Queen of Hearts is a queen of Hearts which is red
            /// Card Queen of Spades is a queen of Spades which is black
            Console.ReadKey();

        }
    }
}
