public enum TypeProduct
{

};


class Products
{
    public string NameProduct { get; private set; }
    public decimal PriseProduct { get; protected set; }
    public int ProductCount { get; set; }
    public Products(string nameProduct, Enum typeProduct, decimal priseProduct, int productCount)
    {
        NameProduct = nameProduct;
    }
}