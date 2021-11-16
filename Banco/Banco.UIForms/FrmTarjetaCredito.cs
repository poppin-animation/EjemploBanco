using Banco.Entidades.Dominio;
using Banco.Entidades.Enums;
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
    public partial class FrmTarjetaCredito : Form
    {
        private TarjetaNegocio _servicioTarjetas;
        private ClienteNegocio _servicioClientes;
        private List<TarjetaCredito> _tarjetas;

        public FrmTarjetaCredito()
        {
            _servicioTarjetas = new TarjetaNegocio();
            _servicioClientes = new ClienteNegocio();
            InitializeComponent();
        }

        private void FrmTarjetaCredito_Load(object sender, EventArgs e)
        {
            CargarCombos();
            RecargarLista();
            RecargarCalculos();
        }

        #region "CARGAS"
        private void Limpiar()
        {
            _txtNroPlastico.Clear();
            _txtLimite.Clear();
            _cmbTipoTarjeta.SelectedIndex = 0;
            _cmbPeriodo.SelectedIndex = 0;
        }

        private void CargarCombos()
        {
            // esta es la forma fácil de llenar un combo con un enum
            _cmbPeriodo.DataSource = Enum.GetValues(typeof(PeriodoEnum));
            _cmbTipoTarjeta.DataSource = Enum.GetValues(typeof(TipoTarjetaEnum));

            // traemos los clientes con cuenta para poder validar los saldos
            _cmbClientes.DataSource = _servicioClientes.TraerConCuentas();
            _cmbClientes.DisplayMember = "DisplayParaCombo"; // Esta propiedad se creo en cliente para tener un formato propio de combo
            _cmbClientes.ValueMember = "id";
        }

        private void RecargarLista()
        {
            _tarjetas = _servicioTarjetas.TraerTodas();
            lstTarjetas.DataSource = null;
            lstTarjetas.DataSource = _tarjetas;
        }

        private void RecargarCalculos()
        {
            OperadorFormulario operadorFormulario = new OperadorFormulario(_tarjetas);
            _txtCantidad.Text = operadorFormulario.Cantidad.ToString();
            _txtPromedio.Text = operadorFormulario.LimitePromedio.ToString("0.00");
        }

        #endregion

        
        #region "Validaciones"
        private void ValidacionesCalcularTarjeta()
        {
            TipoTarjetaEnum tipo = (TipoTarjetaEnum)_cmbTipoTarjeta.SelectedItem;
            PeriodoEnum periodo = (PeriodoEnum)_cmbPeriodo.SelectedItem;
            Cliente cliente = (Cliente)_cmbClientes.SelectedItem;

            // valido que exista selección
            if (((int)tipo) == 0)
            {
                throw new Exception("Seleccione tipo");
            }

            if (((int)periodo) == 0)
            {
                throw new Exception("Seleccione periodo");
            }

            if (cliente == null || cliente.id == 0)
            {
                throw new Exception("Seleccione cliente válido");
            }


        }

        private void ValidacionesAlta()
        {
            ValidacionesCalcularTarjeta();

            // agregamos más validaciones:
            // dígitos del plástico depende del tipo tarjeta,
            // que el limite sea numerico y que respete los límites

        }
        #endregion


        #region "EVENTOS"
        private void _btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                ValidacionesCalcularTarjeta();

                Cliente cliente = (Cliente)_cmbClientes.SelectedItem;
                TipoTarjetaEnum tipo = (TipoTarjetaEnum)_cmbTipoTarjeta.SelectedItem;
                PeriodoEnum periodo = (PeriodoEnum)_cmbPeriodo.SelectedItem;

                if (cliente != null)
                {
                    // le damos la responsabilidad a la capa de negocio de calcular la tarjeta
                    string nroTarjeta = _servicioTarjetas.CalcularNroPlastico(cliente, tipo, periodo);

                    _txtNroPlastico.Text = nroTarjeta;
                }
            }
            // capturar las distintas exceptions
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void _btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                ValidacionesAlta();

                TipoTarjetaEnum tipo = (TipoTarjetaEnum)_cmbTipoTarjeta.SelectedItem;
                PeriodoEnum periodo = (PeriodoEnum)_cmbPeriodo.SelectedItem;
                Cliente cliente = (Cliente)_cmbClientes.SelectedItem;
                string plastico = _txtNroPlastico.Text;
                double limite = Convert.ToDouble(_txtLimite.Text);
                _servicioTarjetas.Alta(tipo, periodo, cliente, plastico, limite);

                Limpiar();
                RecargarLista();
                RecargarCalculos();
            }
            // capturar las distintas exceptions
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        #endregion











    }
}
