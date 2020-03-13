using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PersonalBudgetData.Transaction;

namespace PersonalBudgetModels
{
    public class MonthlyTransactions
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public MyAccounts Account { get; set; }
        public BudgetCategories MyProperty { get; set; }
        public string Description { get; set; }
        public decimal Credit { get; set; }
        public decimal Debit { get; set; }
        public decimal Balance { get; set; }
    }
}
