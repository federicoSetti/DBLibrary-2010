using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DBLibrary
{
    class Query
    {

        ConnectionHandler con;
        MySqlCommand cmd;

        public Query( ConnectionHandler con)
        {
            this.con = con;
            this.con.openConnection();

            this.cmd = new MySqlCommand();
        }

        //creo la procedura getStudents 
        public void initializeQuery(MySqlCommand cmd,string request)
        {   
            cmd.Connection = this.con.connection;
            cmd.CommandText = request;
            cmd.ExecuteNonQuery();
        }

        //ritorna i dati selezionati
          public List<string> Select()
            {
                this.initializeQuery(this.cmd,"SELECT name FROM students");
        
                List<string> lista = new List<string>();

                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                  lista.Add(dataReader["name"].ToString());
                }
                dataReader.Close();

                return lista;

            }
          public void insertInto()
          {
              this.initializeQuery(this.cmd, "INSERT INTO students(alias,name,surname,img_url,description) VALUES('elon-musk','elon','musk','gfgf','ha i big money')");
          }
              
          public void Update()
          {
            this.initializeQuery(this.cmd, "UPDATE students SET name = 'Elon' WHERE alias = 'elon-musk'; ");
          }

          public void Delete()
          {
            this.initializeQuery(this.cmd, "DELETE FROM  students  WHERE alias = 'elon-musk'; ");
          }
    }

   
    }