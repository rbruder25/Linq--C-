using System.Globalization;


namespace Linq.Entities
{
    class Produto
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Produto(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name
                + " ,$ "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
