using Banco.Datos;
using Banco.Entidades.Dominio;
using Banco.Entidades.Enums;
using Banco.Entidades.Excepciones;
using Banco.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Negocio
{
    public class TarjetaNegocio
    {
        private TarjetaCreditoMapper _tarjetaMapper;

        public TarjetaNegocio()
        {
            _tarjetaMapper = new TarjetaCreditoMapper();
        }

        public List<TarjetaCredito> TraerTodas()
        {
            return _tarjetaMapper.Traer();
        }

        public void Alta(TipoTarjetaEnum tipo, PeriodoEnum periodo, Cliente cliente, string plastico, double limiteSolicitado)
        {
            // validamos que el cliente tenga una cuenta
            if (cliente.Cuenta == null)
            {
                throw new ClienteSinCuentaException();
            }

            // validacion de negocio limite del saldo correspondiente con la cuenta
            if (cliente.Cuenta.Saldo * 18 > limiteSolicitado)
            {
                throw new ClienteSinLimiteException();
            }

            TarjetaCredito tarjeta = new TarjetaCredito((int)tipo, (int)periodo, plastico,limiteSolicitado, cliente.id);

            TransactionResult result = _tarjetaMapper.Alta(tarjeta);

            if (!result.IsOk)
            {
                throw new Exception("Error al dar de alta. Detalle: " + result.Error);
            }

        }


       
        // algoritmo inventado
        public string CalcularNroPlastico(Cliente cliente, TipoTarjetaEnum tipo, PeriodoEnum periodo)
        {

            string plasticoBase = "43001000" + DateTime.Now.Millisecond.ToString(); // base para concatenar

            string resultado = plasticoBase + ((int)tipo).ToString() + ((int)periodo) + cliente.id.ToString();

            if (tipo == TipoTarjetaEnum.AMEX)
                resultado = resultado.Substring(1, 15);

            return resultado;
        }

       
    }
}
