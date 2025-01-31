using InterviewCR.Models;
using NRules.Fluent.Dsl;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace InterviewCR.Rules
{
    public class OrderValidationRule : Rule
    {
        public override void Define()
        {
            Customer customer = null;
            When()
                .Match<Customer>(() => customer, IsOrderValid());
            Then()
                .Do(ctx => ctx.Insert(new InvalidOrderNotification { Customer = customer }));
        }

        private Expression<Func<Customer, bool>> IsOrderValid()
        {
            return c => c.Order.GetInvalidItems(c.DietaryRestriction).Any();
        }
    }
}
