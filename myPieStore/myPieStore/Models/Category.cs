using System.Collections.Generic;

namespace myPieStore.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
        public int Description { get; set; }
        public List<Pie> Pies { get; set; }
    }
}