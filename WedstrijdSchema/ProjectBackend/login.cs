using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBackend
{
    public class login
    {
        private string email;
        private string username;
        private string wachtwoord;

        #region properties
        public string WachtWoord
        {
            get { return wachtwoord; }
            set { wachtwoord = value; }
        }


        public string Usernname
        {
            get { return username; }
            set { username = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion

        public login() { }

        public login(string email, string username, string wachtwoord)
        {
            this.email = email;
            this.username = username;
            this.wachtwoord = wachtwoord;
        }
    }
}
