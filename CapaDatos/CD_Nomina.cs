using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace CapaDatos
{
    public class CD_Nomina
    {
        private Nomina nomina = new Nomina();
        private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "nomina.txt");

        public void GuardarNomina(Nomina nomina)
        {
            string carpeta = Path.GetDirectoryName(ruta);
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            File.AppendAllText(ruta, nomina.LineaArchivo() + Environment.NewLine);
        }

        public List<Nomina> ListarNomina()
        {
            var lista = new List<Nomina>();
            if (!File.Exists(ruta)) return lista;

            var lineas = File.ReadAllLines(ruta);
            foreach (var linea in lineas)
            {
                lista.Add(nomina.SepararLinea(linea));
            }
            return lista;
        }

        public List<Nomina> BuscarNomina(string codigo)
        {
            var lista = new List<Nomina>();
            if (!File.Exists(ruta)) return lista;

            var lineas = File.ReadAllLines(ruta);
            foreach (var linea in lineas)
            {
                var n = nomina.SepararLinea(linea);
                if (n.Codigo == codigo)
                {
                    lista.Add(n);
                }
            }
            return lista;
        }

    }
}
