using System;
using System.Collections.Generic;
using System.Text;

namespace task1_access_modifiers
{
    internal class User
    {
        public string _username;
        private string _password;
        public void Users(string username)
        {
            UserName = username;
        }
        public string UserName
        {
            get
            {
                return this._username;
            }
            set
            {
                if (value.Length >= 6 && value.Length <= 25) ;
                this._username = value;
            }
        }
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                if (value.Length >= 8 && value.Length <= 25) ;
                this._password = value;
            }
        }
    }
}

              
