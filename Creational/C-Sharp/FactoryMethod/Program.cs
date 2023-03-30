public interface IProduct
{
    public string Operation();
}

public class ConcreteProductA : IProduct
{
    public string Operation()
    {
        return "result of Concrete Product A";
    }
}

public class ConcreteProductB : IProduct
{
    public string Operation()
    {
        return "result of Concrete Product B";
    }
}

public abstract class Creator
{
    public abstract IProduct FactoryMethod(); 
    
    public string SomeOperation()
    {
        var product = FactoryMethod();
        var res = "Creator: " + product.Operation();
        return res;
    }

}
public class ConcreteCreatorA : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductA();
    }
}
public class ConcreteCreatorB : Creator
{
    public override IProduct FactoryMethod()
    {
       return new ConcreteProductB();
    }
    
}


public class Program 
{
    public static void Main(string[] args)
    {
        ClientCode(new ConcreteCreatorA());
        ClientCode(new ConcreteCreatorB());
    }

    public static void ClientCode(Creator creator)
    {
        Console.WriteLine("Clietn:" + creator.SomeOperation());
    }
}