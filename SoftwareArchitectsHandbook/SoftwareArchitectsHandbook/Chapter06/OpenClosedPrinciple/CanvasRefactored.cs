
namespace SoftwareArchitectsHandbook.Chapter06.OpenClosedPrinciple
{
    public class CanvasRefactored
    {
        public void DrawShape(IShape shape)
        {
            shape.Draw();
        }
    }
}
