using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades.Dominio
{
    public class Email
    {
        private string _para;
        private string _asunto;
        private string _mensaje;

        public string Asunto { get => _asunto; set => _asunto = value; }
        public string Mensaje { get => _mensaje; set => _mensaje = value; }
        public string Para { get => _para; set => _para = value; }

        public Email(string para, string asunto, string mensaje)
        {
            _asunto = asunto;
            _mensaje = mensaje;
            _para = para;

        }
    }
}
