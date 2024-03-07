using DevSeries.Cmd.Models;
using FluentValidation;

namespace DevSeries.Cmd.FluentValidation
{
    public class OrderFluentValidator : AbstractValidator<OrderViewModel>
    {
        public OrderFluentValidator()
        {
            RuleFor(x => x).Custom((order, context) =>
            {
                var sum = order.ProductList?.Sum(l => l.Price * l.Quantity);

                if (sum < order.TotalAmount)
                    context.AddFailure("Insuffucient Amount.");

            });
        }
    }
}
