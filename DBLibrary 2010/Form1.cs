﻿using System;
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

            con = new ConnectionHandler();


            Query quer = new Query(con);

            List<string> lista = quer.getColumnNames("students");


                    
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
    }
}
