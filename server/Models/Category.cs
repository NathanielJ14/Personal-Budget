namespace YourNamespace.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PlannedAmount { get; set; }
        public decimal ActualSpent { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
