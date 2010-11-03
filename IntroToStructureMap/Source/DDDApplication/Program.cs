using System;
using DDDApplication.Application;
using DDDApplication.Domain;

namespace DDDApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TransferService transferService = Registry.Current.Resolve<TransferService>();

            Guid custId = Guid.NewGuid();
            Guid bankId = Guid.NewGuid();
            Guid sourceAcctId = Guid.NewGuid();
            Guid destAcctId = Guid.NewGuid();

            transferService.Transfer(custId, bankId, sourceAcctId, destAcctId);

            Console.WriteLine("Transfer complete!");
            Console.ReadKey();
        }
    }
}
