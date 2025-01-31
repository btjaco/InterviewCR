using InterviewCR.Enums;
using InterviewCR.Interfaces;

namespace InterviewCR.Models
{
    public class MenuItem : IItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DietaryRestrictions DietaryRestriction { get; set; }

        public MenuItem(string name, DietaryRestrictions dietaryRestrictions, decimal price)
        {
            Name = name;
            DietaryRestriction = dietaryRestrictions;
            Price = price;
        }
    }
}
