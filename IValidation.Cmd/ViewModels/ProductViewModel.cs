using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSeries.Cmd.Models;
public partial class ProductViewModel
{
    public Guid Id { get; set; }
    public string? Barcode { get; set; }
    public double? Quantity { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public decimal? SellingCost { get; set; }
    public decimal? PreviousSellingCost { get; set; }
    public decimal ActualCost { get; set; }
}
