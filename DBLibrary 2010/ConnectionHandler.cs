using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DBLibrary
{
    class ConnectionHandler
    {
        //creo delle costanti di stringhe con tutte le credenzili che sevono per accedere al DB
        public const string server = "db4free.net";
        public const string port = "3306";
        public const string user = "admininfo";
        public const string pass = "informatica321";
        public const string dbName = "dbannuario";

        public const string fallbackserver = "sql2.freemysqlhosting.net";
        public const string fallbackport = "3306";
        public const string fallbackuser = "sql2105240";
        public const string fallbackpass = "jA9*tE1%";
        public const string fallbackdbName = "sql2105240";

        public string Database = "";

        public MySqlConnection connection;
        public MySqlConnection fallbackconnection;
        public MySqlConnection currentconnection;

        public ConnectionHandler()
        {
          //creo un nuovo MySqlConnection (nello stesso modo di una lista) e come argomento gli inserisco una concatenazione di stringhe con le credenziali precedenti
          this.connection = new MySqlConnection("Server=" + server + ";Port=" + port + ";Database=" + dbName + ";Uid=" + user + ";Pwd=" + pass + ";");
          this.fallbackconnection = new MySqlConnection("Server=" + fallbackserver + ";Port=" + fallbackport + ";Database=" + fallbackdbName + ";Uid=" + fallbackuser + ";Pwd=" + fallbackpass + ";");
          this.HandleFallback();
           
        }

        public bool openConnection(MySqlConnection connect)
        {
            try
            {
                connect.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void HandleFallback()
        {

            if(this.openConnection(this.connection))
            {
                this.currentconnection = this.connection;
                this.Database = "dbannuario";
            }
            else if(this.openConnection(this.fallbackconnection) )
            {
                this.currentconnection = this.fallbackconnection;
                this.Database = "sql2105240";
            }
            else
            {
            }
        } 
        
    }

    
}
