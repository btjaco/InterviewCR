using InterviewCR.Interfaces;
using System.Collections.Generic;

namespace InterviewCR.Models
{
    public class Combo : IItem
    {
        public List<MenuItem> Items { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
