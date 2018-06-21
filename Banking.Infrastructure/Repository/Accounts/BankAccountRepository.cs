﻿namespace Banking.Infrastructure.Repository.Accounts
{
    using Banking.Domain.Entity.Accounts;
    using Banking.Domain.Repository.Accounts;
    using Common;

    public class BankAccountRepository : BaseRepository<BankAccount>, IBankAccountRepository
    {
        public BankAccountRepository(BankingContext context)
           : base(context)
        {
        }
    }
}
