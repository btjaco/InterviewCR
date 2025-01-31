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

        public IEnumerable<MenuItem> GetAllMenuItems()
        {
            return Items.SelectMany(item => item is Combo combo ? combo.Items : new List<MenuItem> { (MenuItem)item });
        }

        public decimal TotalCost()
        {
            return Items.SelectMany(item => item is Combo combo ? combo.Items : new List<MenuItem> { (MenuItem)item })
                .Sum(item => item.Price);
        }

        public string Print()
        {
            return string.Join(Environment.NewLine, Items.SelectMany(item =>
                item is Combo combo ? combo.Items : new List<MenuItem> { (MenuItem)item })
                .Select(item => $" - {item.Name}"));
        }
    }
}
