using System;

namespace QuestShop.Models {
    public class Order {

        public int Id { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime ProceesedDate { get; set; }
    }
}