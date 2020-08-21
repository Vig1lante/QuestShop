using System.Collections.Generic;

namespace QuestShop.Models {
    public class Product: IItemThumbnail {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public double Price { get; set; }
        public bool Stock { get; set; }
        public IList<Order> Order { get; set; }
    }
}   