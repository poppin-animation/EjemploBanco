using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades.Dominio
{
    [DataContract]
    public class TarjetaCredito
    {
        private int _id;
        private int _tipo;
        private int _periodo;
        private string _nroPlastico;
        private string _usuario;
        private int _idCliente;
        private double _limiteCompra;
        private Cliente _cliente;

        public int Id { get => _id; set => _id = value; }

        [DataMember]
        public int Tipo { get => _tipo; set => _tipo = value; }
        
        [DataMember(Name = "PeriodoVencimiento")]
        public int Periodo { get => _periodo; set => _periodo = value; }
        [DataMember]
        public string NroPlastico { get => _nroPlastico; set => _nroPlastico = value; }
        [DataMember]
        public string Usuario { get => _usuario; set => _usuario = value; }
        [DataMember]
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        [DataMember]
        public double LimiteCompra { get => _limiteCompra; set => _limiteCompra = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }

        public TarjetaCredito(int tipo, int periodo, string plastico, string usuario, int idCliente)
        {
            this._tipo = tipo;
            this._periodo = periodo;
            this._nroPlastico = plastico;
            this._usuario = usuario;
            this._idCliente = idCliente;
        }

    }
}
