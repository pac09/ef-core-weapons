using EntityFrameworkCore.Triggered;
using System.Threading.Tasks;
using System.Threading;
using WebApi504.Data.Models;
namespace WebApi504.Data.Triggers
{
    public class UserErasedLog : IAfterSaveTrigger<User>
    {
        private readonly FinanceContext _context;

        public UserErasedLog(FinanceContext context)
        {
            _context = context;
        }

        public Task AfterSave(ITriggerContext<User> context, CancellationToken cancellationToken) 
        {
            var newLog = new Log()
            {
                Activity = "User successfully deleted"
            };

            _context.Add(newLog);
            _context.SaveChanges();

            return Task.CompletedTask;
        }
    }
}
