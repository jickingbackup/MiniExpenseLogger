using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataApp.Winforms
{
    public partial class ExpensesForm : Form
    {
        private MainForm mainForm = null;

        public ExpensesForm(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void groupBoxDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
