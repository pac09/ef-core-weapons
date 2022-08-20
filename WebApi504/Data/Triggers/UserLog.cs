using EntityFrameworkCore.Triggered;
using System.Threading.Tasks;
using System.Threading;
using EntityFrameworkCore.Triggered;
using WebApi504.Data.Models;

namespace WebApi504.Data.Triggers
{
    public class UserLog : IBeforeSaveTrigger<User>
    {
        readonly FinanceContext _context;

        public UserLog(FinanceContext context)
        {
            _context = context;
        }

        public Task BeforeSave(ITriggerContext<User> context, CancellationToken cancellationToken)
        {
            var newLog = new Log()
            {
                Activity = "User successfully created"
            };

            _context.Add(newLog);
            _context.SaveChanges();

            return Task.CompletedTask;
        }
    }
}
