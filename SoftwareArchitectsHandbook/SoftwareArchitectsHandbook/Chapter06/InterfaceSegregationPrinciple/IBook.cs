
namespace SoftwareArchitectsHandbook.Chapter06.InterfaceSegregationPrinciple
{
    public interface IBook : IProductRefactored
    {
        int AuthorId { get; set; }
    }
}
