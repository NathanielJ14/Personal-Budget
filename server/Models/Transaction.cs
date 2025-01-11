namespace YourNamespace.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string Type { get; set; } // 'Income' or 'Expense'

        // Foreign key to Budget
        public int BudgetId { get; set; }
        public Budget Budget { get; set; }

        // Foreign key to Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
