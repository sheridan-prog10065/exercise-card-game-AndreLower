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
        
        /// <summary>
        /// CardGame Class Constructor
        /// </summary>
        //Here, The Initial Values are filled
        public CardGame()
        {
            _cardDeck = new CardDeck();
            _score = new Score();
            _playerCard = null;
            _houseCard = null;
        }

        public void Play()
        {
            //todo: implement play
        }
        /// <summary>
        /// Play a round of the game
        /// </summary>
        /// <returns>
        ///     +1 USer Won Round
        ///     0 Tie
        ///     -1 House Won the Round
        /// </returns>
        private sbyte PlayRound()
        {
            //todo: Implement play round
            return 0;
        }

        private void DealCards()
        {

        }

        private void SwitchCards()
        {

        }

        private byte DetermineCardRank()
        {
            //TODO: Implement
            return 0;
        }

        private void ShowRoundResult()
        {

        }

        private void ShowGameOver()
        {

        }


    }
}
