using TakeHomeAssignment.Communication;
using TakeHomeAssignment.Communication.Requests;

namespace TakeHomeAssignment.Application.Handlers
{
    public class DepositHandler
    {
        private readonly Dictionary<string, int> _accounts;

        public DepositHandler(Dictionary<string, int> accounts)
        {
            _accounts = accounts;
        }

        public ResponseEvent Handle(RequestEvent request)
        {
            var accountId = request.Destination!;
            if (!_accounts.ContainsKey(accountId))
                _accounts[accountId] = 0;

            _accounts[accountId] += request.Amount;

            return new ResponseEvent(201, new
            {
                destination = new
                {
                    id = accountId,
                    balance = _accounts[accountId]
                }
            });
        }
    }
}
