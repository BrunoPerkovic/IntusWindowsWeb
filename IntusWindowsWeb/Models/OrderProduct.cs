namespace IntusWindowsWeb.Models;

public class OrderProduct : DbBase
{
    public int OrderId { get; set; }
    public OrderData Order { get; set; }

    public int ProductId { get; set; }
    public ProductData Product { get; set; }
}