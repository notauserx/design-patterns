namespace Patterns.Structural.Adapter.AdapterForLegacyDatabaseExercise;

// Define classes that represent the standard format used by the modern data access framework.
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}
