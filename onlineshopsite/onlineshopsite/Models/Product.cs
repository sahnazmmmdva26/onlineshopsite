namespace onlineshopsite.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public int SizeId { get; set; }
        public Size Size  { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
    }
   
}
