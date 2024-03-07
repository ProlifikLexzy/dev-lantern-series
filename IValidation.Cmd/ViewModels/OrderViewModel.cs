namespace DevSeries.Cmd.Models;
public class OrderViewModel
{
    public Guid Id { get; set; }
    public decimal TotalAmount { get; set; }
    public IEnumerable<ProductViewModel>? ProductList { get; set; }
}