using System.Text;

public class Order
{
  private List<Product> products = new List<Product>();
  private Customer customer;

  public Order(Customer customer)
  {
    this.customer = customer;
  }

  public void AddProduct(Product product)
  {
    products.Add(product);
  }

  public decimal GetTotalCost()
  {
    decimal total = 0;
    foreach (var product in products)
    {
      total += product.GetTotalCost();
    }
    total += customer.IsInUSA() ? 5 : 35;
    return total;
  }

  public string GetPackingLabel()
  {
    StringBuilder sb = new StringBuilder();
    sb.AppendLine("Packing Label:");
    foreach (var product in products)
    {
      sb.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
    }
    return sb.ToString();
  }

  public string GetShippingLabel()
  {
    StringBuilder sb = new StringBuilder();
    sb.AppendLine("Shipping Label:");
    sb.AppendLine(customer.GetName());
    sb.AppendLine(customer.GetAddress().GetFullAddress());
    return sb.ToString();
  }
}
