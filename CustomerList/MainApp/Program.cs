using MainApp.Models;
using MainApp.Services;

var customerService = new CustomerService();



var customer_1 = new Customer();
customer_1.CustomerName = "  Avanoria AB";

var customer_2 = new Customer();
customer_2.CustomerName = "Nackademin AB  ";

var customer_3 = new Customer();
customer_3.CustomerName = "  Tietoevry";

customerService.Create(customer_1);
customerService.Create(customer_2);
customerService.Create(customer_3);


var customers = customerService.GetAll();

foreach (var customer in customers)
    Console.WriteLine(customer.CustomerName);


Console.ReadKey();
