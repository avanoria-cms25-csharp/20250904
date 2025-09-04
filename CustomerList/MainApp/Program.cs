using MainApp.Models;

var customer = new Customer();
customer.CustomerName = "Avanoria AB";

customer.ContactInformation = new ContactInformation();
customer.ContactInformation.Email = "kundservice@avanoria.se";
customer.ContactInformation.PhoneNumber = "+46 8 121 470 50";

customer.ContactPerson = new ContactPerson();
customer.ContactPerson.FirstName = "Hans";
customer.ContactPerson.LastName = "Mattin-Lassei";
customer.ContactPerson.Email = "hans.mattin-lassei@avanoria.se";

customer.BillingAddress = new Address();
customer.BillingAddress.AddressLine_1 = "Nordkapsvägen 1";
customer.BillingAddress.PostalCode = "136 57";
customer.BillingAddress.City = "Vega";

customer.DeliveryAddress = new Address();
customer.DeliveryAddress.AddressLine_1 = "Nordkapsvägen 1";
customer.DeliveryAddress.AddressLine_2 = "Godsmottagning Port A";
customer.DeliveryAddress.PostalCode = "136 57";
customer.DeliveryAddress.City = "Vega";