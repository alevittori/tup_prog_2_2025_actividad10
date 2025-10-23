using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    internal class CentroDeAtencion
    {
        LinkedList<Solicitud> solicitudesEntrantes = new LinkedList<Solicitud>();
        Queue<Solicitud> colaDeAtencion = new Queue<Solicitud>();
        public void ImportarCsvSolicitudesEntrantes(FileStream fs)
        {
            StreamReader sr=null;
            try
            {
                 sr = new StreamReader(fs);
                 string cabecera = sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    Solicitud solicitud = new Solicitud();
                    solicitud.Importar(linea);

                    solicitudesEntrantes.AddLast(solicitud);
                }

                

            }
            catch(Exception ex) { throw new Exception(ex.Message, ex); }
            finally
            {
                if(sr != null) { sr.Close(); }
                
            }
        }
    
        public LinkedListNode<Solicitud> GetSolicitudPendiente()
        {
            return solicitudesEntrantes.First;
        }
    
        public void Atender(Solicitud solicitud)
        {
            solicitudesEntrantes.Remove(solicitud);
            colaDeAtencion.Enqueue(solicitud);
        }

        public string[] VerDescripcionColaAtencion()
        {
            string[] descripciones = new string[colaDeAtencion.Count];
            int n = 0;
            foreach (Solicitud solicitud in colaDeAtencion)
            {
                descripciones[n++] = solicitud.ToString();
            }

            return descripciones;
        }

    }
}
