using Microsoft.AspNetCore.Authentication.Cookies;
using MvcOnlineTicariOtomasyon.Models.Classes;
using System.Security.Claims;

namespace MvcOnlineTicariOtomasyon.Services
{
    public class ClaimService
    {

        public ClaimsIdentity CreateClaimsIdentity<T>(T user)
        {
            var claims = new List<Claim>();

            // Mapping of property names to claim types
            var propertyToClaimTypeMap = new Dictionary<string, string>
            {
                { "CariAd", ClaimTypes.Name },    // Map to Name claim
                { "CariMail", ClaimTypes.Email },  // Map to Email claim
                { "PersonelAd", ClaimTypes.Name }, // Map to Name (or another appropriate claim type)
                { "PersonelMail", ClaimTypes.Email }, // Map to Email (or another claim type)
                { "KullaniciAd", ClaimTypes.Name },
                // Add other mappings as needed
            };

            // Iterate through the properties of the user object
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                var propertyName = property.Name;
                var claimType = propertyToClaimTypeMap.GetValueOrDefault(propertyName);

                if (claimType != null)
                {
                    var claimValue = property.GetValue(user)?.ToString();
                    if (!string.IsNullOrEmpty(claimValue))
                    {
                        claims.Add(new Claim(claimType, claimValue));
                    }
                }
            }

            // If roles are stored in a specific property (e.g., Roles)
            var rolesProperty = typeof(T).GetProperty("Roles");
            if (rolesProperty != null)
            {
                var roles = rolesProperty.GetValue(user) as IEnumerable<string>;
                if (roles != null)
                {
                    foreach (var role in roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role));
                    }
                }
            }

            return new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        }
    }
}
