using InterviewCR.Interfaces;
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

        public decimal TotalCost()
        {
            return Items.Sum(x => x.Price);
        }
    }
}
