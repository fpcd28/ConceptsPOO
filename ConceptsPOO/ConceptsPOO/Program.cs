// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

//Date date1 = new Date(2022,2,11);
//Console.WriteLine(date1);

//try
//{
//    Console.WriteLine(new Date(2022, 2, 28));
//    Console.WriteLine(new Date(1975, 4, 11));
//    Console.WriteLine(new Date(1985, 11, 31));
//}
//catch (Exception error)
//{
//    Console.WriteLine(error.Message );
//}

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815.45M
};
//Console.WriteLine(employee1);

Employee employee2 = new commissionEmployee()
{
    Id = 2020,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1991, 7,23),
    HiringDate = new Date(2022, 11, 15),
    IsActive = true,
    Sales = 123000M,
    CommissionPercentaje = 0.03F
};
//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Gonzalo",
    LastName = "Cambona",
    BirthDate = new Date(1993, 1, 23),
    HiringDate = new Date(2021, 11, 15),
    IsActive = true,
    HourValue = 100M,
    Hours = 48F

};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Jazmin",
    LastName = "Salazar",
    BirthDate = new Date(1990, 11, 5),
    HiringDate = new Date(2017, 6, 4),
    IsActive = true,
    Base = 860000M,
    Sales = 5809099M,
    CommissionPercentaje = 0.015F
};
//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{ 
    employee1, employee2, employee3, employee4
};
decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                                 ================");
Console.WriteLine($"Total                          {$"{payroll:C2}",18}");

Invoice invoice1 = new Invoice()
{
    Description = "Iphone i3",
    Id = 1,
    Price = 53000,
    Quantity = 6
};
Invoice invoice2 = new Invoice()
{
    Description = "Posta Preum",
    Id = 2,
    Price = 3200M,
    Quantity = 17.5F
};
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);    
