namespace Patterns.Structural.Decorator.ConceptualExample;

public abstract class Component
{
    public abstract string Operation();
}

public class ConcreteComponent : Component
{
    public override string Operation()
    {
        return "Concrete component";
    }
}

public abstract class Decorator : Component
{
    protected Component _component;

    public Decorator(Component component)
    {
        _component = component;
    }

    public override string Operation()
    {
        return this._component.Operation();
    }
}

// Concrete Decorators call the wrapped object and alter its result in some way.
public class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(Component component) : base(component)
    {
    }
    // Decorators may call parent implementation of the operation, instead
    // of calling the wrapped object directly. This approach simplifies
    // extension of decorator classes.
    public override string Operation()
    {
        return $"ConcreteDecoratorA({base.Operation()})";
    }
}

// Decorators can execute their behavior either before or after the call to a wrapped object.
public class ConcreteDecoratorB : Decorator
{
    public ConcreteDecoratorB(Component comp) : base(comp)
    {
    }

    public override string Operation()
    {
        return $"ConcreteDecoratorB({base.Operation()})";
    }
}
