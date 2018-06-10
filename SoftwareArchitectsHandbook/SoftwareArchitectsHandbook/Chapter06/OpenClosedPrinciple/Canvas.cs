
namespace SoftwareArchitectsHandbook.Chapter06.OpenClosedPrinciple
{
    public class Canvas
    {
        public void DrawShape(Shape shape)
        {
            if (shape is Rectangle)
                DrawRectangle((Rectangle)shape);

            if (shape is Circle)
                DrawCircle((Circle)shape);
        }

        public void DrawRectangle(Rectangle r)
        {
            // Logic to draw a rectangle
        }

        public void DrawCircle(Circle c)
        {
            // Logic to draw a circle
        }
    }
}
