using Banco.Entidades.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades.Modelos
{
    public class OperadorFormulario
    {
        private List<TarjetaCredito> _tarjetas;
        private int _cantidadTarjetas;
        private int _limitePromedio;
        public OperadorFormulario(List<TarjetaCredito> lst) {
            this._tarjetas = lst;
        }

        public List<TarjetaCredito> Tarjetas
        {
            get
            {
                return _tarjetas;
            }
        }
        public int Cantidad
        {
            get
            {
                if (_tarjetas != null)
                    return _tarjetas.Count;
                else
                    return 0;
            }
        }

        // Calcula el limite promedio de todas las tarjetas que vinieron por el constructor
        public double LimitePromedio
        {
            get
            {
                if (_tarjetas != null)
                {
                    double promedio = 0;
                    double total = 0;

                    foreach(TarjetaCredito t in _tarjetas)
                    {
                        total += t.LimiteCompra;
                    }
                    promedio = total / _tarjetas.Count;

                    return promedio;
                }
                else
                    return 0;
            }
        }
    }
}
