using EmployeeOOP.Classes;
try
{
    int day, month, year;
    string firstName, LastName;
   

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
    Console.WriteLine("/n");
    Console.WriteLine(dateObject.ToString());

    //HardCoding= Quemar codigo
    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = Decimal.Parse(Console.ReadLine()),
    };


    Console.Write("Ingresar nombre completo");
    firstName= Console.ReadLine();

    Console.Write("Ingresar apellidos completos");
    LastName = Console.ReadLine();



    Console.WriteLine(salaryEmployee);


}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());

}


