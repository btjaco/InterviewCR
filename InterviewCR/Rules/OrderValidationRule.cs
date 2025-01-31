using InterviewCR.Enums;
using InterviewCR.Models;
using NRules.Fluent.Dsl;
using System;

namespace InterviewCR.Rules
{
    public class OrderValidationRule : Rule
    {
        public override void Define()
        {
            Customer customer = null;
            When()
                .Match<Customer>(() => customer);
            Then()
                .Do(_ => ValidateOrder(customer));
        }

        private void ValidateOrder(Customer customer)
        {
            bool validOrder = true;

            foreach (MenuItem item in customer.Order.GetAllMenuItems())
            {
                if (customer.DietaryRestriction != DietaryRestrictions.NONE && item.DietaryRestriction != customer.DietaryRestriction)
                {
                    Console.WriteLine($"Invalid Order: {customer.Name} cannot have {item.Name} (does not meet {customer.DietaryRestriction} restriction)");
                    validOrder = false;
                }
            }

            if (validOrder)
            {
                Console.WriteLine($"{customer.Name} paid ${customer.Order.TotalCost()} for: \n{customer.Order.Print()}");
            }
        }
    }
}
