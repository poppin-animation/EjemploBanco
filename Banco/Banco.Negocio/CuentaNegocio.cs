using Banco.Datos;
using Banco.Entidades.Dominio;
using Banco.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Negocio
{
    public class CuentaNegocio
    {
        private CuentaMapper _cuentaMapper;

        public CuentaNegocio()
        {
            _cuentaMapper = new CuentaMapper();
        }

        public Cuenta TraerPorCliente(int idCliente)
        {
            return _cuentaMapper.Traer(idCliente);
        }

        public Cuenta Alta(Cuenta cuenta)
        {
            TransactionResult result = _cuentaMapper.Alta(cuenta);

            if (result.IsOk)
            {
                return _cuentaMapper.Traer(cuenta.idCliente);
            }
            else
                return null;
            
        }

        public Cuenta Update(Cuenta cuenta)
        {
            TransactionResult result = _cuentaMapper.Actualizar(cuenta);

            if (!result.IsOk)
            {
                //ir a buscar la cuenta nuevamente
                return _cuentaMapper.Traer(cuenta.idCliente);
            }
            else
            {
                return cuenta;
            }

            
        }
    }
}
