using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    /// <summary>
    /// Opted to make the Card Class as abstract because a card is just a blank card and in theory does not mean much on its own
    /// 
    /// Pros: When classes inherit from this Card class, only public access properties/methods are accessible
    /// 
    /// Con: Using this implementation, when we create a new card, we will create a new class which means there will be 52 classes for a complete deck
    /// </summary>
    abstract class Card
    {
        
        public string Name { get; set; }

       
        public Suite_Type Suite { get; set; }

        
        public Value_Type Value { get; set; }


        /// <summary>
        /// Opted to store values for Enums because it allows for readability and control
        /// I did not include the color into this because that is calculated later in the printout
        /// </summary>
        public enum Suite_Type { Diamond, Hearts, Spades, Clubs };

        /// <summary>
        /// Opted to store these also as enums because its a mixture of numbers and letters.
        /// We can use a list of strings, but let magic strings
        /// </summary>
        public enum Value_Type { ace, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king }


        /// <summary>
        /// This demonstrates the pulling of properties and methods into a single function to produce a result
        /// </summary>
        public virtual void PrintCard ()
        {
            Console.WriteLine($"Card {Name} is a {Value} of {Suite} which is {CardColor(Suite)}");
        }


        /// <summary>
        /// Protected because it does not need to be access by inherrited subclasses 
        /// If statements would indeed trim the code down quite significantly
        /// </summary>
        /// <param name="suite"></param>
        /// <returns></returns>
        protected string CardColor(Suite_Type suite)
        {
            string colour = "";
            switch (suite)
            {
                case Suite_Type.Diamond:
                case Suite_Type.Hearts:
                    colour =  "red";
                    break;
                case Suite_Type.Clubs:
                case Suite_Type.Spades:
                    colour =  "black";
                    break;
            }
            return colour;

        }

        /// <summary>
        /// Abstract method that MUST be implemented and can be overriden 
        /// </summary>
        /// <param name="suite"></param>
        public abstract void ChangeSuite(Suite_Type suite);
    }
}
