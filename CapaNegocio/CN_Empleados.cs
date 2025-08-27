
using System.Collections.Generic;
using CapaDatos;

namespace CapaNegocio
{
    public struct SalarioDTA
    {
        public string Codigo;
        public string Nombre;
        public string Apellido;
        public string Cargo;
        public double SalarioBase;
        public double Salud;
        public double Pension;
        public double Transporte;
        public double SalarioNeto;
    }

    public class CN_Empleados
    {
        //Instanciar un objeto de la clase CD_Cliente
        private readonly CD_Empleado objCDEmp = new CD_Empleado();
        private readonly CD_Nomina objCDNom = new CD_Nomina();
        private readonly double SalarioMinimo = 2847000;

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
            objCDEmp.RegistrarEmpleado(empleado);
        }

        public List<object> BuscarEmpleado(string codigo)
        {
            List<object> listaEmpleados = new List<object>();
            List<Empleado> data = objCDEmp.BuscarEmpleado(codigo);
            if (data.Count > 0)
            {
                listaEmpleados.Add(data[0]);
            }
            return listaEmpleados;
        }

        public List<object> ListarEmpleados()
        {
            List<object> listaEmpleados = new List<object>();
            foreach (var empleado in objCDEmp.ListarEmpleados())
            {
                listaEmpleados.Add((empleado));
            }
            return listaEmpleados;
        }
    
        public SalarioDTA? CalcularSalario(string codigo)
        {
            List<Empleado> data = objCDEmp.BuscarEmpleado(codigo);
            if (data.Count > 0)
            {
                Empleado empleado = data[0];
                double salario_base = double.Parse(empleado.Salario_base);
                double salud = salario_base * 0.04;
                double pension = salario_base * 0.04;
                double transporte = (salario_base < SalarioMinimo) ? 200000 : 0;
                double salario_neto = salario_base - salud - pension + transporte;
                Nomina nomina = new Nomina(empleado) 
                {
                    Salud = salud,
                    Pension = pension,
                    Auxilio = transporte,
                    Neto = salario_neto
                };

                objCDNom.GuardarNomina(nomina);

                return new SalarioDTA() 
                {
                    Codigo = empleado.Codigo,
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
    
        public List<SalarioDTA> ObtenerNomina()
        {

            List<Nomina> listado = objCDNom.ListarNomina();
            List<SalarioDTA> salarios = new List<SalarioDTA>();
            if (listado.Count < 1)
            {
                return salarios;
            }

            foreach (Nomina item in listado)
            {
                salarios.Add(new SalarioDTA 
                {
                    Codigo = item.Codigo,
                    Nombre = item.Nombre,
                    Apellido = item.Apellido,
                    Cargo = item.Cargo,
                    SalarioBase = item.SalarioBase,
                    Salud = item.Salud,
                    Pension = item.Pension,
                    Transporte = item.Auxilio,
                    SalarioNeto = item.Neto
                });
            }

            return salarios;

        }
    }
}
