namespace FootBall.API.Context
{
    using FootBall.API.Models;
    using Microsoft.EntityFrameworkCore;

    public sealed class UserContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public UserContext(DbContextOptions<UserContext> options) 
            : base(options)
        {
            this.Database.EnsureCreated();
        }
    }
}
