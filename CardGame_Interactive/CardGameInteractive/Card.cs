using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameInteractive
{
    /// <summary>
    /// 
    /// </summary>
    public class Card
    {
        /// <summary>
        /// value of the playing card
        /// </summary>
        private byte _value;

        /// <summary>
        /// suit of the card
        /// </summary>
        private CardSuit _suit;

        public Card(byte value, CardSuit suit)
        {
            _value = value;
            _suit = suit;
        }
    }
}
