using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSeries.Cmd.Models;
public partial class ProductViewModel : IValidatableObject
{
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (string.IsNullOrWhiteSpace(this.Title))
        {
            yield return new ValidationResult("Product title is required.", new[] { nameof(this.Title) });
        }
    }
}
