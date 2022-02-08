using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BaseApp.Models
{
    public class AppIdentityDbcontext:IdentityDbContext<AppUser>
    {
        public AppIdentityDbcontext(DbContextOptions<AppIdentityDbcontext> options):base(options)
        {

        }
    }
}
