using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.UIForms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmClientes cli = new FrmClientes(this);
            cli.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCuentas cue = new FrmCuentas(this);
            cue.Show();
            this.Hide();
        }
    }
}
