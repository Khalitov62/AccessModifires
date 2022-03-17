using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers
{
    internal class User
    {
        string _password;
        string _username;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("Duzgun username daxil edin");
                }
            }

        }
        public string Password
        {

            get
            {
                return _password;
            }
            set
            {

                if (value = char.ToUpper(Password[i])) ToString);
            
            }
               


        }



    }




}




