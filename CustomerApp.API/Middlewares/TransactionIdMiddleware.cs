namespace CustomerApp.API.Middlewares
{
    public class TransactionIdMiddleware
    {
        private readonly RequestDelegate _next;

        public TransactionIdMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Items["TransactionId"] = Guid.NewGuid().ToString();
            await _next(context);
        }
    }
}
