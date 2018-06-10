using System;

namespace SoftwareArchitectsHandbook.Chapter06.InterfaceSegregationPrinciple
{
    public class Movie : IProduct
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public int AuthorId
        {
            get => throw new NotSupportedException();
            set => throw new NotSupportedException();
        }
        public decimal Price { get; set; }
        public int RunningTime { get; set; }
    }
}
