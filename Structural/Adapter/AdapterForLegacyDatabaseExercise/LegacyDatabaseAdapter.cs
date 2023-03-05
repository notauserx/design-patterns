namespace Structural.Adapter.AdapterForLegacyDatabaseExercise;

// Define a class that represents the adapter that communicates with the legacy database.
public class LegacyDatabaseAdapter
{
    private readonly CustomerTranslator _translator;
    private Dictionary<int, LegacyCustomer> _legacyCustomers;

    public LegacyDatabaseAdapter()
    {
        _translator = new CustomerTranslator();
        _legacyCustomers = new();
    }

    public void SeedLegacyDatabaseAdapter()
    {
        _legacyCustomers = new Dictionary<int, LegacyCustomer>
        {
            { 1, new LegacyCustomer { CustomerId = 1, CustomerFullName = "John Smith", CustomerEmailAddress = "john.smith@example.com" } },
            { 2, new LegacyCustomer { CustomerId = 2, CustomerFullName = "Jane Doe", CustomerEmailAddress = "jane.doe@example.com" } },
            { 3, new LegacyCustomer { CustomerId = 3, CustomerFullName = "Bob Johnson", CustomerEmailAddress = "bob.johnson@example.com" } }
        };
    }

    public List<Customer> GetCustomers()
    {
        List<Customer> customers = new List<Customer>();
        foreach (var legacyCustomer in _legacyCustomers.Values)
        {
            customers.Add(_translator.TranslateFromLegacy(legacyCustomer));
        }
        return customers;
    }

    public Customer GetCustomerById(int id)
    {
        if (_legacyCustomers.ContainsKey(id))
        {
            var legacyCustomer = _legacyCustomers[id];
            return _translator.TranslateFromLegacy(legacyCustomer);
        }
        return null;
    }

    public void AddCustomer(Customer customer)
    {
        LegacyCustomer legacyCustomer = _translator.TranslateToLegacy(customer);
        int newCustomerId = _legacyCustomers.Keys.Count + 1;
        legacyCustomer.CustomerId = newCustomerId;
        _legacyCustomers.Add(newCustomerId, legacyCustomer);
    }
}