namespace Patterns.Structural.State.VendingMachineExample;

public interface IVendingMachineState
{
    void InsertMoney(VendingMachine vendingMachine);
    void MakeSelection(VendingMachine vendingMachine);
    void DispenseSnack(VendingMachine vendingMachine);
}
