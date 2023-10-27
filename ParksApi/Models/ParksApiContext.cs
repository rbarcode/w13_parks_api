using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ParksApi.Models
{
  public class ParksApiContext : IdentityDbContext<ApplicationUser>
  {
    DbSet<Park> Parks { get; set; }

    public ParksApiContext(DbContextOptions<ParksApiContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
            .HasData(
              new Park { ParkId = 1, Name = "Yosemite National Park", Location = "CA", Authority = "National" },
              new Park { ParkId = 2, Name = "Joshua Tree National Park", Location = "CA", Authority = "National" },
              new Park { ParkId = 3, Name = "Sequoia National Park", Location = "CA", Authority = "National" },
              new Park { ParkId = 4, Name = "Channel Islands National Park", Location = "CA", Authority = "National" },
              new Park { ParkId = 5, Name = "Death Valley National Park", Location = "CA", Authority = "National" },
              new Park { ParkId = 6, Name = "Kings Canyon National Park", Location = "CA", Authority = "National" },
              new Park { ParkId = 7, Name = "Point Mugu Park", Location = "CA", Authority = "State" },
              new Park { ParkId = 8, Name = "El Presidio de Santa Barbara State Historic Park", Location = "CA", Authority = "State" },
              new Park { ParkId = 9, Name = "Monterey State Beach", Location = "CA", Authority = "State" },
              new Park { ParkId = 10, Name = "Tahoe State Recreation Area", Location = "CA", Authority = "State" },
              new Park { ParkId = 11, Name = "Denali National Park and Preserve", Location = "AK", Authority = "National" },
              new Park { ParkId = 12, Name = "Kenai Fjords National Park", Location = "AK", Authority = "National" },
              new Park { ParkId = 13, Name = "Gates of the Artic National Park and Preserve", Location = "AK", Authority = "National" },
              new Park { ParkId = 14, Name = "Glacier Bay National Park and Preserve", Location = "AK", Authority = "National" },
              new Park { ParkId = 15, Name = "Katmai National Park and Preserve", Location = "AK", Authority = "National" },
              new Park { ParkId = 16, Name = "Wrangell-St Elias National Park and Preserve", Location = "AK", Authority = "National" },
              new Park { ParkId = 17, Name = "Chugach State Park", Location = "AK", Authority = "State" },
              new Park { ParkId = 18, Name = "Kachemak Bay State Park", Location = "AK", Authority = "State" },
              new Park { ParkId = 19, Name = "Wood-TikChik State Park", Location = "AK", Authority = "State" }
            );

          PasswordHasher<IdentityUser> hasher = new();

          builder.Entity<ApplicationUser>()
            .HasData(
              new ApplicationUser { Id = "abc123", UserName = "James", NormalizedUserName = "JOEY", Email = "james@test.com", NormalizedEmail = "JAMES@TEST.COM", PasswordHash = hasher.HashPassword(null, "epicodus")},
              new ApplicationUser { Id = "def456", UserName = "Mary", NormalizedUserName = "MARY", Email = "mary@test.com", NormalizedEmail = "MARY@TEST.COM", PasswordHash = hasher.HashPassword(null, "epicodus")}
            );

          base.OnModelCreating(builder);
        }
    }
}