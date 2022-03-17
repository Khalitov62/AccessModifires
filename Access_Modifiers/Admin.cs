using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers
{
    public class Admin : User
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin( string section, string password, string username,bool issuperadmin=false)
        {
            IsSuperAdmin = issuperadmin;
            Section = section;
            Password = password;
            Username = username;





        }
        public static string Info(string section,string password string username,bool issuperadmin=false)
        {
            return section + password + username + issuperadmin;
        }

    }
}
