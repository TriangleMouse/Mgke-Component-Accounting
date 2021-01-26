using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Mgke_Component_Accounting
{
    public partial class Help : UserControl
    {
        public Help()
        {
            InitializeComponent();
        }

        private void bunifuCustomTextbox1_Enter(object sender, EventArgs e)
        {
            label1.Focus();
        }
    }
}
