using System;
using NodaMoney;

namespace Lib.Books.Definitions.DTO
{
    public class Account
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public Currency DefaultCurrency { get; set; } 
        public DateTime DateOpened { get; }

        Account()
        {
            this.DateOpened = DateTime.Now;
        }
    }
}