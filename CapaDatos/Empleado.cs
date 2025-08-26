using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Empleado
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Edad {  get; set; }
        public string Cargo { get; set; }
        public string Salario_base { get; set; }

        public Empleado() { }

        public Empleado(string codigo, string nombre, string apellido, string edad, string cargo, string salario_base)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Cargo = cargo;
            Salario_base = salario_base;
        }
    }
}
