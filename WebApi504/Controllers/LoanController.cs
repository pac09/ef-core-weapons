using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using WebApi504.Data.Models;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi504.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly FinanceContext _context;

        public LoanController(FinanceContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post(int personId, int amount) 
        {
            using IDbContextTransaction transaction = _context.Database.BeginTransaction();

            try
            {
                #region Step1

                var creditSubjet = _context.People.SingleOrDefault(a => a.PersonId == personId);
                var dividedAmount = amount / 3;

                //Step #1: Verify Social Security
                var isPersonInsured = _context.SocialSecurities.Any(a => a.PersonId == personId);
                if (isPersonInsured)
                {
                    var newLoan = new Loan()
                    {
                        PersonId = personId,
                        Amount = dividedAmount,
                        CreationDate = DateTime.Now
                    };

                    _context.Add(newLoan);
                    await _context.SaveChangesAsync();

                    await transaction.CreateSavepointAsync("FirstLoanAmountCreated");
                }
                else
                    throw new Exception("Step1");

                #endregion

                #region Step2
                //Step #2: Check the Credit level
                var creditsTotalAmount = _context.Credits
                    .Where(a => a.PersonId == personId)
                    .Sum(b => b.Amount);

                var loanToUpdate = GetLoanToUpdate(personId);

                if (creditsTotalAmount <= 300)
                {                  
                    if (loanToUpdate == null)
                        throw new Exception("Step2");

                    loanToUpdate.Amount += dividedAmount;

                    _context.Loans.Update(loanToUpdate);
                    await _context.SaveChangesAsync();

                    await transaction.CreateSavepointAsync("SecondLoanAmountCreated");
                }
                else 
                    throw new Exception("Step2");

                #endregion

                #region Step3

                var existenceOfLoansForCreditSubject = _context.Loans
                    .Any(a => a.PersonId == personId && a.EndDate == null);

                if (existenceOfLoansForCreditSubject) 
                {
                    loanToUpdate.Amount += dividedAmount;
                    loanToUpdate.EndDate = DateTime.Now.AddDays(1);

                    _context.Loans.Update(loanToUpdate);
                    await _context.SaveChangesAsync();

                    await transaction.CommitAsync();
                }
                else
                    throw new Exception("Step3");

                #endregion

            }
            catch (Exception ex) 
            {
                if(ex.Message.Equals("Step2"))
                    await transaction.RollbackToSavepointAsync("FirstLoanAmountCreated");
                else if(ex.Message.Equals("Step3"))
                    await transaction.RollbackToSavepointAsync("SecondLoanAmountCreated");

                await transaction.CommitAsync();
            }

            return Ok();
        }

        private Loan GetLoanToUpdate(int personId) => 
            _context.Loans.Where(a => a.EndDate == null && a.PersonId == personId).FirstOrDefault();

    }
}
