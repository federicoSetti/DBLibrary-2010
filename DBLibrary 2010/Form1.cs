using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBLibrary
{
    public partial class Form1 : Form
    {
        ConnectionHandler con;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con = new ConnectionHandler();
            
            Query ins = new Query(con);
            ins.insertInto();

            Query quer = new Query(con);

            List<string> lista = quer.Select();

            for (int i = 0; i < lista.Count; i++)
            {
                listBox1.Items.Add(lista[i]);
            }
                    
        }
    }
}
