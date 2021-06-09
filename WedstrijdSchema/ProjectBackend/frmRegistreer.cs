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
    public partial class frmRegistreer : Form
    {
        /// <summary>
        /// Deze list maak ik aan zodat ik alle logins kan ophalen, en dan de nieuwe kan toevoegen.
        /// </summary>
        private List<login> logins = null;

        frmLogin login = new frmLogin();

        public frmRegistreer()
        {
            InitializeComponent();
        }


        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                //als alle data klopt van de IsValidData dan maak ik en nieuwe inlog aan en voeg ik die toe aan de *database*
                login log = new login(txtEmail.Text, txtUserName.Text, txtWachtWoord.Text);
                logins.Add(log);
                LoginDB.SaveLogin(logins);

                //hiermee open in weer de inlog form als je een account hebt aangemaakt
                login.Show();
                this.Close();
                
            }
        }

        private void frmRegistreer_Load(object sender, EventArgs e)
        {
            logins = LoginDB.GetLogin();
        }

        /// <summary>
        /// Checkt elke textbox of de waarde overeenkomt met de class methode.
        /// alles moet kloppen anders returnt hij false.
        /// </summary>
        /// <returns>Boolean</returns>
        private bool IsValidData()
        {
            return Validator.IsPresent(txtUserName) &&
                   Validator.IsPresent(txtWachtWoord) &&
                   Validator.IsValidEmail(txtEmail);
        }

        private void frmRegistreer_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Show();
        }
    }
}
