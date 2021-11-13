using Banco.Entidades.Dominio;
using Banco.Entidades.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Datos
{
    public class ClienteMapper
    {
        public List<Cliente> TraerTodos()
        {
            string json2 = WebHelper.Get("cliente"); // trae un texto en formato json de una web
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }

        private List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json); // deserializacion
            return lst;
        }

        public TransactionResult Insertar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente); //serializacion -> json
            
            string json = WebHelper.Post("cliente", obj);
            
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        public TransactionResult Actualizar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);

            string json = WebHelper.Put("cliente", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", cliente.id.ToString());
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Ape);
            n.Add("Direccion", cliente.Direccion);
            n.Add("Telefono", cliente.Telefono);
            n.Add("Email", cliente.Email);
            n.Add("DNI", cliente.DNI.ToString());
            n.Add("Activo", cliente.Activo.ToString());
            n.Add("FechaNacimiento", cliente.FechaNac.ToString("yyyy-MM-dd"));
            n.Add("Usuario", "41218");
            return n;
        }

       
    }
}
