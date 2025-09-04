using MainApp.Models;

namespace MainApp.Services;

public class CustomerService
{
    private List<Customer> _customerList = [];

    public void Create(Customer customer)
    {   
        customer.CustomerName = customer.CustomerName.Trim();
        _customerList.Add(customer);
    }

    public IEnumerable<Customer> GetAll()
    {
        return _customerList;
    }
}
