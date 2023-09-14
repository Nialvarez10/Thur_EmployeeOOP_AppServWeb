using EmployeeOOP.Classes;
try
{
    Console.WriteLine("OPP APPLICATION");
    Console.WriteLine("---------------");
    int day, month, year;

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

}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());

}


