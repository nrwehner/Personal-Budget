using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PersonalBudgetData.Transaction;

namespace PersonalBudgetModels
{
    public class EnterTransaction
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public MyAccounts Account { get; set; }
        [Required]
        public BudgetCategories Category { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Description Can Only Be 200 Characters Long")]
        public string Description { get; set; }
        [Required]
        public decimal Value { get; set; }
    }
}
