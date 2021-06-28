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
    public partial class frmLanden : Form
    {
        #region global
        login user;
        List<string> landen = new List<string>(4);
        int index;
        #endregion

        public frmLanden(login login)
        {
            InitializeComponent();
            this.user = login;
        }

        private void frmLanden_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome frmHome = new frmHome(user, landen);
            frmHome.Show();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if (IsValidData()) 
            {
                if (index >= 4) 
                {
                    MessageBox.Show("U kunt maar 4 landen toevoegen","Error Message");
                } 
                else 
                {
                    landen.Add(txtLand.Text);
                    lbLanden.Items.Add(txtLand.Text);
                    txtLand.Text = "";
                    txtLand.Focus();
                    index++;
                }
            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            if (lbLanden.SelectedIndex > -1)
            {
                landen.RemoveAt(lbLanden.SelectedIndex);
                lbLanden.Items.RemoveAt(lbLanden.SelectedIndex);
                index--;
            }
        }


        /// <summary>
        /// check de textbox of er wel wat in zit
        /// </summary>
        /// <returns>true / false</returns>
        private bool IsValidData()
        {
            return Validator.IsPresent(txtLand);        
        } 
    }
}
