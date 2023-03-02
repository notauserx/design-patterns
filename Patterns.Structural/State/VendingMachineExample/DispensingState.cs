namespace Patterns.Structural.State.VendingMachineExample;

public class DispensingState : IVendingMachineState
{
    public void InsertMoney(VendingMachine vendingMachine)
    {
        Console.WriteLine("Money has already been inserted.");
    }

    public void MakeSelection(VendingMachine vendingMachine)
    {
        Console.WriteLine("Snack is already being dispensed.");
    }

    public void DispenseSnack(VendingMachine vendingMachine)
    {
        Console.WriteLine("Dispensing snack...");
        vendingMachine.SetState(vendingMachine.IdleState);
    }
}
