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

            this.con.openConnection(this.con.fallbackconnection);
            this.cmd = new MySqlCommand();
        }

          //creo la procedura getStudents 
          public void initializeQuery(MySqlCommand cmd,string request)
        {
            this.con.openConnection(this.con.fallbackconnection);
            cmd.Connection = this.con.fallbackconnection;
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

          public void insertInto(string table,string columns,string values)
          {
              this.initializeQuery(this.cmd, "INSERT INTO "+table+"("+columns+") VALUES("+values+")");
          }
              
          public void Update(string table,string values,string alias)
          {
            this.initializeQuery(this.cmd, "UPDATE " +table+ " SET "+values +" WHERE alias = '"+alias+"'; ");
          }

          public void Delete(string table,string recordname,string recordvalue)
          {
            this.initializeQuery(this.cmd, "DELETE FROM "+table+" WHERE "+recordname+"='"+recordvalue+"';");
          }
           
          //ritorna i nomi delle colonne di una determinata tabella
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
          
         //ritorna i nomi delle tabelle del database
          public List<string> getTableNames()
            {
                this.initializeQuery(this.cmd, "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA = 'sql2105240';");

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