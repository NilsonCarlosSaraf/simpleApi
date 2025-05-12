using TakeHomeAssignment.Communication;
using TakeHomeAssignment.Communication.Requests;

namespace TakeHomeAssignment.Application.Handlers
{
    public class WithdrawHandler
    {
        private readonly Dictionary<string, int> _accounts;

        public WithdrawHandler(Dictionary<string, int> accounts)
        {
            _accounts = accounts;
        }

        public EventResult Handle(RequestEvent request)
        {
            var origin = request.Origin!;
            if (!_accounts.ContainsKey(origin) || _accounts[origin] < request.Amount)
                return new EventResult(404, 0);

            _accounts[origin] -= request.Amount;

            return new EventResult(201, new
            {
                origin = new
                {
                    id = origin,
                    balance = _accounts[origin]
                }
            });
        }
    }
}
