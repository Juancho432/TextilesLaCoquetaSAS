using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace CapaDatos
{
    public class CD_Empleado
    {
        //Crear objeto Empleado
        private Empleado empleado = new Empleado();

        //Indicar la ruta del archivo
        private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "empleado.txt");

        //Metodo para registrar cliente en el archivo plano
        public void RegistrarEmpleado(Empleado empleado)
        {
            //Validar que la carpeta y el archivo exista
            string carpeta = Path.GetDirectoryName(ruta);
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            //Almacenar cada linea en el archivo plano
            File.AppendAllText(ruta, empleado.LineaArchivo() + Environment.NewLine);
        }

        //Metodo para buscar empleado por ID
        public List<Empleado> BuscarEmpleado(string codigo)
        {
            var lista = new List<Empleado>();

            //Verificar si el archivo existe
            if (!File.Exists(ruta))
            {
                return lista;
            }

            var lineas = File.ReadAllLines(ruta);
            foreach (var linea in lineas)
            {
                var empl = empleado.SepararLinea(linea);
                if (empl.Codigo == codigo)
                {
                    lista.Add(empleado.SepararLinea(linea));
                }
            }

            return lista;
        }

        //Listar todos los empleados
        public List<Empleado> ListarEmpleados()
        {
            var lista = new List<Empleado>();

            //Verificar si el archivo existe
            if (!File.Exists(ruta))
            {
                return lista;
            }

            var lineas = File.ReadAllLines(ruta);
            foreach (var linea in lineas)
            {

                lista.Add(empleado.SepararLinea(linea));
            }

            return lista;
        }

    }
}
