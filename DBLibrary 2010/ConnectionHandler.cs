using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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

        const string fallbackserver = "sql2.freemysqlhosting.net";
        const string fallbackport = "3306";
        const string fallbackuser = "sql2105240";
        const string fallbackpass = "jA9*tE1%";
        const string fallbackdbName = "sql2105240";

        public MySqlConnection connection;
        public MySqlConnection fallbackconnection;

        public ConnectionHandler()
        {
            // creo un nuovo MySqlConnection (nello stesso modo di una lista) e come argomento gli inserisco una concatenazione di stringhe con le credenziali precedenti
          this.connection = new MySqlConnection("Server=" + server + ";Port=" + port + ";Database=" + dbName + ";Uid=" + user + ";Pwd=" + pass + ";");
          this.fallbackconnection = new MySqlConnection("Server=" + fallbackserver + ";Port=" + fallbackport + ";Database=" + fallbackdbName + ";Uid=" + fallbackuser + ";Pwd=" + fallbackpass + ";");
          //this.openConnection(this.fallbackconnection);
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
                MessageBox.Show("Connessione riuscita al database principale");
            }
            else if(this.openConnection(this.fallbackconnection) )
            {
                MessageBox.Show("Connessione riuscita al database di emergenza");
            }
            else
            {
                MessageBox.Show("Connessione non riuscita a nessun dabatabase");
            }
        } 
        
    }

    
}
