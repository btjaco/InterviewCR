using InterviewCR.Models;
using NRules.Fluent.Dsl;
using NRules.RuleModel;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace InterviewCR.Rules
{
    public class OrderValidationRule : Rule
    {
        public override void Define()
        {
            Customer customer = default;

            When()
                .Match<Customer>(() => customer, IsOrderInvalid(), c => c.HasValidOrder);
            Then()
                .Do(ctx => UpdateCustomer(ctx, customer));
        }

        private void UpdateCustomer(IContext ctx, Customer customer)
        {
            customer.HasValidOrder = false;

            ctx.Update(customer);
        }

        private Expression<Func<Customer, bool>> IsOrderInvalid()
        {
            return c => c.Order.GetInvalidItems(c.DietaryRestriction).Any();
        }
    }
}
