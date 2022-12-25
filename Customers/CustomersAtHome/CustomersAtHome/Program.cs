//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DomainLayer.Models;
using ServiceLayer;

Customer customer = new Customer(1,"Shaiq","Kazimov","Sedmoy","Developer",25);
Customer customer2 = new Customer(2,"Cinare","Ibadova","Lokbatan","Developer",22);
Customer customer3 = new Customer(3,"Cahandar","Velibeyli","Xetai","Developer",27);
Customer customer4 = new Customer(4,"Cavid","Ismayilzade","Hokmeli","Developer",23);
Customer[] arr = { customer, customer2, customer3, customer4 };

ReturnAgeCustomers returnage = new ReturnAgeCustomers();
Console.WriteLine(returnage.ReturnAge(arr));
Console.WriteLine(returnage.AverageAge(arr));