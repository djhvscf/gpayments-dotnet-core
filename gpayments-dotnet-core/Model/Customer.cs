namespace gpayments_core.Model
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Currency { get; set; }
        public string Key { get; set; }
        public Card Card { get; set; }
    }
}
