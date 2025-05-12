using TakeHomeAssignment.Communication;
using TakeHomeAssignment.Communication.Requests;

namespace TakeHomeAssignment.Application.Handlers
{
    public class TransferHandler
    {
        private readonly Dictionary<string, int> _accounts;

        public TransferHandler(Dictionary<string, int> accounts)
        {
            _accounts = accounts;
        }

        public EventResult Handle(RequestEvent request)
        {
            var origin = request.Origin!;
            var destination = request.Destination!;

            if (!_accounts.ContainsKey(origin) || _accounts[origin] < request.Amount)
                return new EventResult(404, 0);

            _accounts[origin] -= request.Amount;

            if (!_accounts.ContainsKey(destination))
                _accounts[destination] = 0;

            _accounts[destination] += request.Amount;

            return new EventResult(201, new
            {
                origin = new
                {
                    id = origin,
                    balance = _accounts[origin]
                },
                destination = new
                {
                    id = destination,
                    balance = _accounts[destination]
                }
            });
        }
    }
}
