
namespace SoftwareArchitectsHandbook.Chapter06.InterfaceSegregationPrinciple
{
    public interface IMovie : IProductRefactored
    {
        int RunningTime { get; set; }
    }
}
