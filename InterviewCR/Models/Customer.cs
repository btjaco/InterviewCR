using InterviewCR.Enums;
using InterviewCR.Interfaces;

namespace InterviewCR.Models
{
    public class Customer
    {
        public string Name { get; private set; }
        public Order Order { get; private set; }
        public DietaryRestrictions DietaryRestriction { get; private set; }

        public Customer(string name, DietaryRestrictions dietaryRestrictions)
        {
            Name = name;
            DietaryRestriction = dietaryRestrictions;
            Order = new Order();
        }

        public void OrderFood(params IItem[] items)
        {
            foreach (IItem item in items)
            {
                Order.AddToOrder(item);
            }
        }
    }
}
