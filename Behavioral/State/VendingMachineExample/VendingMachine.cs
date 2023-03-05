namespace Behavioral.State.VendingMachineExample;

public class VendingMachine
{
    public IVendingMachineState IdleState { get; private set; }
    public IVendingMachineState MoneyInsertedState { get; private set; }
    public IVendingMachineState DispensingState { get; private set; }
    public IVendingMachineState CurrentState { get; private set; }

    public VendingMachine()
    {
        IdleState = new IdleState();
        MoneyInsertedState = new MoneyInsertedState();
        DispensingState = new DispensingState();

        CurrentState = IdleState;
    }

    public void SetState(IVendingMachineState state)
    {
        CurrentState = state;
    }

    public void InsertMoney()
    {
        CurrentState.InsertMoney(this);
    }

    public void MakeSelection()
    {
        CurrentState.MakeSelection(this);
    }

    public void DispenseSnack()
    {
        CurrentState.DispenseSnack(this);
    }
}
