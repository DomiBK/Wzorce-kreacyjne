namespace RefactoringGuru
{
    
    abstract class Creator
    {
        
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            
            var product = FactoryMethod();
            
            var result = "Creator: The same creator's code has just worked with "
                + product.Operation();

            return result;
        }
    }

    
    class ConcreteCreator1 : Creator
    {
        
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }

   

    
    public interface IProduct
    {
        string Operation();
    }

    
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{wypiek}";
        }
    }

  

    class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            
        }

       
        public void ClientCode(Creator creator)
        {
            
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.SomeOperation());
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}
