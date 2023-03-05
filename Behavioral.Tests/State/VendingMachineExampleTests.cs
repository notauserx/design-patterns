
using Behavioral.State.VendingMachineExample;

namespace Behavioral.Tests.State;

public class VendingMachineExampleTests
{
    [Fact]
    public void VendingMachine_Starts_In_Idle_State()
    {
        // Arrange
        var vendingMachine = new VendingMachine();

        // Assert
        Assert.IsType<IdleState>(vendingMachine.CurrentState);
    }

    [Fact]
    public void InsertMoney_Transitions_From_Idle_To_MoneyInsertedState()
    {
        // Arrange
        var vendingMachine = new VendingMachine();

        // Act
        vendingMachine.InsertMoney();

        // Assert
        Assert.IsType<MoneyInsertedState>(vendingMachine.CurrentState);
    }

    [Fact]
    public void MakeSelection_Fails_In_Idle_State()
    {
        // Arrange
        var vendingMachine = new VendingMachine();

        // Act
        vendingMachine.MakeSelection();

        // Assert
        Assert.IsType<IdleState>(vendingMachine.CurrentState);
    }

    [Fact]
    public void MakeSelection_Transitions_From_MoneyInsertedState_To_DispensingState()
    {
        // Arrange
        var vendingMachine = new VendingMachine();

        // Act
        vendingMachine.InsertMoney();
        vendingMachine.MakeSelection();

        // Assert
        Assert.IsType<DispensingState>(vendingMachine.CurrentState);
    }

    [Fact]
    public void DispenseSnack_Fails_In_Idle_State()
    {
        // Arrange
        var vendingMachine = new VendingMachine();

        // Act
        vendingMachine.DispenseSnack();

        // Assert
        Assert.IsType<IdleState>(vendingMachine.CurrentState);
    }

    [Fact]
    public void DispenseSnack_Fails_In_MoneyInsertedState()
    {
        // Arrange
        var vendingMachine = new VendingMachine();

        // Act
        vendingMachine.InsertMoney();
        vendingMachine.DispenseSnack();

        // Assert
        Assert.IsType<MoneyInsertedState>(vendingMachine.CurrentState);
    }

    [Fact]
    public void DispenseSnack_Transitions_From_DispensingState_To_IdleState()
    {
        // Arrange
        var vendingMachine = new VendingMachine();

        // Act
        vendingMachine.InsertMoney();
        vendingMachine.MakeSelection();
        vendingMachine.DispenseSnack();

        // Assert
        Assert.IsType<IdleState>(vendingMachine.CurrentState);
    }
}
