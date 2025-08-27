
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Empleados
    {
        //Instanciar un objeto de la clase CD_Cliente
        private readonly CD_Empleado objCD = new CD_Empleado();
        private readonly double SalarioMinimo = 2847000;

        public struct SalarioDTA
        {
            public string Nombre;
            public string Apellido;
            public string Cargo;
            public double SalarioBase;
            public double Salud;
            public double Pension;
            public double Transporte;
            public double SalarioNeto;
        }

        //Invocar los metodos
        public void RegistrarEmpleado(string codigo, string nombre, string apellido, 
                                      string edad, string cargo, string salario_base)
        {
            Empleado empleado = new Empleado
            {
                Codigo = codigo,
                Nombre = nombre,
                Apellido = apellido,
                Edad = edad,
                Cargo = cargo,
                Salario_base = salario_base
            };
            objCD.RegistrarEmpleado(empleado);
        }

        public List<object> BuscarEmpleado(string codigo)
        {
            List<object> listaEmpleados = new List<object>();
            List<Empleado> data = objCD.BuscarEmpleado(codigo);
            if (data.Count > 0)
            {
                listaEmpleados.Add(data[0]);
            }
            return listaEmpleados;
        }

        public List<object> ListarEmpleados()
        {
            List<object> listaEmpleados = new List<object>();
            foreach (var empleado in objCD.ListarEmpleados())
            {
                listaEmpleados.Add((empleado));
            }
            return listaEmpleados;
        }
    
        public SalarioDTA? CalcularSalario(string codigo)
        {
            List<Empleado> data = objCD.BuscarEmpleado(codigo);
            if (data.Count > 0)
            {
                Empleado empleado = data[0];
                double salario_base = double.Parse(empleado.Salario_base);
                double salud = salario_base * 0.04;
                double pension = salario_base * 0.04;
                double transporte = (salario_base < SalarioMinimo) ? 200000 : 0;
                double salario_neto = salario_base - salud - pension + transporte;
                return new SalarioDTA() 
                {
                    Nombre = empleado.Nombre,
                    Apellido = empleado.Apellido,
                    Cargo = empleado.Cargo,
                    SalarioBase = salario_base,
                    Salud = salud,
                    Pension = pension,
                    Transporte = transporte,
                    SalarioNeto = salario_neto
                };
            }
            else
            {
                return null;
            }
        }
    }
}
