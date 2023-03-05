namespace Structural.Adapter.AdapterForLegacyDatabaseExercise;

// Define classes that represent the proprietary format used by the legacy database.
public class LegacyCustomer
{
    public int CustomerId { get; set; }
    public string CustomerFullName { get; set; }
    public string CustomerEmailAddress { get; set; }
}
