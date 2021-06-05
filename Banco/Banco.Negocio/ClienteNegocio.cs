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
    public class ClienteNegocio
    {
        private ClienteMapper _clinteMapper;
        private CuentaMapper _cuentaMapper;
        private EmailMapper _emailMapper;

        private List<Cliente> _listaClientes;
        private List<Cuenta> _cuentas;

        public ClienteNegocio()
        {
            _clinteMapper = new ClienteMapper();
            _cuentaMapper = new CuentaMapper();
            _listaClientes = new List<Cliente>();
            _cuentas = new List<Cuenta>();
            _emailMapper = new EmailMapper();
        }

        public List<Cliente> Traer()
        {
            // Traigo del servicio los clientes
            _listaClientes = _clinteMapper.TraerTodos();
            _cuentas = _cuentaMapper.TraerTodos();

            // REGLAS DE NEGOCIO > sean mayores, activos, pares, etc

            // va con try catch  y validaciones

            foreach (var cliente in _listaClientes)
            {
                foreach(var cuenta in _cuentas)
                {
                    if(cuenta.idCliente == cliente.id)
                        cliente.Cuenta = cuenta;
                }

                // con lambda
                //cliente.Cuenta = _cuentas.SingleOrDefault(x=>x.idCliente == cliente.id);
            }


            return _listaClientes;
        }

        public TransactionResult Agregar(string nombre, string apellido, string fechaNac, int dni, string email = "alumnocai1@yopmail.com")
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = nombre;
            cliente.Ape = apellido;
            cliente.DNI = dni.ToString();
            cliente.Email = email;

            TransactionResult result = _clinteMapper.Insertar(cliente);

            if (result.IsOk)
            {
                //mandar mail
                Email emailAEnviar = new Email(cliente.Email,"ALTA CLIENTE EXITOSA","Bienvenido a Banco S.A.");
                TransactionResult resultadoEnvioMail = _emailMapper.Insertar(emailAEnviar);
            }

            return result;
        }
    }
}
