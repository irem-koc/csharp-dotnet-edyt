// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Business;
using ConsoleApp1.DataAccess.Concretes;
using ConsoleApp1.Entities;

CourseManager courseManager = new(new EfCourseDal());
List<Course> course2 = courseManager.GetAll();
for (int i = 0; i < course2.Count; i++)
{
    Console.WriteLine(course2[i].Name + " / " + course2[i].Price);
}
Console.WriteLine("finito");

Console.WriteLine("test");
//IndividualCustomer customer1 = new();
//customer1.Id = 1;
//customer1.NationalIdentity = "12345678922";
//customer1.FirstName = "Test";
//customer1.LastName = "Koç";
//customer1.CustomerNumber = "123456";

//IndividualCustomer customer2 = new();
//customer2.Id = 2;
//customer2.NationalIdentity = "78922";
//customer2.FirstName = "yest";
//customer2.LastName = "Koç.çç";
//customer2.CustomerNumber = "123456çç";

//CorporateCustomer customer3 = new();
//customer3.Id = 3;
//customer3.Name = "yest";
//customer3.CustomerNumber = "1ç";
//customer3.TaxNumber = "123215564";

//CorporateCustomer customer4 = new();
//customer4.Id = 4;
//customer4.Name = "kest";
//customer4.CustomerNumber = "123456çoo";
//customer4.TaxNumber = "123215erw";

////integer tip: boolean double değer tipi
////referans tip: array, class, interface, string

//BaseCustomer[] customers = {customer1, customer2,customer3, customer4 };

//// polymorphism
////inherit edildiği sınıfın referansını tutabilir base classlar
//foreach (BaseCustomer customer in customers)
//{
//    Console.WriteLine(customer.CustomerNumber);
//}