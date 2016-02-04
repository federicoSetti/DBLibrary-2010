using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace DBLibrary
{     //creo delle costanti di stringhe con tutte le credenziali che sevono per accedere al DB
    static class Credentials
    {    
        //credenziali del database principale
        public const string server = "db4free.net";
        public const string port = "3306";
        public const string user = "admininfo";
        public const string pass = "informatica321";
        public const string dbName = "dbannuario";

        //credenziali del database di riserva
        public const string fallbackserver = "sql2.freemysqlhosting.net";
        public const string fallbackport = "3306";
        public const string fallbackuser = "sql2105240";
        public const string fallbackpass = "jA9*tE1%";
        public const string fallbackdbName = "sql2105240";
    }
}
