using System.Collections.Generic;

namespace ModelLayer
{
    public class Sale
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
    }
}
