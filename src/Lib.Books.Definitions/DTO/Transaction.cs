using System;
using NodaMoney;

namespace Lib.Books.Definitions
{
    public class Transaction
    {
        public Guid id { get; }
        public Money Amount { get; set; }
        public string Description { get; set; }
        public string FromAccount { get; set; }
        public string ToAccount { get; set; }
        public DateTime RecordedAt { get; set; }
        public string Idendifier { get; set; }
    }
}
