
    namespace BankingApp.Models
    {
        public class Transaction
        {
            public int Id { get; set; }
            public DateTime Date { get; set; }
            public decimal Amount { get; set; }
            public string Description { get; set; }

            // Foreign key to Account
            public int AccountId { get; set; }
            public Account Account { get; set; }
        }
    }


