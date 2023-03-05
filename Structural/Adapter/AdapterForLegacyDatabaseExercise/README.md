Imagine you're working on a project that involves reading data from multiple sources, including a legacy database that stores data in a proprietary format. The legacy database provides an API for accessing the data, but the API is not compatible with the modern data access framework used by the rest of your application.

Your task is to create an adapter that allows your application to access the legacy database using the modern data access framework. 
The adapter should provide a standard interface that is compatible with the rest of your application, while translating between the proprietary format used by the legacy database and the standard format used by the modern data access framework.

To complete this exercise, you should:

- Define the interface that your adapter will provide to the rest of the application. This should include methods for querying and modifying data in the legacy database using the modern data access framework.

- Implement the adapter, which should use the legacy database's API to retrieve and modify data in the proprietary format, and translate between the proprietary format and the standard format used by the modern data access framework.

- Write unit tests to verify that the adapter works correctly, including tests for querying and modifying data in the legacy database using the standard interface provided by the adapter.

This exercise will help you understand how to use the adapter pattern to create a bridge between incompatible interfaces, and how to translate between different data formats to make legacy systems compatible with modern applications.


```mermaid
classDiagram
    class Customer {
        + int Id
        + string Name
        + string Email
    }

    class LegacyCustomer {
        + int CustomerId
        + string CustomerFullName
        + string CustomerEmailAddress
    }

    class CustomerTranslator {
        + Customer TranslateFromLegacy(LegacyCustomer legacyCustomer)
        + LegacyCustomer TranslateToLegacy(Customer customer)
    }

    class LegacyDatabaseAdapter {
        - CustomerTranslator _translator
        - Dictionary<int, LegacyCustomer> _legacyCustomers
        + LegacyDatabaseAdapter()
        + List<Customer> GetCustomers()
        + Customer GetCustomerById(int id)
        + void AddCustomer(Customer customer)
    }

    CustomerTranslator --> Customer
    CustomerTranslator --> LegacyCustomer

    LegacyDatabaseAdapter --> CustomerTranslator
    LegacyDatabaseAdapter --> LegacyCustomer
    LegacyDatabaseAdapter --> List<Customer>

    note right of Customer: Represents\nthe standard format\nused by the\nmodern data\naccess framework
    note right of LegacyCustomer: Represents\nthe proprietary format\nused by the\nlegacy database
    note right of CustomerTranslator: Translates between\nthe standard format\nand the proprietary\nformat
    note right of LegacyDatabaseAdapter: Acts as an adapter\nbetween the rest of the\napplication and the\nlegacy database

```