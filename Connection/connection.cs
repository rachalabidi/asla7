using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    internal interface connection
    {
        public abstract void connecter(string myslqcon , out MySqlConnection con );
        public abstract void LoginValidation(string pass, string Username, out bool res);

    }
}
