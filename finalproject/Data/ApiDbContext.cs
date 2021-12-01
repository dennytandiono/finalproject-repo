using Microsoft.EntityFrameworkCore;
using finalproject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace finalproject.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<PaymentItem> Items { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}