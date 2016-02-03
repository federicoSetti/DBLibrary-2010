using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBLibrary;

namespace WindowsFormsApplication1
{
    public partial class AddForm : Form1
    {
        ConnectionHandler conn= new ConnectionHandler();

  

        public AddForm()
        {
            InitializeComponent();
         
        }
        //concatena i nomi delle colonne in una stringa
        private string concatItems()
        {
            string values = "alias,";

            for (int i = 0; i < ColumnsList.Items.Count; i++)
            {
                string comma = "";
                if (i != ColumnsList.Items.Count - 1) { comma = ","; }

                values += ColumnsList.Items[i].ToString() + comma;
            }
            return values;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Query query = new Query(this.conn);

            query.insertInto(TableComboBox.SelectedItem.ToString(), concatItems(), getNewValues());



        }
        
        protected override void TableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {   
            
            base.TableComboBox_SelectedIndexChanged(sender, e);
            InitializeDatagrid();
        }

        //concatena i valori delle colonne in una stringa
        private string getNewValues()
        {
            string values = "";

            for (int i = 0; i <ColumnsList.Items.Count+1 ; i++)
            {
                string comma = "";
                if (i !=  ColumnsList.Items.Count) { comma = ","; }

                values += "'"+newValuesGrid.Rows[0].Cells[i].Value+"'" + comma;
            }

            return values;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        //scrive i nomi delle colonne nella datagrid
        private void InitializeDatagrid()
        {
            Query query = new Query(this.conn);
            List<string> columnNames = query.getColumnNames(TableComboBox.SelectedItem.ToString());

            newValuesGrid.Columns.Clear();

            newValuesGrid.ColumnCount = columnNames.Count;


            for (int i = 0; i < columnNames.Count; i++)
            {
                newValuesGrid.Columns[i].Name =columnNames[i];
            }

        }
    }
}
