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
          public List<List<string>> Select(string  table,string elements,List<string> checkeditems)
            {
                this.initializeQuery(this.cmd,"SELECT "+elements+" FROM "+table);
        
                List<List<string>> lista = new List<List<string>>();
                    

                for (int i = 0; i <checkeditems.Count; i++)
                {
                   lista.Add(new List<string>());
                }

               MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                        for (int i = 0; i < checkeditems.Count; i++)
                        {
                           lista[i].Add(dataReader[checkeditems[i]].ToString());              
                        }
                        lista.Add(checkeditems);

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

          public List<string> getColumnNames(string tablename)
        {
            this.initializeQuery(this.cmd, " SHOW COLUMNS FROM "+tablename +";"); 

            List <string> lista = new List<string>();

            MySqlDataReader dataReader = this.cmd.ExecuteReader();
            while (dataReader.Read())
            {
                lista.Add(dataReader[0].ToString());
            }
            dataReader.Close();

            return lista;

        }

          public List<string> getTableNames()
            {
                this.initializeQuery(this.cmd, "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA = 'dbannuario';");

                List<string> lista = new List<string>();

                MySqlDataReader dataReader = this.cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    lista.Add(dataReader[0].ToString());
                }
                dataReader.Close();

                return lista;

            }
    }

   
    }