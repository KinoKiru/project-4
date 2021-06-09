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
    public partial class frmLogin : Form
    {
        List<login> gegevens;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            gegevens = LoginDB.GetLogin();
            try
            {
                foreach (login klant in gegevens)
                {
                    if (txtUserName.Text == klant.Usernname && txtWachtwoord.Text == klant.WachtWoord)
                    {
                        frmHome form = new frmHome(klant);
                        form.Show();
                        this.Hide();
                    }
                }
            }
            catch (ArgumentException er) { MessageBox.Show(er.Message, "Error message"); }
        }

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            frmRegistreer form = new frmRegistreer();
            form.Show();
            this.Hide();
        }
    }
}
