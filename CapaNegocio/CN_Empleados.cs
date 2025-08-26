
using System.Collections.Generic;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Empleados
    {
        //Instanciar un objeto de la clase CD_Cliente
        private readonly CD_Empleado objCD = new CD_Empleado();

        //Invocar los metodos
        public void RegistrarEmpleado(string codigo, string nombre, string apellido, string edad, string cargo, string salario_base)
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
    }
}
