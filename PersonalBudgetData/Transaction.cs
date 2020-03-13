using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetData
{
    public class Transaction
    {
        public enum MyAccounts { Elements,Chase,PNC,Amex,eTrade,eTradeRoth,Optum,ElementsHSA,AssetEquity,
            Fidelity,NRECA,RESERVE,CASH,TRANSFER}
        public enum BudgetCategories { Income, Fidelity, AssetEquity, ElementsHSADeposit, MiscIncome, ChaseReward, 
            InterestElements, InterestAmex, InteresteTrade, InteresteTradeRoth, InterestFidelity, InterstNRECA, 
            ReserveOther,ElementsHSAWithdrawal,RetireFidelity,RetireRothIRA,ReserveSavings,SophiaSquare,GivingExtra,
            IndyStar,DukeEnergy,NetFlix,Spectrum,Verizon,StateFarm,UtilityRecoverySystems,Food,Gas,Entertainment,
            Households,Personal,MiscExpense,BMVLicensePlate,Christmas,Clothing,Haircut,OilChange}

        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public MyAccounts Account { get; set; }
        [Required]
        public BudgetCategories Category { get; set; }
        [Required]
        [MaxLength(200,ErrorMessage ="Description Can Only Be 200 Characters Long")]
        public string Description { get; set; }
        [Required]
        public decimal Value { get; set; }
        //public decimal Balance { get; set; }//probably won't need this in the database
        [Display(Name ="Creation Time")]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
