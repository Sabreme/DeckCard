using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    /// <summary>
    /// A simple example of an Card that is an extension of the Card Class
    /// Unfortunately, this needs to be done for every card in the deck using this current implementation.
    /// </summary>
    class QueenHarts : Card
    {   
        /// <summary>
        /// THe constructor which we use to setup the class and define the name which is inherited from Card
        /// </summary>
        /// <param name="name"></param>
        public QueenHarts(string name)
        {
            Name = name;
        }

        public void SetValue(Value_Type value)
        {                       
            Value = value;
        }

        /// <summary>
        /// Implementing the Change of Suite which is an abstract method from Card
        /// This can be different for each card that is instantiated from the abstract card class
        /// </summary>
        /// <param name="suite"></param>
        public override void ChangeSuite(Suite_Type suite)
        {
            this.Suite = suite;
        }
    }
}
