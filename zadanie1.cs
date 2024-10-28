using System;

// Fabryka Metoda Wytwórcza

public interface IProductFactory

{

    Product CreateProduct();

}

public class CakeFactory : IProductFactory

{

    public Product CreateProduct()

    {

        return new Cake();

    }

}

public class BreadFactory : IProductFactory

{

    public Product CreateProduct()

    {

        return new Bread();

    }

}

// Produkt

public abstract class Product

{

    public abstract string Name { get; }

}

public class Cake : Product

{

    public override string Name => "Cake";

}

public class Bread : Product

{

    public override string Name => "Bread";

}

// Fabryka Abstrakcyjna

public interface IMeubleFactory

{

    IMeuble CreateMeuble();

}

public class ModernMeubleFactory : IMeubleFactory

{

    public IMeuble CreateMeuble()

    {

        return new ModernChair() { Style = "Modern" };

    }

}

public class ClassicMeubleFactory : IMeubleFactory

{

    public IMeuble CreateMeuble()

    {

        return new ClassicChair() { Style = "Classic" };

    }

}

// Interfejs Meuble

public interface IMeuble

{

    string Style { get; set; }

}

// Zestaw Mebli

public interface IMeubleSet

{

    string Name { get; }

}

public class ModernChair : IMeuble

{

    public string Style { get; set; }

}

public class ClassicChair : IMeuble

{

    public string Style { get; set; }

}

// Budowniczy

public interface IHouseBuilder

{

    void BuildWalls();

    void BuildRoof();

    void BuildWindows();

    House GetHouse();

}

public class ConcreteHouseBuilder : IHouseBuilder

{

    private House _house = new House();

    public void BuildWalls()

    {

        _house.Walls = "Concrete walls";

    }

    public void BuildRoof()

    {

        _house.Roof = "Concrete roof";

    }

    public void BuildWindows()

    {

        _house.Windows = "Concrete windows";

    }

    public House GetHouse()

    {

        return _house;

    }

}

public class House

{

    public string Walls { get; set; }

    public string Roof { get; set; }

    public string Windows { get; set; }

}

// Prototyp

public abstract class Document

{

    public virtual string Content { get; set; }

}

public class CV : Document

{

    public override string Content => "CV content";

}

// Singleton

public sealed class President

{

    private static President _instance;

    private President() { }

    public static President Instance

    {

        get

        {

            if (_instance == null)

            {

                _instance = new President();

            }

            return _instance;

        }

    }

}
