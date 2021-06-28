using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBackend
{
    public partial class frmScoreAdd : Form
    {
        string Home;
        string Away;
        List<Game> gamesList;
        List<string> Landen;
        login user;

        public frmScoreAdd(string thuis, string away, List<Game> Matches, login user, List<string> landen)
        {
            InitializeComponent();
            this.Home = thuis;
            this.Away = away;
            this.gamesList = Matches;
            this.user = user;
            this.Landen = landen;

            label1.Text = thuis;
            label2.Text = away;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidData()) 
            {
                int scoreAway = Convert.ToInt32(textBox2.Text);
                int scoreHome = Convert.ToInt32(textBox1.Text);
                if (scoreAway < 0 || scoreHome < 0) { MessageBox.Show("Score kan niet onder de nul zijn", "out of bounds Error"); }
                else{
                    if (gamesList != null)
                    {
                        Game game = new Game(Home, Away, scoreHome, scoreAway);
                        gamesList.Add(game);
                    }
                    else
                    {
                        gamesList = new List<Game>();
                        Game game = new Game(Home, Away, scoreHome, scoreAway);
                        gamesList.Add(game);
                    }

                    frmHome frmHome = new frmHome(user, Landen, gamesList);
                    frmHome.Show();
                    frmHome.FillTextBoxen();

                    this.Hide();
                }
            }
        }

        /// <summary>
        /// checkt de textboxen of er een int getal in zit
        /// </summary>
        /// <returns>True or False</returns>
        private bool IsValidData()
        {
            return Validator.IsInt32(textBox1) && Validator.IsInt32(textBox2);
        }

        /// <summary>
        /// Voordat de form closed roep ik nog de home aan en show ik die
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmScoreAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome frmHome = new frmHome(user, Landen, gamesList);
                    frmHome.Show();
                    frmHome.FillTextBoxen();
        }
    }
}
