using InterviewCR.Enums;
using InterviewCR.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCR.Models
{
    public class Order
    {
        public List<IItem> Items { get; set; }

        public Order()
        {
            Items = new List<IItem>();
        }

        public void AddToOrder(IItem item)
        {
            Items.Add(item);
        }

        public decimal TotalCost()
        {
            return GetAllMenuItems().Sum(item => item.Price);
        }

        public string Print()
        {
            return string.Join(Environment.NewLine, GetAllMenuItems().Select(item => $" - {item.Name}"));
        }

        public List<MenuItem> GetInvalidItems(DietaryRestrictions dietaryRestriction)
        {
            return GetAllMenuItems().Where(item => dietaryRestriction != DietaryRestrictions.NONE && item.DietaryRestriction != dietaryRestriction).ToList();
        }

        private IEnumerable<MenuItem> GetAllMenuItems()
        {
            return Items.SelectMany(item => item is Combo combo ? combo.Items : new List<MenuItem> { (MenuItem)item });
        }
    }
}
