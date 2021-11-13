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

        public List<Cliente> TraerSinCuentas()
        {
            _listaClientes = _clinteMapper.TraerTodos();
            return _listaClientes;
        }
            public List<Cliente> TraerConCuentas()
        {
            // Traigo del servicio los clientes
            _listaClientes = _clinteMapper.TraerTodos();
            _cuentas = _cuentaMapper.TraerTodos();

            // REGLAS DE NEGOCIO > sean mayores, activos, pares, etc

            // va con try catch  y validaciones

            foreach (var cliente in _listaClientes)
            {
                foreach (var cuenta in _cuentas)
                {
                    if (cuenta.idCliente == cliente.id)
                        cliente.Cuenta = cuenta;
                }

                // con lambda
                //cliente.Cuenta = _cuentas.SingleOrDefault(x=>x.idCliente == cliente.id);
            }


            return _listaClientes;
        }

        public TransactionResult Agregar(string nombre, string apellido, DateTime fechaNac, long dni, string tel, string dir,bool act, string email = "alumnocai1@yopmail.com")
        {
            Cliente cliente = new Cliente();
            
            cliente.Nombre = nombre;
            cliente.Ape = apellido;
            cliente.DNI = dni; 
            cliente.Email = email; // validacion si tiene arroba
            cliente.Direccion = dir;
            cliente.Activo = act;
            cliente.Telefono = tel; // validacion formato
            cliente.FechaNac =  fechaNac; // validacion si es una fecha válida

            TransactionResult result = _clinteMapper.Insertar(cliente);

            if (result.IsOk)
            {
                //mandar mail
                //Email emailAEnviar = new Email(cliente.Email,"ALTA CLIENTE EXITOSA","Bienvenido a Banco S.A.");
                //TransactionResult resultadoEnvioMail = _emailMapper.Insertar(emailAEnviar);

                
            }

            return result;
        }

        public TransactionResult Modificar(int codigo, string nombre, string apellido, DateTime fechaNac, long dni, string telefono, string direccion, bool activo, string email)
        {
            Cliente cliente = new Cliente();
            cliente.id = codigo;
            cliente.Nombre = nombre;
            cliente.Ape = apellido;
            cliente.DNI = dni;
            cliente.Email = email; // validacion si tiene arroba
            cliente.Direccion = direccion;
            cliente.Activo = activo;
            cliente.Telefono = telefono; // validacion formato
            cliente.FechaNac = fechaNac; // validacion si es una fecha válida

            TransactionResult result = _clinteMapper.Actualizar(cliente);

            if (result.IsOk)
            {
                //mandar mail
                //Email emailAEnviar = new Email(cliente.Email,"ALTA CLIENTE EXITOSA","Bienvenido a Banco S.A.");
                //TransactionResult resultadoEnvioMail = _emailMapper.Insertar(emailAEnviar);

            }

            return result;
        }
    }
}
