using InterviewCR.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCR.Models
{
    public class Order
    {
        public List<IItem> _items;

        public decimal TotalCost => _items.Sum(x => x.Price);
    }
}
