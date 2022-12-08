using Google.Apis.Auth;
using System.Net;

namespace ParKings.CMS.Server.Middleware;

public class GoogleAuthenticationMiddleware : IMiddleware {
    public async Task InvokeAsync(HttpContext context, RequestDelegate next) {
        string token = context.Request.Query["token"].ToString();
        if (string.IsNullOrEmpty(token)) {
            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return;
        }

        try {
            await GoogleJsonWebSignature.ValidateAsync(token);
        } catch (InvalidJwtException) {
            context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            return;
        }
        await next.Invoke(context);
    }
}
