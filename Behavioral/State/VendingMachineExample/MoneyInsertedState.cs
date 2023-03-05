namespace Behavioral.State.VendingMachineExample;

public class MoneyInsertedState : IVendingMachineState
{
    public void InsertMoney(VendingMachine vendingMachine)
    {
        Console.WriteLine("You have already inserted money.");
    }

    public void MakeSelection(VendingMachine vendingMachine)
    {
        vendingMachine.SetState(vendingMachine.DispensingState);
    }

    public void DispenseSnack(VendingMachine vendingMachine)
    {
        Console.WriteLine("Please make a selection first.");
    }
}
