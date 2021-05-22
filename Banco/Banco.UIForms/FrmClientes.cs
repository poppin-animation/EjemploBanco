using Banco.Entidades.Modelos;
using Banco.Negocio;
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
    public partial class FrmClientes : Form
    {
        private ClienteNegocio _clienteNegocio;
        public FrmClientes(Form main)
        {
            InitializeComponent();

            this.Owner = main;

            _clienteNegocio = new ClienteNegocio();
            
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                Recargar();
                
            }
            catch (Exception ex)
            {

                // todo
            }
        }

        private void Recargar()
        {
            lstClientes.DataSource = null;
            lstClientes.DataSource = _clienteNegocio.Traer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // alta

            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string fechaNac = textBox3.Text;
            int dni = Convert.ToInt32(textBox4.Text);

            // validaciones

            TransactionResult resultado = _clienteNegocio.Agregar(nombre, apellido, fechaNac, dni);

            MessageBox.Show(resultado.Id.ToString());

            Recargar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Recargar();

            }
            catch (Exception ex)
            {

                // todo
            }
        }
    }
}
