namespace onlineshopsite.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
