using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DBLibrary
{
    class ConnectionHandler
    {
        //creo delle costanti di stringhe con tutte le credenzili che sevono per accedere al DB
        const string server = "db4free.net";
        const string port = "3306";
        const string user = "admininfo";
        const string pass = "informatica321";
        const string dbName = "dbannuario";
        public MySqlConnection connection;

        public ConnectionHandler()
        {
            // creo un nuovo MySqlConnection (nello stesso modo di una lista) e come argomento gli inserisco una concatenazione di stringhe con le credenziali precedenti
          this.connection = new MySqlConnection("Server=" + server + ";Port=" + port + ";Database=" + dbName + ";Uid=" + user + ";Pwd=" + pass + ";");
        }

        public bool openConnection()
        {
            try
            {
                this.connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }

    
}
