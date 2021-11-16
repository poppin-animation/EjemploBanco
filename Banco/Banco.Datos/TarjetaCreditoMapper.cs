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
    public class TarjetaCreditoMapper
    {


        public List<TarjetaCredito> Traer()
        {
            string json2 = WebHelper.Get("TarjetaCredito/" + "1");
            List<TarjetaCredito> resultado = MapList(json2);
            return resultado;
        }

        private List<TarjetaCredito> MapList(string json2)
        {
            List<TarjetaCredito> lst = JsonConvert.DeserializeObject<List<TarjetaCredito>>(json2);
            return lst;
        }

        public TransactionResult Alta(TarjetaCredito tarjeta)
        {
            NameValueCollection obj = ReverseMapAlta(tarjeta);

            string json = WebHelper.Post("TarjetaCredito", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }


       
        private NameValueCollection ReverseMapAlta(TarjetaCredito tarjeta)
        {
            NameValueCollection nv = new NameValueCollection();
            nv.Add("tipo", tarjeta.Tipo.ToString());
            nv.Add("periodoVencimiento", tarjeta.Periodo.ToString());
            nv.Add("limiteCompra", tarjeta.LimiteCompra.ToString("0.00"));
            nv.Add("nroPlastico", tarjeta.NroPlastico);
            nv.Add("usuario", "1");
            nv.Add("idCliente", "1");

            return nv;
        }
    }
}
