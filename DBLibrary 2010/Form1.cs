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

        private void button1_Click(object sender, EventArgs e)
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
        public void FillTableComboBox()
        {
            Query qu = new Query(con);
            List<string> Tables = qu.getTableNames();

            for (int i = 0; i < Tables.Count; i++)
            {
                TableComboBox.Items.Add(Tables[i]);
            }
        }

        //quando viene selezionata una nuova tabella,cambia i nomi delle colonne nella checkedlistbox
        private void TableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColumnsList.Items.Clear();

            Query qu = new Query(con);
            int index = TableComboBox.SelectedIndex;
            List<string> Columns = qu.getColumnNames(TableComboBox.Items[index].ToString());

            for (int i = 0; i < Columns.Count; i++)
            {
                ColumnsList.Items.Add(Columns[i]);
            }
        }

        //converte la lista degli elementi selezionati in una stringa leggibile dalla query
        private string concatCheckedItems()
        {
            string values = "";

            for (int i = 0; i < ColumnsList.CheckedItems.Count; i++)
            {
                string comma="";
                if(i != ColumnsList.CheckedItems.Count - 1) { comma = ","; }

                values +=ColumnsList.CheckedItems[i].ToString()+ comma;
            }

           return values;
        }

        //converte la lista degli elementi selezionati in una lista di stringhe
        private List<string> getCheckedItems()
        {
            List<string> lista = new List<string>();

            for (int i = 0; i < ColumnsList.CheckedItems.Count; i++)
            {

                lista.Add(ColumnsList.CheckedItems[i].ToString());
            }
            return lista;
        }

        //fa displaiare i risultati nella datagridview
        private void FillDataGridView(List<List<string>> list)
        {

            DisplayGrid.ColumnCount = list.Count;

            for (int i = 0; i < ColumnsList.CheckedItems.Count; i++)
            {
                DisplayGrid.Columns[i].Name = ColumnsList.CheckedItems[i].ToString();
            }

            for (int i = 0; i < list[0].Count; i++)
            {
                string[] col = new string[list[0].Count];
                    for (int j = 0; j < ColumnsList.CheckedItems.Count; j++)
                    {
                        col[j] = list[j][i];
                    }
                DisplayGrid.Rows.Add(col);
            }
        } 

    }
}
