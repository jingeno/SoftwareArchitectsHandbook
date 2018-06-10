namespace SoftwareArchitectsHandbook.Chapter06.InterfaceSegregationPrinciple
{
    public class Book : IProduct
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public decimal Price { get; set; }
    }
}
