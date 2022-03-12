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
Console.WriteLine(employee1);

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
Console.WriteLine(employee2);


