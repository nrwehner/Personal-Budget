using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PersonalBudgetData.Transaction;

namespace PersonalBudgetModels
{
    public class TransListItem
    {
        public DateTime Date { get; set; }
        public MyAccounts Account { get; set; }
        public BudgetCategories Category { get; set; }
        public decimal Value { get; set; }
    }
}
