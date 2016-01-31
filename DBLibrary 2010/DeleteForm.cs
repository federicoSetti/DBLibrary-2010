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
    public partial class DeleteForm : Form1
    {
        ConnectionHandler con = new ConnectionHandler();

        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Query query = new Query(con);


            if (DisplayGrid.SelectedRows.Count > 0)
            {
                try
                {
                    for (int i = 0; i < DisplayGrid.SelectedRows.Count; i++)
                    {
                        query.Delete(TableComboBox.SelectedItem.ToString(), DisplayGrid.Columns[0].Name, DisplayGrid.SelectedRows[i].Cells[0].Value.ToString());
                    }
                    MessageBox.Show("record eliminati dal database con successo");
                }
                catch
                {
                    MessageBox.Show("Errore");
                }
            }
            else
            {
                MessageBox.Show("Seleziona le righe da eliminare");
            }
        }
    }
}
