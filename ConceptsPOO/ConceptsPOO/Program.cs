// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

//Date date1 = new Date(2022,2,11);
//Console.WriteLine(date1);

try
{
    Console.WriteLine(new Date(2022, 2, 28));
    Console.WriteLine(new Date(1975, 4, 11));
    Console.WriteLine(new Date(1985, 11, 31));
}
catch (Exception error)
{
    Console.WriteLine(error.Message );
}


