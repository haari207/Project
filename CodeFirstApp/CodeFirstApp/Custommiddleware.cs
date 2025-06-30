namespace CodeFirstApp
{
    public class Custommiddleware
    {

        private readonly RequestDelegate _requestDelegate;
        public Custommiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }
        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("custom middleware executing");
            await _requestDelegate(context);
        }
    }
}
