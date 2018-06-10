
namespace SoftwareArchitectsHandbook.Chapter06.InterfaceSegregationPrinciple
{
    public interface IProductRefactored
    {
        int ProductId { get; set; }
        string Title { get; set; }
        decimal Price { get; set; }
    }
}
