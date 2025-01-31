using InterviewCR.Models;
using NRules.Fluent.Dsl;
using System;

namespace InterviewCR.Rules
{
    public class ValidOrderRule : Rule
    {
        public override void Define()
        {
            Customer customer = default;

            When()
                .Match<Customer>(() => customer, c => c.HasValidOrder);
            Then()
                .Do(ctx => NotifyValidOrder(customer));
        }

        private void NotifyValidOrder(Customer customer)
        {
            Console.WriteLine($"{customer.Name} paid ${customer.Order.TotalCost()} for: \n{customer.Order.Print()}");
        }
    }
}
