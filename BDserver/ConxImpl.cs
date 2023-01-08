using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BDserver
{
    public class ConxImpl : MarshalByRefObject, Connection.connection

    {
       public   ConxImpl() { }
        public MySqlConnection connecter( string myslqcon , out MySqlConnection mySqlConnection)
        {  
            MySqlConnection mySqlConnection = new MySqlConnection(myslqcon);
            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          //  finally { mySqlConnection.Close(); }
       // }
    }
        public  void LoginValidation(string pass, string Username, out bool res)
        {
        string myslqcon = "server=localhost;user=root;database=smarthouse;password=";
        MySqlConnection mySqlConnection = new MySqlConnection(myslqcon);

        string username = Username;
        string password = pass;
        res = false;
        try
        {
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("select * from user", mySqlConnection);
            MySqlDataReader Reader = mySqlCommand.ExecuteReader();
            while (Reader.Read())
            {
                if (username == Reader.GetString("userName") && password == Reader.GetString("password"))
                {
                    res = true;





                }

            }



        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally { mySqlConnection.Close(); }
    }

    }
}
