using InterviewCR.Enums;
using InterviewCR.Interfaces;

namespace InterviewCR.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public Order Order { get; set; }
        public DietaryRestrictions DietaryRestriction { get; set; }

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
