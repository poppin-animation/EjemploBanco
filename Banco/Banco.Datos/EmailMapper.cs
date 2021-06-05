using Banco.Entidades.Dominio;
using Banco.Entidades.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Datos
{
    // alumnocai1@yopmail.com
    public class EmailMapper
    {
       
        public TransactionResult Insertar(Email email)
        {
            NameValueCollection obj = ReverseMap(email);

            string json = WebHelper.Post("utilidades", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            return lst;
        }
        private NameValueCollection ReverseMap(Email email)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("para", email.Para);
            n.Add("asunto", email.Asunto  );
            n.Add("mensaje", email.Mesnsaje);
            
            return n;
        }
    }
}
