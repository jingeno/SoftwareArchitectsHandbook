
namespace SoftwareArchitectsHandbook.Chapter06.InterfaceSegregationPrinciple
{
    public class MovieRefactored : IProductRefactored
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int RunningTime { get; set; }

    }
}
