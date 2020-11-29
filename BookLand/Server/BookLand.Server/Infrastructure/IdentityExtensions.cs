namespace BookLand.Server.Infrastructure
{
    using System.Security.Claims;

    public static class IdentityExtensions
    {
        public static string GetId(this ClaimsPrincipal principal)
        {
            return principal
                .FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public static string GetName(this ClaimsPrincipal principal)
        {
            return principal
                .FindFirstValue(ClaimTypes.Name);
        }
    }
}
