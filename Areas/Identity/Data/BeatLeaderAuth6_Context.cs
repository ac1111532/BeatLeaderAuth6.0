using BeatLeaderAuth6._0.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeatLeaderAuth6._0.Areas.Identity.Data;

public class BeatLeaderAuth6_Context : IdentityDbContext<BeatLeaderAuth6_User>
{
    public BeatLeaderAuth6_Context(DbContextOptions<BeatLeaderAuth6_Context> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
