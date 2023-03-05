namespace Behavioral.State.VendingMachineExample;

public class IdleState : IVendingMachineState
{
    public void InsertMoney(VendingMachine vendingMachine)
    {
        vendingMachine.SetState(vendingMachine.MoneyInsertedState);
    }

    public void MakeSelection(VendingMachine vendingMachine)
    {
        Console.WriteLine("Please insert money first.");
    }

    public void DispenseSnack(VendingMachine vendingMachine)
    {
        Console.WriteLine("Please insert money and make a selection first.");
    }
}
