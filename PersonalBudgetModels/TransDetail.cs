using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PersonalBudgetData.Transaction;

namespace PersonalBudgetModels
{
    public class TransDetail
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public MyAccounts Account { get; set; }
        public BudgetCategories Category { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
