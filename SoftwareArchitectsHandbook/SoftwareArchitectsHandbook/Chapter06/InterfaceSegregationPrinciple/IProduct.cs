
namespace SoftwareArchitectsHandbook.Chapter06.InterfaceSegregationPrinciple
{
    public interface IProduct
    {
        int ProductId { get; set; }
        string Title { get; set; }
        int AuthorId { get; set; }
        decimal Price { get; set; }
    }
}
