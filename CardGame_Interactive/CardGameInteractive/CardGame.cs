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
    public class CardGame
    {
        /// <summary>
        /// represents the deck being used
        /// </summary>
        private CardDeck _cardDeck;

        /// <summary>
        /// score of the game
        /// </summary>
        private Score _score;

        /// <summary>
        /// Last Played User Card
        /// </summary>
        private Card _playerCard;

        /// <summary>
        /// Last card played by the house
        /// </summary>
        private Card _houseCard;
    }
}
