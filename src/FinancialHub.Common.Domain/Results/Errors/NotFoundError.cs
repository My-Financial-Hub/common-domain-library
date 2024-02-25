namespace FinancialHub.Common.Domain.Results.Errors
{
    public class NotFoundError : ServiceError
    {
        private const int code = 404;
        public NotFoundError(string message) : base(code, message)
        {
        }
    }
}
