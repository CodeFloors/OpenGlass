using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.WebApi.DbContext
{
    public class OpenGlassDbContext : IdentityDbContext<IdentityUser>

    {
        public OpenGlassDbContext(DbContextOptions<OpenGlassDbContext> option) : base(option)
        {

        }
    }
}
