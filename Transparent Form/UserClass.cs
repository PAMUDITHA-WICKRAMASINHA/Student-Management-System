using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transparent_Form
{
    class UserClass
    {
        DBconnect connect = new DBconnect();
        //create a function to add a new students to the database

        public bool insertUser(string fullName, string UserName, string password, string conPassword)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `user`(`fullName`, `userName`, `password`, `conPassword`) VALUES(@fn, @un, @pass, @cpass)", connect.getconnection);

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fullName;
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = UserName;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@cpass", MySqlDbType.VarChar).Value = conPassword;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }

        }
    }
}
