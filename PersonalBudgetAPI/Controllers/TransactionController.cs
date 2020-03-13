using PersonalBudgetModels;
using PersonalBudgetServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PersonalBudgetAPI.Controllers
{
    public class TransactionController : ApiController
    {
        public IHttpActionResult Get()
        {
            TransactionService transactionService = CreateTransactionService();
            var transactions = transactionService.GetTransactions();
            return Ok(transactions);
        }

        public IHttpActionResult Post(EnterTransaction transaction)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateTransactionService();

            if (!service.EnterTransaction(transaction))
                return InternalServerError();

            return Ok(transaction);
        }

        //Not sure if this is necessary without identity/authentification
        private TransactionService CreateTransactionService()
        {
            var transactionService = new TransactionService();
            return transactionService;
        }
    }
}
