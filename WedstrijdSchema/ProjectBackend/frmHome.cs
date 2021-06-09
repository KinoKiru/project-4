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
        int index = 0;
        int puntenIndex = 0;

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
            FillTextBoxen();
        }

        /// <summary>
        /// Vult alle textboxen met de teams
        /// </summary>
        public void FillTextBoxen() 
        {
            try
            {
                if (landen == null)
                {
                    MessageBox.Show("er zijn geen landen te vullen", "Landen Null");
                }
                else 
                {
                    foreach (Control cntrl in this.Controls)
                    {
                        if (index < 12)
                        {
                            if (cntrl is TextBox)
                            {
                                if (cntrl.Name.StartsWith("txt"))
                                {
                                    while (cntrl.TabIndex != index) { index++; }
                                    if (cntrl.TabIndex == index)
                                    { 
                                            cntrl.Text = landen[test[index]];
                                            index = 0;
                                        
                                    }
                                }
                            }
                        }
                        else { index = 0; }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }


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
            finally { FillTextBoxen(); }
 

        }

        private void btnVulScore_Click(object sender, EventArgs e)
        {
            FillScore(); 
        }

        #region Methodes
        private void FillScore() 
        {

            try
            {
                if (matches == null) { MessageBox.Show("Er zijn nog geen matches gemaakt!", "Null Error"); }

                foreach (Control cntrl in this.Controls)
                {
                    if (puntenIndex < 6)
                    {
                        if (cntrl is TextBox && cntrl.Name.StartsWith("tb"))
                        {
                            while (cntrl.TabIndex != puntenIndex) { puntenIndex++; }
                            if (cntrl.TabIndex == puntenIndex)
                            {
                                if (index % 2 == 0) { cntrl.Text = matches[puntenIndex].ScoreAway.ToString(); }
                                else { cntrl.Text = matches[puntenIndex].ScoreHome.ToString(); }
                            }
                        }
                    }
                    else { puntenIndex = 0; }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
          

        }



        #endregion

    }
}
