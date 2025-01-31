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
                .Match<Customer>(() => customer, IsOrderInvalid());
            Then()
                .Do(ctx => UpdateCustomer(customer));
        }

        private void UpdateCustomer(Customer customer)
        {
            customer.HasValidOrder = false;
        }

        private Expression<Func<Customer, bool>> IsOrderInvalid()
        {
            return c => c.Order.GetInvalidItems(c.DietaryRestriction).Any();
        }
    }
}
