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
    public class CuentaMapper
    {
        public Cuenta Traer(int idCliente)
        {
            string json2 = WebHelper.Get("cuenta/" + idCliente.ToString()); // trae un texto en formato json de una web
            Cuenta resultado = Map(json2);
            return resultado;
        }

        public List<Cuenta> TraerTodos()
        {
            string json2 = WebHelper.Get("cuenta");
            List<Cuenta> resultado = MapList(json2);
            return resultado;
        }

        private Cuenta Map(string json2)
        {
            Cuenta lst = JsonConvert.DeserializeObject<Cuenta>(json2);
            return lst;
        }

        private List<Cuenta> MapList(string json2)
        {
            List<Cuenta> lst = JsonConvert.DeserializeObject<List<Cuenta>>(json2);
            return lst;
        }

        public TransactionResult Alta(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMapAlta(cuenta);

            string json = WebHelper.Post("cuenta", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }


        public TransactionResult Actualizar(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMapActualizar(cuenta);

            string json = WebHelper.Post("cuenta", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }

        private NameValueCollection ReverseMapAlta(Cuenta cuenta)
        {
            NameValueCollection nv = new NameValueCollection();

            nv.Add("idCliente", cuenta.idCliente.ToString());
            nv.Add("Descripcion", cuenta.Descripcion);

            return nv;
        }

        private NameValueCollection ReverseMapActualizar(Cuenta cuenta)
        {
            NameValueCollection nv = new NameValueCollection();

            nv.Add("id", cuenta.id.ToString());
            nv.Add("Saldo", cuenta.Saldo.ToString());

            return nv;
        }
    }
}
