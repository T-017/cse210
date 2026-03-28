using System;

public class Order
{
  private List<Product> _products = new List<Product>();
  private Customer _customer;

  public Order(Customer customer)
  {
    _customer = customer;
  }

  public void AddProduct(Product product)
  {
    _products.Add(product);
  }

  public double GetTotalCost()
  {
    double totalCost = 0;
    foreach (var product in _products)
    {
      totalCost += product.GetTotalPrice();
    }
    double shippingCost = _customer.IsInUSA() ? 5.0 : 35.0;
    totalCost += shippingCost;
    return totalCost;
  }

  public string GetPackingLabel()
  {
    string label = "Packing Label:\n";
    foreach (var product in _products)
    {
      label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
    }
    return label.TrimEnd();
  }

  public string GetShippingLabel()
  {
    return $"Shipping to:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
  }
}