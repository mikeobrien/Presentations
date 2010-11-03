using System;
using DDDApplication.Infrastructure;

namespace DDDApplication.Domain
{
    public class TransferService
    {
        private IRepository<Account> _accountRepo;
        private IRepository<Bank> _bankRepo;
        private IRepository<Customer> _customerRepo;

        public TransferService(IRepository<Account> accountRepo, IRepository<Bank> bankRepo, IRepository<Customer> customerRepo)
        {
            _accountRepo = accountRepo;
            _bankRepo = bankRepo;
            _customerRepo = customerRepo;
        }

        public void Transfer(Guid custId, Guid bankId, Guid sourceAccountId, Guid destAccountId)
        {
            Customer cust = _customerRepo.Get(custId);
            Bank bank = _bankRepo.Get(bankId);
            Account source = _accountRepo.Get(sourceAccountId);
            Account destination = _accountRepo.Get(destAccountId);

            // Do the transfer...
        }
    }
}
