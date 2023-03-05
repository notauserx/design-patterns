using Structural.Decorator.ConceptualExample;

namespace Structural.Tests.Decorator;

public class ConceptualExampleTests
{
    public class Client
    {
        // The client code works with all objects using the Component interface.
        // This way it can stay independent of the concrete classes of
        // components it works with.
        public string ClientCode(Component component)
        {
            return component.Operation();
        }
    }

    [Fact]
    public void test_concrete_component()
    {
        var client = new Client();

        var simple = new ConcreteComponent();

        var result = client.ClientCode(simple);

        Assert.Equal("Concrete component", result);
    }

    [Fact]
    public void test_decorator_A()
    {
        var client = new Client();

        var simple = new ConcreteComponent();

        var decoratorA = new ConcreteDecoratorA(simple);

        var result = client.ClientCode(decoratorA);

        Assert.Equal("ConcreteDecoratorA(Concrete component)", result);
    }

    [Fact]
    public void test_decorator_B()
    {
        var client = new Client();

        var simple = new ConcreteComponent();

        var decoratorB = new ConcreteDecoratorB(simple);

        var result = client.ClientCode(decoratorB);

        Assert.Equal("ConcreteDecoratorB(Concrete component)", result);
    }

    [Fact]
    public void test_decorator_A_and_decorator_B()
    {
        var client = new Client();

        var simple = new ConcreteComponent();

        var decoratorA = new ConcreteDecoratorA(simple);
        var decoratorB = new ConcreteDecoratorB(decoratorA);

        var result = client.ClientCode(decoratorB);

        Assert.Equal("ConcreteDecoratorB(ConcreteDecoratorA(Concrete component))", result);
    }
}