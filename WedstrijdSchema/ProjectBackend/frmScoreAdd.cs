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

        public frmScoreAdd(string thuis, string away, List<Game> games, login user, List<string> landen)
        {
            InitializeComponent();
            this.Home = thuis;
            this.Away = away;
            label1.Text = thuis;
            label2.Text = away;
            this.gamesList = games;
            this.user = user;
            this.Landen = landen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidData()) 
            {
                int scoreAway = Convert.ToInt32(textBox2.Text);
                int scoreHome = Convert.ToInt32(textBox1.Text);
                Game game = new Game(Home, Away,scoreHome, scoreAway);
                gamesList = new List<Game>();
                gamesList.Add(game);
                this.Close();

            }


        }

        private bool IsValidData()
        {
            return Validator.IsInt32(textBox1) && Validator.IsInt32(textBox2);
        }

        private void frmScoreAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome frmHome = new frmHome(user, Landen, gamesList);
            frmHome.Show();
            frmHome.FillTextBoxen();
        }
    }
}
