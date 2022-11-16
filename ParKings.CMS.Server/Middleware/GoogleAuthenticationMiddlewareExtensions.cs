namespace ParKings.CMS.Server.Middleware;

public static class GoogleAuthenticationMiddlewareExtensions {
    public static IApplicationBuilder UseGoogleAuthenticationMiddleware(this IApplicationBuilder app) {
        return app.UseMiddleware<GoogleAuthenticationMiddleware>();
    }
}
