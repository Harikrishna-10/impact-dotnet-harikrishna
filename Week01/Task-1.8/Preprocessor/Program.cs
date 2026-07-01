#define TRIAL_VERSION

using System;

class Product
{
    #region Fields

    private string name;

    #endregion

    #region Properties

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    #endregion

    #region Constructors

    public Product()
    {
        Name = "Visual Studio";
    }

    #endregion

    #region Methods

    public void Display()
    {
        Console.WriteLine(Name);
    }

    #endregion
}

class Program
{
    static void Main()
    {

#if TRIAL_VERSION

        Console.WriteLine("Trial Version");

#else

        Console.WriteLine("Full Version");

#endif

        Product product = new Product();
        product.Display();
    }
}