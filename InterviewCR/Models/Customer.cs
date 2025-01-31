using InterviewCR.Enums;

namespace InterviewCR.Models
{
    public class Customer
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private Order _order;
        public Order Order
        {
            get => _order;
            set => _order = value;
        }

        private DietaryRestrictions _dietaryRestrictions;
        public DietaryRestrictions DietaryRestrictions
        {
            get => _dietaryRestrictions;
            set => _dietaryRestrictions = value;
        }
    }
}
