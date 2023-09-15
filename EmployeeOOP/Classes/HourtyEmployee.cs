using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public class HourtyEmployee : Employee
    {
        #region Properties

        public decimal Hours { get; set; }
        public decimal HourValue { get; set; }

        #endregion

        #region Methods

        public HourtyEmployee()
        {

        }

        public override decimal GetValueToPay()
        {
            // Calcular el salario basado en las horas trabajadas y el valor por hora
            decimal salary = Hours * HourValue;
            return salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Horas Trabajadas: {Hours:F2}\n" +
                   $"Valor por Hora: {HourValue:C2}\n" +
                   $"Salario Devengado: {GetValueToPay():C2}\n\t";
        }

        #endregion
    }
}
