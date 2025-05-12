namespace ProductList.Models
    {
    public class Product
        {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }


        // new 
        public int SupplierId { get; set; } // NEW
        public string Value { get; set; }   // NEW
        public string Serial { get; set; }  // NEW
    }
    }
