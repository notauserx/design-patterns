using Patterns.Structural.Adapter.AdapterForLegacyDatabaseExercise;

namespace Patterns.Structural.Tests.Adapter;

public class AdapterForLegacyDatabaseExerciseTests
{
    private readonly LegacyDatabaseAdapter _adapter;

    public AdapterForLegacyDatabaseExerciseTests()
    {
        _adapter = new LegacyDatabaseAdapter();
    }

    [Fact]
    public void AddCustomer_ShouldAddNewCustomerToLegacyDatabase()
    {
        // Arrange
        var customer = new Customer
        {
            Id = 1,
            Name = "John Doe",
            Email = "johndoe@example.com"
        };

        // Act
        _adapter.AddCustomer(customer);
        var customerReturned = _adapter.GetCustomerById(1);

        // Assert
        Assert.Equal(1, customerReturned.Id);
        Assert.Equal("John Doe", customerReturned.Name);
        Assert.Equal("johndoe@example.com", customerReturned.Email);
    }

    [Fact]
    public void GetCustomerById_ShouldReturnCustomerFromStandardDatabase()
    {
        // Arrange
        var customer = new Customer
        {
            Id = 2,
            Name = "Jane Doe",
            Email = "janedoe@example.com"
        };
        _adapter.AddCustomer(customer);

        // Act
        var result = _adapter.GetCustomerById(2);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("Jane Doe", result.Name);
        Assert.Equal("janedoe@example.com", result.Email);
    }

    [Fact]
    public void GetCustomers_ShouldReturnAllCustomersFromStandardDatabase()
    {
        // Arrange
        var customer1 = new Customer
        {
            Id = 3,
            Name = "Bob Smith",
            Email = "bobsmith@example.com"
        };
        var customer2 = new Customer
        {
            Id = 4,
            Name = "Alice Johnson",
            Email = "alicejohnson@example.com"
        };
        _adapter.AddCustomer(customer1);
        _adapter.AddCustomer(customer2);

        // Act
        var result = _adapter.GetCustomers();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count);
        Assert.Contains(result, c => c.Id == 3 && c.Name == "Bob Smith" && c.Email == "bobsmith@example.com");
        Assert.Contains(result, c => c.Id == 4 && c.Name == "Alice Johnson" && c.Email == "alicejohnson@example.com");
    }
}