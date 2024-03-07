namespace DevSeries.Cmd.Models;
public partial class ProductViewModel
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public decimal Quantity { get; set; }
    public decimal Price { get; set; }
}
