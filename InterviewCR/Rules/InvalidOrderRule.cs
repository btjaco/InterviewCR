using InterviewCR.Interfaces;
using InterviewCR.Models;
using NRules.Fluent.Dsl;
using System;

namespace InterviewCR.Rules
{
    public class InvalidOrderNotification : IOrderNotification
    {
        public Customer Customer { get; set; }
    }

    public class InvalidOrderRule : Rule
    {
        public override void Define()
        {
            Customer customer = null;

            When()
                .Match<Customer>(() => customer, c => !c.HasValidOrder);
            Then()
                .Do(ctx => NotifyInvalidOrder(customer));
        }

        private void NotifyInvalidOrder(Customer customer)
        {
            foreach (MenuItem menuItem in customer.Order.GetInvalidItems(customer.DietaryRestriction))
            {
                Console.WriteLine($"Invalid Order: {customer.Name} cannot have {menuItem.Name} (does not meet {customer.DietaryRestriction} restriction)");
            }
        }
    }
}
