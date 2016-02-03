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
    public partial class UpdateForm : Form1
    {
        ConnectionHandler con = new ConnectionHandler();

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (DisplayGrid.SelectedRows.Count > 0)
            {
                Query query = new Query(con);
               
                try
                {
                    for (int i = 0; i < DisplayGrid.SelectedRows.Count; i++)
                    {
                        query.Update(TableComboBox.SelectedItem.ToString(), concatItems(), DisplayGrid.SelectedRows[0].Cells[0].Value.ToString());
                    }
                    MessageBox.Show("record aggiornati  con successo");
                }
                catch
                {
                    MessageBox.Show("Errore");
                }
            }
            else
            {
                MessageBox.Show("Seleziona il record da aggiornare");
            }
        }

        private string concatItems()
        {
            string value = "";

            for (int i = 1; i <getCheckedItems().Count; i++)
            {
                string comma = "";
                if (i != getCheckedItems().Count - 1) { comma = ","; }
                value += DisplayGrid.Columns[i].Name + "='"+DisplayGrid.SelectedRows[0].Cells[i].Value.ToString()+"'"+comma;
            }
            return value;
        }
    }
}
