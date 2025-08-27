using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Nomina
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public double SalarioBase { get; set; }
        public double Salud { get; set; }
        public double Pension { get; set; }
        public double Auxilio { get; set; }
        public double Neto { get; set; }

        public Nomina() { }

        public Nomina(Empleado empleado)
        {
            Codigo = empleado.Codigo;
            Nombre = empleado.Nombre;
            Apellido = empleado.Apellido;
            Cargo = empleado.Cargo;
            SalarioBase = double.Parse(empleado.Salario_base);
        }

        // Convierte en línea para archivo plano
        public string LineaArchivo()
        {
            return $"{Codigo},{Nombre},{Apellido},{Cargo},{SalarioBase},{Salud},{Pension},{Auxilio},{Neto}";
        }

        // Leer desde línea del archivo
        public Nomina SepararLinea(string linea)
        {
            var datos = linea.Split(',');
            return new Nomina
            {
                Codigo = datos[0],
                Nombre = datos[1],
                Apellido = datos[2],
                Cargo = datos[3],
                SalarioBase = double.Parse(datos[4]),
                Salud = double.Parse(datos[5]),
                Pension = double.Parse(datos[6]),
                Auxilio = double.Parse(datos[7]),
                Neto = double.Parse(datos[8])
            };
        }

    }//clase
}
