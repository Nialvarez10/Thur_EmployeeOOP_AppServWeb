using EmployeeOOP.Classes;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int day, month, year, id;
            string firstName, lastName;
            decimal salary,hourValue;
            bool isActive;
            float hours;



            Console.WriteLine("OPP APPLICATION");
            Console.WriteLine("---------------");


            Console.Write("Ingresar el dia: ");
            day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar el mes: ");
            month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar el año: ");
            year = Convert.ToInt32(Console.ReadLine());

            //Inicialización clase Date
            Date dateObject = new Date(day, month, year);
            Console.WriteLine();
            Console.WriteLine(dateObject.ToString());

            Console.WriteLine();

            Console.WriteLine("---------------------------SALARIO----------------------------");

            Console.Write("Ingresar su identificación: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar nombre completo: ");
            firstName = Console.ReadLine();

            Console.Write("Ingresar apellidos completos: ");
            lastName = Console.ReadLine();

            Console.Write("Ingresar salario devengado: ");
            salary = decimal.Parse(Console.ReadLine());

            //HardCoding= Quemar codigo
            SalaryEmployee salaryEmployee = new SalaryEmployee()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = dateObject,
                HiringDate = dateObject,
                IsActive = true,
                Salary = salary,
            };

            Console.WriteLine(salaryEmployee);

            Console.WriteLine("---------------------------PORCENTAJE VENTAS----------------------------");

            Employee commissionEmployee = new CommissionEmployee()
            {
                Id = 30000,
                FirstName = "Camila",
                LastName = "Perez Zapata",
                BirthDate = dateObject,
                HiringDate = dateObject,
                IsActive = false,
                CommisionPercentaje = 7,
                Sales = 3000000,
            };

            Console.WriteLine(commissionEmployee);

            Console.WriteLine("---------------------------VALOR HORA----------------------------");

            Console.Write("Ingresar su identificación: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar nombre completo: ");
            firstName = Console.ReadLine();

            Console.Write("Ingresar apellidos completos: ");
            lastName = Console.ReadLine();

            Console.Write("Eres empleado activo (true/false): ");
            isActive =Convert.ToBoolean(Console.ReadLine());

            Console.Write("Ingresar horas: ");
            hours = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingresar valor x hora: ");
            hourValue = Convert.ToDecimal(Console.ReadLine());

            Employee hourtyEmployee = new HourtyEmployee()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = dateObject,
                HiringDate = dateObject,
                IsActive = isActive,
                Hours = hours,
                HourValue = hourValue,
                
            };

            Console.WriteLine(hourtyEmployee);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());

        }
    }
}