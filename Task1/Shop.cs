class Shop
{
    class Shop : Product{

    public Shop(string name, int price){}

    public List<Product> products = new List<Product>();

    void AddProduct(Product product)
    {
        products.Add(product);
    }

    void RemoveProduct(Product product)
    {
        products.Find(product);
    }

    void PrintProductList()
    {
        foreach (var prod in products)
        {
            System.Console.WriteLine(Name);
            System.Console.WriteLine(Price);
        }
    }


}

}