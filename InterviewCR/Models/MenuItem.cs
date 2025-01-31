using InterviewCR.Enums;
using InterviewCR.Interfaces;

namespace InterviewCR.Models
{
    public class MenuItem : IItem
    {
        private string _name;
        public string Name 
        {
            get => _name;
            set => _name = value;
        }

        private string _description;
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        private decimal _price;
        public decimal Price
        {
            get => _price;
            set =>_price = value;
        }

        private DietaryRestrictions _dietaryRestrictions;
        public DietaryRestrictions DietaryRestrictions
        {
            get => _dietaryRestrictions;
            set => _dietaryRestrictions = value;
        }
    }
}
