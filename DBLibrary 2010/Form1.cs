using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBLibrary
{
    public partial class Form1 : Form
    {
        ConnectionHandler con = new ConnectionHandler();
       

        public Form1()
        { 
            InitializeComponent();
            FillTableComboBox();
        }

       virtual protected void button1_Click(object sender, EventArgs e)
        {

           DisplayGrid.Columns.Clear();

           con = new ConnectionHandler();

           Query quer = new Query(con);

            if (ColumnsList.CheckedItems.Count > 0) {
                List<List<string>> lis = quer.Select(TableComboBox.SelectedItem.ToString(), concatCheckedItems(), getCheckedItems());
                FillDataGridView(lis);
            }
            else { MessageBox.Show("Seleziona degli elementi stronzo"); }
        }
        
        //riempie la combobox coi nomi delle tabelle del database
        protected virtual void FillTableComboBox()
        {
            Query qu = new Query(con);
            List<string> Tables = qu.getTableNames();
            //aggiunge gli elementi alla combobox
            for (int i = 0; i < Tables.Count; i++)
            {
                TableComboBox.Items.Add(Tables[i]);
            }
        }

        //quando viene selezionata una nuova tabella,cambia i nomi delle colonne nella checkedlistbox
       virtual protected void TableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColumnsList.Items.Clear();
            

            Query qu = new Query(con);
            int index = TableComboBox.SelectedIndex;
            List<string> Columns = qu.getColumnNames(TableComboBox.Items[index].ToString());

            //aggiunge le colonne alla checkedlistbox
            for (int i = 1; i < Columns.Count; i++)
            {
                ColumnsList.Items.Add(Columns[i]);
            }
        }

        //converte la lista degli elementi selezionati in una stringa leggibile dalla query
        protected virtual string concatCheckedItems()
        {

            Query query = new Query(this.con);
            string values = query.getColumnNames(TableComboBox.SelectedItem.ToString())[0]+",";

            for (int i = 0; i < ColumnsList.CheckedItems.Count; i++)
            {
                string comma="";
                if(i != ColumnsList.CheckedItems.Count - 1) { comma = ","; }

                values +=ColumnsList.CheckedItems[i].ToString()+ comma;
            }
           return values;
        }

        //converte la lista degli elementi selezionati in una lista di stringhe
        protected virtual List<string> getCheckedItems()
        {
            List<string> lista = new List<string>();

            Query query = new Query(this.con);

            lista.Add(query.getColumnNames(TableComboBox.SelectedItem.ToString())[0]);
            for (int i = 0; i < ColumnsList.CheckedItems.Count; i++)
            {
                lista.Add(ColumnsList.CheckedItems[i].ToString());
            }
            return lista;
        }

        //fa displaiare i risultati nella datagridview
        protected void FillDataGridView(List<List<string>> list)
        {

            DisplayGrid.ColumnCount = list.Count;

            List<string> columns = getCheckedItems();
            //scrive i nomi delle colonne
            for (int i = 0; i < columns.Count; i++)
            {
                DisplayGrid.Columns[i].Name = columns[i].ToString();
            }

            for (int i = 0; i < list[0].Count; i++)
            {
                string[] col = new string[list[0].Count+4];
                    for (int j = 0; j < columns.Count; j++)
                    {
                        col[j] = list[j][i];
                    }
                DisplayGrid.Rows.Add(col);
            }

            DisplayGrid.Columns[0].ReadOnly = true;
        } 

    }
}
