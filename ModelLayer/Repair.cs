namespace ModelLayer
{
    public class Repair
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public bool IsDone { get; set; }
        public Customer Customer { get; set; }
    }
}
