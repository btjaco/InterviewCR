using NRules.Fluent.Dsl;

namespace InterviewCR.Rules
{
    public class OrderValidationRule : Rule
    {
        public override void Define()
        {
            Order order = null;
            When()
                .Match<Order>(() => order);
            Then()
        }
    }
}
