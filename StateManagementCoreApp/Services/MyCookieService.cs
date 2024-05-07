using Microsoft.AspNetCore.DataProtection;

namespace StateManagementCoreApp.Services
{
    public class MyCookieService
    {
        private readonly IDataProtector dataProtector;
        public MyCookieService(IDataProtectionProvider dataProtector)
        {
            //this.dataProtector = dataProtector;
            this.dataProtector = dataProtector.CreateProtector("MyCookieProtector");
        }

        public string Protect(string cookieValue)
        {
            return dataProtector.Protect(cookieValue);
        }
        public string UnProtect(string cookieValue)
        {
            return dataProtector.Unprotect(cookieValue);
        }
    }
}
