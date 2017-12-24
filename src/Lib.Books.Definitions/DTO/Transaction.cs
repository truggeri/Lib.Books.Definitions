using System;
using NodaMoney;

namespace Lib.Books.Definitions
{
    public class Transaction
    {
        public Guid Id { get; }
        public Money Amount { get; set; }
        public string Description { get; set; }
        public Account FromAccount { get; set; }
        public Account ToAccount { get; set; }
        public DateTime RecordedAt { get; set; }
        public string Idendifier { get; set; }
    }
}
