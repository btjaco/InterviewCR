using InterviewCR.Interfaces;
using System.Collections.Generic;

namespace InterviewCR.Models
{
    public class Combo : IItem
    {
        public List<MenuItem> Items { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Combo(params MenuItem[] items)
        {
            Items = new List<MenuItem>();
            Items.AddRange(items);
        }
    }
}
