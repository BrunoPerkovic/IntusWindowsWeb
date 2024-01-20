using IntusWindowsAPI.BL.Data;

namespace IntusWindowsWeb.Models;

public class ProductData : DbBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public ProductType Type { get; set; }
    public int Width { get; set; }
    public decimal Height { get; set; }
    public List<OrderProduct> OrderProducts { get; set; }
}