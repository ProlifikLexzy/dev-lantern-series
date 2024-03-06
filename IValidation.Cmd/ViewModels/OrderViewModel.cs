namespace DevSeries.Cmd.Models;
public class OrderViewModel
{
    public Guid Id { get; set; }
    public decimal Cost { get; set; }
    public IEnumerable<OrderDetail>? OrderDetails { get; set; }
}
