using InterviewCR.Enums;

namespace InterviewCR.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public Order Order { get; set; }
        public DietaryRestrictions DietaryRestrictions { get; set; }

        public Customer(DietaryRestrictions dietaryRestrictions)
        {
            DietaryRestrictions = dietaryRestrictions;
        }
    }
}
