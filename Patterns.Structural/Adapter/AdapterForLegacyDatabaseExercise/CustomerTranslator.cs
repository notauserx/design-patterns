namespace Patterns.Structural.Adapter.AdapterForLegacyDatabaseExercise;

// Define a class that acts as a translator between the standard format and the proprietary format.
public class CustomerTranslator
{
    public Customer TranslateFromLegacy(LegacyCustomer legacyCustomer)
    {
        return new Customer
        {
            Id = legacyCustomer.CustomerId,
            Name = legacyCustomer.CustomerFullName,
            Email = legacyCustomer.CustomerEmailAddress
        };
    }

    public LegacyCustomer TranslateToLegacy(Customer customer)
    {
        return new LegacyCustomer
        {
            CustomerId = customer.Id,
            CustomerFullName = customer.Name,
            CustomerEmailAddress = customer.Email
        };
    }
}
