using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBackend
{
    public class Game
    {
        #region Velden
        private string countryhome;
        private string countryaway;
        private int scorehome;
        private int scoreaway;
        #endregion

        #region Properties

        /// <summary>
        /// Set/Get de score van de away team
        /// </summary>
        public int ScoreAway
        {
            get { return scoreaway; }
            set { scoreaway = value; }
        }

        /// <summary>
        /// Set/Get de score van de home team
        /// </summary>
        public int ScoreHome
        {
            get { return scorehome; }
            set { scorehome = value; }
        }

        /// <summary>
        /// Set/Get de naam van de away team
        /// </summary>
        public string CountryAway
        {
            get { return countryaway; }
            set { countryaway = value; }
        }

        /// <summary>
        /// Set/Get de naam van de home team
        /// </summary>
        public string CountryHome
        {
            get { return countryhome; }
            set { countryhome = value; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// Een lege constructor voor de class Game
        /// </summary>
        public Game()
        {

        }

        /// <summary>
        /// Volledige constructor voor de class game
        /// </summary>
        /// <param name="countryhome">de naam van de home team</param>
        /// <param name="countryaway">de naam van de away team</param>
        /// <param name="scorehome">de aantal punten van het home team</param>
        /// <param name="scoreaway">de aantal punten van het away team</param> 
        public Game(string countryhome, string countryaway, int scorehome, int scoreaway)
        {
            this.countryhome = countryhome;
            this.countryaway = countryaway;
            this.scorehome = scorehome;
            this.scoreaway = scoreaway;
        }

        #endregion

        #region Methodes

        #endregion
    }
}