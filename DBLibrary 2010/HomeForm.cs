using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBLibrary;
using WindowsFormsApplication1;

namespace DBLibrary
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void GoToNewForm(Form newform)
        {
            newform.Show();
                
        }

        private void VisualizzaBtn_Click(object sender, EventArgs e)
        {
            GoToNewForm(new Form1());
        }

        private void AggiornaBtn_Click(object sender, EventArgs e)
        {
            GoToNewForm(new UpdateForm());
        }

        private void EliminaBtn_Click(object sender, EventArgs e)
        {
            GoToNewForm(new DeleteForm());
        }

        private void AggiungiBtn_Click(object sender, EventArgs e)
        {
            GoToNewForm(new AddForm());
        }
    }
}
