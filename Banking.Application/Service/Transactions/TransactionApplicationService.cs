﻿namespace Banking.Application.Service.Transactions
{
    using Domain.Repository.Common;

    public class TransactionApplicationService: ITransactionApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TransactionApplicationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void PerformTransfer()
        {
            var customers = _unitOfWork.Customers.GetByIdWithBankAccounts(2);
            //var bankAccounts = _unitOfWork.BankAccounts.Get(1);

        }
    }
}
