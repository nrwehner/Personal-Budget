using PersonalBudgetData;
using PersonalBudgetModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PersonalBudgetData.Transaction;

namespace PersonalBudgetServices
{
    public class TransactionService
    {
        public bool EnterTransaction(EnterTransaction transaction)
        {
            var newTransaction =
                new Transaction()
                {
                    Date = transaction.Date,
                    Account = transaction.Account,
                    Category = transaction.Category,
                    Description = transaction.Description,
                    Value = transaction.Value,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new BudgetDbContext())
            {
                ctx.Transactions.Add(newTransaction);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<TransDetail> GetTransactions()
        {
            using (var ctx = new BudgetDbContext())
            {
                var query =
                    ctx
                    .Transactions
                    .Select(
                        e =>
                        new TransDetail
                        {
                            Id = e.Id,
                            Date = e.Date,
                            Account = e.Account,//displaying the reference # in the enum now
                            Category = e.Category,//displaying the reference # in the enum now
                            Description = e.Description,
                            Value = e.Value,
                            CreatedUtc = e.CreatedUtc,
                            ModifiedUtc = e.ModifiedUtc
                        }
                        );

                return query.ToArray();
            }
        }
    }
}
