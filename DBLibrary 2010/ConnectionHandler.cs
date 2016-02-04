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

        public string Database = ""; //nome del database attualmente in uso

        public MySqlConnection connection; //connessione al database principale
        public MySqlConnection fallbackconnection; //connessione al database di riserva
        public MySqlConnection currentconnection; //connessione attiva

        public ConnectionHandler()
        {
          //creo un nuovo MySqlConnection (nello stesso modo di una lista) e come argomento gli inserisco una concatenazione di stringhe con le credenziali precedenti
          this.connection = new MySqlConnection("Server=" + Credentials.server + ";Port=" + Credentials.port + ";Database=" + Credentials.dbName + ";Uid=" + Credentials.user + ";Pwd=" + Credentials.pass + ";");
          this.fallbackconnection = new MySqlConnection("Server=" + Credentials.fallbackserver + ";Port=" + Credentials.fallbackport + ";Database=" + Credentials.fallbackdbName + ";Uid=" + Credentials.fallbackuser + ";Pwd=" + Credentials.fallbackpass + ";");
          this.HandleFallback();
           
        }

        //apre la connessione
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

        //gestisce la connessione nel caso il database principale non sia disponibile
        public void HandleFallback()
        {

            if(this.openConnection(this.connection))
            {
                this.currentconnection = this.connection;
                this.Database = Credentials.dbName;
            }
            else if(this.openConnection(this.fallbackconnection) )
            {
                this.currentconnection = this.fallbackconnection;
                this.Database = Credentials.fallbackdbName;
            }
            else
            {
            }
        } 
        
    }

    
}
