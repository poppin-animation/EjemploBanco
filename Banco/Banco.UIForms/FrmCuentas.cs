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
    public partial class FrmCuentas : Form
    {
        private CuentaNegocio _cuentaNegocio;
        private ClienteNegocio _clienteNegocio;
        public FrmCuentas(Form main)
        {
            InitializeComponent();

            this.Owner = main;

            _cuentaNegocio = new CuentaNegocio();
            _clienteNegocio = new ClienteNegocio();

        }

        private void FrmCuentas_Load(object sender, EventArgs e)
        {
            CargarComboClientes();
        }

        private void CargarComboClientes()
        {
            cmbClientes.DataSource = null;
            cmbClientes.DataSource = _clienteNegocio.Traer();
        }

        private void CargarCuenta()
        {
            Cuenta c = ((Cliente)cmbClientes.SelectedItem).Cuenta;

            if (c != null)
            {
                textBox1.Text = c.NroCuenta.ToString();
                textBox2.Text = c.Descripcion;
                textBox3.Text = c.Saldo.ToString("0.00");
                textBox4.Text = c.FechaApertura.ToString("yyyy-MM-dd");
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = true;
                textBox4.Enabled = false;
            }
            else
            {
                Limpiar();
            }
        }
        

        private void Limpiar()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox4.Enabled = false;


        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbClientes.DataSource != null)
            {
                CargarCuenta();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cli = (Cliente)cmbClientes.SelectedItem;

            // cliente sin cuenta > alta
            if(cli.Cuenta == null) {
                cli.Cuenta = new Cuenta();
                cli.Cuenta.idCliente = cli.id;
                cli.Cuenta.Descripcion = textBox2.Text;

                cli.Cuenta = _cuentaNegocio.Alta(cli.Cuenta);

                cmbClientes.SelectedIndex = 0;
                MessageBox.Show("Cuenta creada");

            }
            // cliente con cuenta > actalizar solo saldo
            else
            {
                cli.Cuenta.Saldo = Convert.ToDouble(textBox3.Text);
                
                cli.Cuenta =  _cuentaNegocio.Update(cli.Cuenta);

                cmbClientes.SelectedIndex = 0;
                MessageBox.Show("Cuenta actualizada");
            }
        }


        private void CargarCuenta_LLAMADA_DIRECTA()
        {
            int cod = ((Cliente)cmbClientes.SelectedItem).id;
            Cuenta c = _cuentaNegocio.TraerPorCliente(cod);
            if (c != null)
            {
                textBox1.Text = c.NroCuenta.ToString();
                textBox2.Text = c.Descripcion;
                textBox3.Text = c.Saldo.ToString("0.00");
                textBox4.Text = c.FechaApertura.ToString("yyyy-MM-dd");
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = true;
                textBox4.Enabled = false;
            }
            else
            {
                Limpiar();
            }

        }
    }
}
