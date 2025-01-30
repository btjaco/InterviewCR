using InterviewCR.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCR.Models
{
    public class Order
    {
        private List<IItem> _items;
        public List<IItem> Items
        {
            get => _items;
            set => _items = value;
        }

        public decimal TotalCost()
        {
            return _items.Sum(x => x.Price);
        }
    }
}
