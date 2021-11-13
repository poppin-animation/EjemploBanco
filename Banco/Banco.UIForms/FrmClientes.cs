using Banco.Entidades.Dominio;
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
        private List<Cliente> _clientes;
        private string TotalClientes {
            get
            {
                if (_clientes != null)
                {
                    return _clientes.Count.ToString();
                }
                else
                    return "0";
            }
        }
        
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
            _clientes = _clienteNegocio.TraerSinCuentas(); 

            lstClientes.DataSource = null;
            lstClientes.DataSource = _clientes;

            _lblTotalClientes.Text = "Cantidad: " + this.TotalClientes;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

            
                // si tiene algo es alta, sino es nuevo
                string codigo = _txtCodigo.Text;


                long dni = Convert.ToInt64(_txtDNI.Text); // validación si es un número
                string nombre = _txtNombre.Text; // validación si es vacio y una cantidad de caracteres mínimos
                string apellido = _txtApellido.Text; // validación si es vacio y una cantidad de caracteres mínimos
                string email = _txtEmail.Text; // validación si es vacio y una cantidad de caracteres mínimos
                string telefono = _txtTelefono.Text; // validación que tenga numeros
                string direccion = _txtDireccion.Text; // validación si es vacio y una cantidad de caracteres mínimos
                DateTime fechaNac = Convert.ToDateTime(_txtFechaNac.Text); // validación si es fecha
                bool activo = _chkActivo.Checked;

                TransactionResult resultado = null;
                if (string.IsNullOrEmpty(codigo))
                {
                    resultado = _clienteNegocio.Agregar(nombre, apellido, fechaNac, dni, telefono, direccion, activo, email);
                }
                else
                {
                    resultado = _clienteNegocio.Modificar(Convert.ToInt32(codigo),nombre, apellido, fechaNac, dni, telefono, direccion, activo, email);
                }


                    MessageBox.Show(resultado.Id.ToString());
                Limpiar();
                Recargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void Limpiar()
        {
            _txtCodigo.Clear();
            _txtDNI.Clear();
            _txtNombre.Clear();
            _txtApellido.Clear();
            _txtEmail.Clear();
            _txtTelefono.Clear();
            _txtDireccion.Clear();
            _txtFechaNac.Clear();
            
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstClientes.SelectedIndex > -1)
            {
                Cliente cliente = (Cliente)lstClientes.SelectedItem;
                _txtCodigo.Text = cliente.id.ToString();
                _txtDNI.Text = cliente.DNI.ToString();
                _txtNombre.Text = cliente.Nombre;
                _txtApellido.Text = cliente.Ape;
                _txtEmail.Text = cliente.Email;
                _txtTelefono.Text = cliente.Telefono;
                _txtDireccion.Text = cliente.Direccion;
                _txtFechaNac.Text = cliente.FechaNac.ToString("yyyy-MM-dd");
            }
        }
    }
}
