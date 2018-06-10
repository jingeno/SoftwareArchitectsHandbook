
namespace SoftwareArchitectsHandbook.Chapter06.LiskovSubstitutionPrinciple
{
    public class Square : Rectangle
    {
        private int _width;
        private int _height;

        public override int Width
        {
            get { return _width; }
            set
            {
                _width = value;
                _height = value;
            }
        }

        public override int Height
        {
            get { return _height; }
            set
            {
                _width = value;
                _height = value;
            }
        }
    }
}
