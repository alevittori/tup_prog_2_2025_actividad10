using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    internal class Solicitud:IExportable
    {
        int numero;
        string motivo;

        public int Numero { get => numero; set => numero = value; }
        public string Motivo { get => motivo; set => motivo = value; }

        /// <summary>
        /// Metodo para importar datos separados por punto y coma
        /// </summary>
        /// <param name="dato"> linea de datos </param>
        public void Importar(string dato)
        {
            string[] grupo = dato.Split(';');
            Numero = Convert.ToInt32(grupo[0]);
            Motivo = grupo[1];

        }
        /*
        public string Exportar()
        {
            throw new NotImplementedException();    
           // return null;
        }
        */
        public override string ToString()
        {
            return $"{Numero} ({motivo})";
        }
    
    }
}
