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
    public partial class frmHome : Form
    {
        login user;
        List<string> landen;
        List<Game> matches;

        //volgorde van de games die gespeeld moeten worden
        int[] test = {0,1,2,3,0,2,1,3,0,3,1,2};
        //wordt gebruikt voor de filltextbox methode
        int index = 0;
 

        public frmHome(login klant = null, List<string> landen = null, List<Game> games = null)
        {
            InitializeComponent();
            this.user = klant;
            this.landen = landen;
            this.matches = games;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            btnWelcomeUser.Text = user.Usernname;
        }

        private void landenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLanden frmLanden = new frmLanden(user);
            frmLanden.Show();
            this.Hide();
        }

        private void btnPlannen_Click(object sender, EventArgs e)
        {
            if (landen == null) { MessageBox.Show("er zijn nog geen matches en/of landen toegevoegd!"); }
            else if (landen.Count < 4) { MessageBox.Show("Er zijn geen 4 landen toegevoegd", "Index out of range"); }
            else { FillTextBoxen(); }
        }

     
        /// <summary>
        /// Algemene event voor de radio buttons die je dan doorsturen naar de addscore form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Geklikt(object sender, EventArgs e)
        {
          
            try
            {
                if (rbPot1.Checked)
                {
                    frmScoreAdd frmScoreAdd = new frmScoreAdd(txtR1T1.Text, txtR1T2.Text, matches, user, landen);
                    frmScoreAdd.Show();
                    this.Hide();
                }
                else if (rbPot2.Checked)
                {
                    frmScoreAdd frmScoreAdd = new frmScoreAdd(txtR1T3.Text, txtR1T4.Text, matches, user, landen);
                    frmScoreAdd.Show();
                    this.Hide();
                }
                else if (rbPot3.Checked)
                {
                    frmScoreAdd frmScoreAdd = new frmScoreAdd(txtR2T1.Text, txtR2T2.Text, matches, user, landen);
                    frmScoreAdd.Show();
                    this.Hide();
                }
                else if (rbPot4.Checked)
                {
                    frmScoreAdd frmScoreAdd = new frmScoreAdd(txtR2T3.Text, txtR2T4.Text, matches, user, landen);
                    frmScoreAdd.Show();
                    this.Hide();
                }
                else if (rbPot5.Checked)
                {
                    frmScoreAdd frmScoreAdd = new frmScoreAdd(txtR3T1.Text, txtR3T2.Text, matches, user, landen);
                    frmScoreAdd.Show();
                    this.Hide();
                }
                else if (rbPot6.Checked)
                {
                    frmScoreAdd frmScoreAdd = new frmScoreAdd(txtR3T3.Text, txtR3T4.Text, matches, user, landen);
                    frmScoreAdd.Show();
                    this.Hide();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnVulScore_Click(object sender, EventArgs e)
        {
            if (landen == null)
            {
                MessageBox.Show("er zijn geen landen te vullen", "Landen Null");
            }
            else if (landen.Count < 4)
            {
                MessageBox.Show("Er zijn geen 4 landen toegevoegd", "Index out of range");

            }
            else 
            {
                FillScore();
            }
        }


        #region Methodes

        /// <summary>
        /// Vult de textboxen met de score
        /// </summary>
        private void FillScore() 
        {
            try
            {
                if (matches == null) { MessageBox.Show("Er zijn nog geen matches gemaakt!", "Null Error"); }
                else if (matches.Count < 6) { MessageBox.Show("Er zijn nog geen 6 matches gemaakt!", "Index Error"); }
                else {
                    tbR1S1.Text = matches[0].ScoreHome.ToString();
                    tbR1S2.Text = matches[0].ScoreAway.ToString();
                    tbR1S3.Text = matches[1].ScoreHome.ToString();
                    tbR1S4.Text = matches[1].ScoreAway.ToString();

                    tbR2S1.Text = matches[2].ScoreHome.ToString();
                    tbR2S2.Text = matches[2].ScoreAway.ToString();
                    tbR2S3.Text = matches[3].ScoreHome.ToString();
                    tbR2S4.Text = matches[3].ScoreAway.ToString();

                    tbR3S1.Text = matches[4].ScoreHome.ToString();
                    tbR3S2.Text = matches[4].ScoreAway.ToString();
                    tbR3S3.Text = matches[5].ScoreHome.ToString();
                    tbR3S4.Text = matches[5].ScoreAway.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }



        /// <summary>
        /// Vult alle textboxen met de teams
        /// </summary>
        public void FillTextBoxen()
        {
            try
            {
                foreach (Control cntrl in this.Controls)
                {
                    if (index < 12)
                    {
                        if (cntrl is TextBox && cntrl.Name.StartsWith("txt"))
                        {
                            while (cntrl.TabIndex != index) { index++; }
                            if (cntrl.TabIndex == index)
                            {
                                cntrl.Text = landen[test[index]];
                                index = 0;

                            }
                            else
                            { 
                            
                            }
                        }
                    }
                    else { index = 0; }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

    }
}
