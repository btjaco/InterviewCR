using InterviewCR.Interfaces;
using System.Collections.Generic;

namespace InterviewCR.Models
{
    public class Combo : IItem
    {
        private List<MenuItem> _items = new List<MenuItem>();
        public List<MenuItem> Items
        {
            get => _items; 
            set => _items = value;
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value) 
                {
                    _name = value;
                }
            }
        }

        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                if (_description != value)
                {
                    _description = value;
                }
            }
        }

        private decimal _price;
        public decimal Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                }
            }
        }
    }
}
