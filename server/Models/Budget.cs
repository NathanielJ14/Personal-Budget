namespace YourNamespace.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal StartingBalance { get; set; }
        public decimal EndingBalance { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
